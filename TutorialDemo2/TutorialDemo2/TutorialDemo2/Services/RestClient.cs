using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TutorialDemo2.Model;

namespace TutorialDemo2.Services
{
    public class RestClient
    {
        HttpClient client = new HttpClient();
        string authHeaderValue = "eyJhbGciOiJIUzUxMiJ9.eyJzdWIiOiJzbzNAZWxsb3JhIiwiYXV0aCI6IlJPTEVfRVhFQ1VUSVZFIiwiY29tcGFueUlkIjozMDQ2NDAsImV4cCI6MTUwNDA4NjAzN30.W3G6oBCRjXcMkdxa8mIR_oJaEw8KCUnCl0Ysp_4Ony-kxl8h7iCj5oR2QibTg1dumpBiWLDyuVXygoJxFgtSbg";
        public async Task<T> Get<T>(string url)
        {
            try
            {
               
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authHeaderValue);
                var response = await client.GetAsync(url);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var jsonstring = await response.Content.ReadAsStringAsync();
                    return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(jsonstring);
                }
            }
            catch
            {

            }
            return default(T);
        }

        internal async Task<T> PostItems<T>(Login login, bool v)
        {
            var jsonstring = "";

            var uri = new Uri(string.Format("http://192.168.0.73/api/authenticate", string.Empty));


            var json = JsonConvert.SerializeObject(login);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = null;
            if (v)
            {
                try { 
                response = await client.PostAsync(uri, content);
                }
                catch(Exception e)
                {
                    Debug.WriteLine(@"");
                }
            }



            if (response.IsSuccessStatusCode)
            {
                jsonstring = await response.Content.ReadAsStringAsync();
                return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(jsonstring);

            
            }
            else
            {
                return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(jsonstring);
            }
            
        }

      
    }
}

