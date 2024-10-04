using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationFront.Module
{
    public class json<T>
    {
        public static String encode(T obj)
        {
            return JsonConvert.SerializeObject(obj, Formatting.None, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
        }

        public static T decode(String obj)
        {
            return JsonConvert.DeserializeObject<T>(obj);
        }
    }
}