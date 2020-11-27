using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SqlSugar;

namespace SqlsugarDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SqlController : ControllerBase
    {
        private string connstr = "";
        public SqlController(IConfiguration configuration)
        {
            connstr = configuration.GetValue<string>("SqlSugarConnectionConfig:ConnectionString");
        }

        private SqlSugarClient GetSqlClient()
        {
            //创建数据库对象
            SqlSugarClient db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = connstr,//连接符字串
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

        [HttpGet("/sql/GetSqlTest")]
        public string GetSqlTest()
        {
            var db = GetSqlClient();
            var dt = db.Ado.GetDataTable("select * from ba_my_table_001", new { });

            return Newtonsoft.Json.JsonConvert.SerializeObject(dt); 
        }
    }
}