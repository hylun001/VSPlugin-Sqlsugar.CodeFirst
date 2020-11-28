using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlExtension.Models;
using SqlSugar;

namespace SqlExtension.DbUnity
{
    public class DbSqlUnity
    {
        public static SqlSugarClient GetSqlClient(string connStr)
        {
            //创建数据库对象
            SqlSugarClient db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = connStr,//连接符字串
                DbType = DbType.MySql,
                IsAutoCloseConnection = true,
                InitKeyType = InitKeyType.Attribute//从特性读取主键自增信息
            });

            //添加Sql打印事件，开发中可以删掉这个代码
            db.Aop.OnLogExecuting = (sql, pars) =>
            {
                Console.WriteLine(sql + "\r\n" + db.Utilities.SerializeObject(pars.ToDictionary(it => it.ParameterName, it => it.Value)));
                Console.WriteLine();
            };

            return db;
        }

        /// <summary>
        /// 监测数据库连接字符串正确性
        /// </summary>
        /// <param name="connStr"></param>
        /// <param name="errMsg"></param>
        /// <returns></returns>
        public static bool CheckConnectionStringValid(string connStr, out string errMsg)
        {
            errMsg = "";
            try
            {
                using (var db = GetSqlClient(connStr))
                {
                    db.Open();
                }
                return true;
            }
            catch(Exception e)
            {
                errMsg = e.ToString();
                return false;
            }
        }
    
        public static List<Models.DatabaseModel> GetDatabaseList(string connStr)
        {
            var db = GetSqlClient(connStr);

            var ignores = new string[] { "information_schema", "mysql", "performance_schema", "sys" };
            var databaseList = db.Context.DbMaintenance.GetDataBaseList(db);

            databaseList = databaseList.Where(a => !ignores.Contains(a)).OrderBy(a => a).ToList();

            var dbList = databaseList.Select(a => new Models.DatabaseModel
            {
                DatabaseName = a
            }).ToList();
            
            return dbList;
        }

        public static List<DbTableDto> GetTables(string schema, SqlSugarClient db)
        {
            if (schema.IsDangeString())
            {
                throw new Exception($"危险字符【{schema}】");
            }

            db.BeginTran(); // 为了让后面的 use起作用
            db.Ado.ExecuteCommand("use " + schema);

            db.DbFirst.Init();

            var dbTables = db.Context.DbMaintenance.GetTableInfoList(false);
            db.CommitTran();
            var list = dbTables.Select(a => new DbTableDto
            {
                Name = a.Name,
                Description = a.Description
            }).OrderBy(a => a.Name).ToList();
            return list;
        }

        public static List<DbTableDto> GetTables(string schema, string connStr)
        {
            var db = GetSqlClient(connStr);
            return GetTables(schema, db);
        }
    }
}
