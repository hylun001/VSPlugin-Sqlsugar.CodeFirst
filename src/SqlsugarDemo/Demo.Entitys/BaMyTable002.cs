/**
*** 该模型类由代码生成工具生成 2020-11-28 16:48:44
**/ 
using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Demo.Entitys
{
    /// <summary>
    /// 
    /// </summary>
    [SugarTable("SqlSugarDemo.ba_my_table_002")]
    public partial class BaMyTable002
    {
        /// <summary>
        /// Id
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public System.Int32 Id { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public System.String Name { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        public System.Int32? Age { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? CreateTime { get; set; }

    }
}
