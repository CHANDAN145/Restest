using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace RESTest
{
    public class Service
    {
        static HttpClient client = new HttpClient();

        public async Task<string> GetAsyc(string path)
        {
            HttpResponseMessage response = await client.GetAsync(path);
            List<User> users = new List<User>();
            string data = string.Empty;
            if (response.IsSuccessStatusCode)
            {
                data = await response.Content.ReadAsStringAsync();
            }

            return data;
        }
    }
}
