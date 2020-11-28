using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
