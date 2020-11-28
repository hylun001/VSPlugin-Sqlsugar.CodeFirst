using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class Unit
{
    public static bool IsNullOrWhiteSpace(this string str)
    {
        return string.IsNullOrWhiteSpace(str);
    }

    public static string ToJsonString(this object obj, bool useSetting = false)
    {
        var jseting = new Newtonsoft.Json.JsonSerializerSettings();

        if (useSetting)
        {
            jseting.Formatting = Newtonsoft.Json.Formatting.Indented;
        }

        var jsonStr = Newtonsoft.Json.JsonConvert.SerializeObject(obj, jseting);
        return jsonStr;
    }

    public static T ToJson<T>(this string jsonString)
    {
        var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(jsonString);
        return obj;
    }

    /// <summary>
    /// 判断是否包含危险字符
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static bool IsDangeString(this string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return false;
        }

        var dangerStrArr = new List<string> { ".", "'", "--", "#", ";", "\"" };

        var isDanger = dangerStrArr.Exists(a => input.Contains(a));
        return isDanger;
    }

    public static string ToLargeCamelCase(this string input)
    {
        if (input.IsNullOrWhiteSpace())
        {
            return input;
        }

        var arr = input.Split('_').ToList();
        arr = arr.Select(item =>
        {
            if (item.Length > 0)
            {
                item = item[0].ToString().ToUpper() + item.Substring(1);
            }
            return item;
        }).ToList();

        var str = string.Join("", arr);
        return str;
    }
}
