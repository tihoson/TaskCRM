using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace TaskCRM
{
    class NetConnector
    {
        public static string GetCountryResponse(string country)
        {
            try
            {
                var request = WebRequest.Create("https://restcountries.eu/rest/v2/name/" + country);
                using (var stream = request.GetResponse().GetResponseStream())
                {
                    using (var reader = new StreamReader(stream))
                    {
                        return reader.ReadToEnd();
                    }
                }
            }
            catch
            {
                return null;
            }
        }
    }
}
