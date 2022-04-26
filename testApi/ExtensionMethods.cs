using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testApi
{
    public static class ExtensionMethods
    {
        public static async Task<string> GetClientRespnose(this HttpClient client, string uri)
        {
            HttpResponseMessage response = await client.GetAsync(uri);

            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;
        }
    }
}
