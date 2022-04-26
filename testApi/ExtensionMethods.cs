using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testApi
{
    public static class ExtensionMethods
    {
        public static async Task<T> GetClientRespnose<T>(this HttpClient client, string uri)
        {
            HttpResponseMessage response = await client.GetAsync(uri);

            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();

            var entities = GetResponseEnitity<T>(responseBody);            
            return entities;
        }

/*        public static void WriteRepsonses<IEnumerable<<T>>(string responseBody)
        {
            var entities = GetResponseEnitity<IEnumerable<<T>>(responseBody);
            //Console.WriteLine(responseBody);
            foreach (var entity in entities)
            {
                Console.WriteLine(entity);
            }
        }*/

        public static T GetResponseEnitity<T>(string responseBody)
        {
            var entities = JsonConvert.DeserializeObject<T>(responseBody);
            return entities;
        }

        public static void WriteRepsonse<T>(string responseBody)
        {
            var entity = JsonConvert.DeserializeObject<T>(responseBody);
            Console.WriteLine(responseBody);
            Console.WriteLine(entity);
        }
    }
}
// TODO: get data from public api: https://dev-portal.rappi.com/api/?java#get-menu