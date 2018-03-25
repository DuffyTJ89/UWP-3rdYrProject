using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rdYrProject.Common
{
    class Common
    {
        public static string API_LINK = "api.openweathermap.org/data/2.5/weather";
        public static string API_KEY = "0aab86a4a278c20065049e12a392756c";

        public static string APIRequest(string lat, string lon)
        {
            StringBuilder strBuilder = new StringBuilder(API_LINK);
            //units = metric to convert temp tp celsius
            strBuilder.AppendFormat("?lat={0}&lon={1}&APPID={2}&units=metric", lat, lon, API_KEY);
            return strBuilder.ToString();
        }

        
    }
}
