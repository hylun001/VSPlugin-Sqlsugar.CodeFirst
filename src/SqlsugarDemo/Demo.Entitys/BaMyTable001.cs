/**
*** 该模型类由代码生成工具生成 2020-11-28 17:43:31
**/ 
using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Demo.Entitys
{
    /// <summary>
    /// 测试
    /// </summary>
    [SugarTable("SqlSugarDemo.ba_my_table_001")]
    public partial class BaMyTable001
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

        /// <summary>
        /// 12asd
        /// </summary>
        public System.Boolean f1 { get; set; }

        /// <summary>
        /// afsd
        /// </summary>
        public System.SByte? f2 { get; set; }

    }
}
