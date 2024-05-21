using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Shared
{
    public static class JsonHelper
    {
        public static string ToJson<T>(T obj)
        {
            string json = JsonConvert.SerializeObject(obj);
            //return Newtonsoft.Json.JsonConvert.SerializeObject(obj);
            return json;
        }

        public static object FromJson(string obj)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject(obj);
        }

        public static DataTable ToTable(string obj)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<DataTable>(obj);
        }
    }
}
