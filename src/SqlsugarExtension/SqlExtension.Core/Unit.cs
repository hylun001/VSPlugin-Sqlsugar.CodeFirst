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
}
