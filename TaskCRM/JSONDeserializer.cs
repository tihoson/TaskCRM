using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskCRM
{
    class JSONDeserializer
    {
        public static Dictionary<string, dynamic> DeserializeResponse(string response)
        {
            try
            {
                var responseString = JsonConvert.DeserializeObject<List<dynamic>>(response)[0].ToString();
                return JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(responseString);
            }
            catch
            {
                return null;
            }
        }
    }
}
