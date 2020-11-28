using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlExtension.DbUnity
{
    internal class ModelTemplate
    {
        #region Template
        public static string ClassTemplate = @"/**
*** 该模型类由代码生成工具生成
**/ 
{using}

namespace {Namespace}
{
{ClassDescription}{SugarTable}
    public partial class {ClassName}
    {
{PropertyName}
    }
}
";

        public static string ClassDescriptionTemplate =
                                                ClassSpace + "/// <summary>\r\n" +
                                                ClassSpace + "/// {ClassDescription}\r\n" +
                                                ClassSpace + "/// </summary>\r\n";

        public static string PropertyTemplate = "{SugarColumn}" +
                                                PropertySpace + "public {PropertyType} {PropertyName} { get; set; }\r\n";

        public static string PropertyDescriptionTemplate =
                                                PropertySpace + "/// <summary>\r\n" +
                                                PropertySpace + "/// {PropertyDescription}\r\n" +
                                                PropertySpace + "/// </summary>\r\n";

        public static string ConstructorTemplate = PropertySpace + " this.{PropertyName} ={DefaultValue};\r\n";

        public static string UsingTemplate = @"using System;
using System.Linq;
using System.Text;
using SqlSugar;";

        #endregion

        #region Replace Key
        public const string KeyUsing = "{using}";
        public const string KeyNamespace = "{Namespace}";
        public const string KeyClassName = "{ClassName}";
        public const string KeyIsNullable = "{IsNullable}";
        public const string KeySugarTable = "{SugarTable}";
        public const string KeyConstructor = "{Constructor}";
        public const string KeySugarColumn = "{SugarColumn}";
        public const string KeyPropertyType = "{PropertyType}";
        public const string KeyPropertyName = "{PropertyName}";
        public const string KeyDefaultValue = "{DefaultValue}";
        public const string KeyClassDescription = "{ClassDescription}";
        public const string KeyPropertyDescription = "{PropertyDescription}";
        #endregion

        #region Replace Value
        public const string ValueSugarTable = ClassSpace + "[SugarTable(\"{0}\")]";
        public const string ValueSugarCoulmn = PropertySpace + "[SugarColumn({0})]\r\n";
        #endregion

        #region Space
        public const string ClassSpace = "    ";
        public const string PropertySpace = ClassSpace + ClassSpace;
        #endregion
    }
}
