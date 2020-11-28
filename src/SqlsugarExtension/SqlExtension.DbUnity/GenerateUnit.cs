using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using SqlSugar;

namespace SqlExtension.DbUnity
{
    public class GenerateUnit
    {
        private SqlSugarClient _db;

        private string _namespace;

        public GenerateUnit(string connStr, string nameSpace = "QsModels")
        {
            this._db = DbSqlUnity.GetSqlClient(connStr);
            _namespace = nameSpace;
        }
        
        public string GenerateSingleQsModel(string schema, string table)
        {
            try
            {
                _db.BeginTran();

                if (schema.IsDangeString() || table.IsDangeString())
                {
                    throw new Exception($"检测到危险字符，【{schema}】、【{table}】");
                }

                var dbProvider = _db.DbFirst as DbFirstProvider;

                _db.Ado.ExecuteCommand($"use {schema}");

                var tableInfoList = dbProvider.Context.DbMaintenance.GetTableInfoList(false);
                var columnInfos = dbProvider.Context.DbMaintenance.GetColumnInfosByTableName(table, false);

                #region 调整列的排序
                {
                    var colSql = $@"
                        select TABLE_SCHEMA,TABLE_NAME,	COLUMN_NAME,ORDINAL_POSITION 
                        from information_schema.`COLUMNS` 
                        where TABLE_SCHEMA='{schema}' and TABLE_NAME='{table}'
                        order by ORDINAL_POSITION";
                    var colDt = _db.Ado.GetDataTable(colSql, new { });
                    var rows = colDt.Rows.Cast<DataRow>().ToList();
                    columnInfos = columnInfos.OrderBy(a =>
                    {
                        var curRow = rows.Where(b => b["COLUMN_NAME"].ToString() == a.DbColumnName).First();
                        var order = Convert.ToInt32(curRow["ORDINAL_POSITION"]);
                        return order;
                    }).ToList();
                }
                #endregion

                #region 调整字段类型
                {
                    var sql = $@"
                        select *
                        from {schema}.{table}
                        where 1=2";
                    var dt = _db.Ado.GetDataTable(sql, new { });
                    //columnInfos.ForEach(item =>
                    //{
                    //    item.DataType = dt item.DbColumnName
                    //});
                    foreach (DataColumn col in dt.Columns)
                    {
                        var matchCol = columnInfos.FirstOrDefault(a => a.DbColumnName == col.ColumnName);
                        if (matchCol != null)
                        {
                            matchCol.PropertyType = col.DataType;
                        }
                    }
                }
                #endregion 

                var nameLower = table.ToLower();
                var tableInfo = tableInfoList.FirstOrDefault(a => a.Name.ToLower() == nameLower);

                if (tableInfo == null || columnInfos.Count <= 0)
                {
                    return "";
                }

                var match = dbProvider.Where(table);

                var codeStr = GetDbModelString(tableInfo, columnInfos, schema, table);
                return codeStr;
            }
            catch(Exception e)
            {
                _db.RollbackTran();
                throw e;
            }

        }


        internal string GetDbModelString(DbTableInfo tableInfo, List<DbColumnInfo> columns, string schema, string table)
        {
            string classText;

            classText = ModelTemplate.ClassTemplate;

            classText = classText.Replace(ModelTemplate.KeyTimeSpan, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

            classText = classText.Replace(ModelTemplate.KeyClassName, tableInfo.Name.ToLargeCamelCase());
            classText = classText.Replace(ModelTemplate.KeyNamespace, _namespace);
            classText = classText.Replace(ModelTemplate.KeyUsing, ModelTemplate.UsingTemplate);

            var classDescriptionTemplate = ModelTemplate.ClassDescriptionTemplate.Replace(ModelTemplate.KeyClassDescription, tableInfo.Description);
            classText = classText.Replace(ModelTemplate.KeyClassDescription, classDescriptionTemplate);
            classText = classText.Replace(ModelTemplate.KeySugarTable, string.Format(ModelTemplate.ValueSugarTable, $"{schema}.{table}"));

            if (columns.Count > 0)
            {
                foreach (var item in columns)
                {
                    var isLast = columns.Last() == item;
                    var index = columns.IndexOf(item);
                    string propertyText = ModelTemplate.PropertyTemplate;
                    string PropertyDescriptionText = ModelTemplate.PropertyDescriptionTemplate;
                    string propertyName = item.DbColumnName;
                    string propertyTypeName = GetPropertyTypeName(item);
                    propertyText = GetPropertyText(item, propertyText);
                    PropertyDescriptionText = GetPropertyDescriptionText(item, PropertyDescriptionText);
                    propertyText = PropertyDescriptionText + propertyText;

                    // 对Queryshooter的单表查询model列，生成列特性
                    //propertyText = FixQueryShooterColumnText(item, propertyText);

                    classText = classText.Replace(ModelTemplate.KeyPropertyName, propertyText + (isLast ? "" : ("\r\n" + ModelTemplate.KeyPropertyName)));
                }
            }

            classText = classText.Replace(ModelTemplate.KeyPropertyName, null);
            return classText;
        }

        private string GetPropertyText(DbColumnInfo item, string propertyText)
        {
            string SugarColumnText = "";
            var propertyName = item.DbColumnName;
            var hasSugarColumn = item.IsPrimarykey == true || item.IsIdentity == true;

            if (hasSugarColumn)
            {
                List<string> joinList = new List<string>();
                if (item.IsPrimarykey)
                {
                    joinList.Add("IsPrimaryKey = true");
                }
                if (item.IsIdentity)
                {
                    joinList.Add("IsIdentity = true");
                }

                SugarColumnText = string.Format(ModelTemplate.ValueSugarCoulmn, string.Join(", ", joinList));
            }

            string typeString = GetPropertyTypeName(item);

            propertyText = propertyText.Replace(ModelTemplate.KeySugarColumn, SugarColumnText);
            propertyText = propertyText.Replace(ModelTemplate.KeyPropertyType, typeString);
            propertyText = propertyText.Replace(ModelTemplate.KeyPropertyName, propertyName);
            return propertyText;
        }

        private string GetPropertyTypeName(DbColumnInfo item)
        {
            string result = item.PropertyType != null ? item.PropertyType.FullName : _db.Ado.DbBind.GetPropertyTypeName(item.DataType);

            string[] nullType = { "string", "byte[]", "object" };
            if (item.IsNullable && !item.PropertyType.IsClass)// nullType.Contains(result.ToLower()))
            {
                result += "?";
            }
            return result;
        }

        private string GetPropertyTypeConvert(DbColumnInfo item)
        {
            var convertString = GetProertypeDefaultValue(item);
            if (convertString == "DateTime.Now" || convertString == null)
                return convertString;
            if (convertString.ObjToString() == "newid()")
            {
                return "Guid.NewGuid()";
            }
            if (item.DataType == "bit")
                return (convertString == "1" || convertString.Equals("true", StringComparison.CurrentCultureIgnoreCase)).ToString().ToLower();
            string result = _db.Ado.DbBind.GetConvertString(item.DataType) + "(\"" + convertString + "\")";
            return result;
        }

        private string GetProertypeDefaultValue(DbColumnInfo item)
        {
            var result = item.DefaultValue;
            if (result == null) return null;
            if (Regex.IsMatch(result, @"^\(\'(.+)\'\)$"))
            {
                result = Regex.Match(result, @"^\(\'(.+)\'\)$").Groups[1].Value;
            }
            if (Regex.IsMatch(result, @"^\(\((.+)\)\)$"))
            {
                result = Regex.Match(result, @"^\(\((.+)\)\)$").Groups[1].Value;
            }
            if (Regex.IsMatch(result, @"^\((.+)\)$"))
            {
                result = Regex.Match(result, @"^\((.+)\)$").Groups[1].Value;
            }
            if (result.Equals("sysdate()", StringComparison.CurrentCultureIgnoreCase))
            {
                result = "DateTime.Now";
            }
            result = result.Replace("\r", "\t").Replace("\n", "\t");
            result = new string[] { "''", "\"\"" }.Contains(result) ? string.Empty : result;
            return result;
        }

        private string GetPropertyDescriptionText(DbColumnInfo item, string propertyDescriptionText)
        {
            propertyDescriptionText = propertyDescriptionText.Replace(ModelTemplate.KeyPropertyDescription, GetColumnDescription(item.ColumnDescription));
            propertyDescriptionText = propertyDescriptionText.Replace(ModelTemplate.KeyDefaultValue, GetProertypeDefaultValue(item));
            propertyDescriptionText = propertyDescriptionText.Replace(ModelTemplate.KeyIsNullable, item.IsNullable.ObjToString());
            return propertyDescriptionText;
        }

        private string GetColumnDescription(string columnDescription)
        {
            if (columnDescription == null) return columnDescription;
            columnDescription = columnDescription.Replace("\r", "\t");
            columnDescription = columnDescription.Replace("\n", "\t");
            columnDescription = Regex.Replace(columnDescription, "\t{2,}", "\t");
            columnDescription = columnDescription.Trim();
            return columnDescription;
        }

    }
}
