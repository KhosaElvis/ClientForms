using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;

namespace ClientForms.RestClient
{
    public class Client<T> : IClient<T>
    {
        private string baseUri;
        private string subUrl;
        public Client( string baseUri, string subUrl)
        {
            this.baseUri = baseUri;
            this.subUrl = subUrl;
        }
        public async Task<List<T>> GetTaskAsync()
        {
            List<T> listData = new List<T>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUri);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage massage = await client.GetAsync(subUrl);

                if (massage.IsSuccessStatusCode)
                {
                    var authResponse = massage.Content.ReadAsStringAsync().Result;

                    listData = JsonConvert.DeserializeObject<List<T>>(authResponse);
                }

            }
            return listData;
        }

        public async Task<T> GetTaskAsync(int Id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUri);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage massage = await client.GetAsync(string.Format("api/User?Id={0}", Id));

                if (massage.IsSuccessStatusCode)
                {
                    var authResponse = massage.Content.ReadAsStringAsync().Result;

                    var data = JsonConvert.DeserializeObject<T>(authResponse);
                    return data;
                }
                else // Assumption code never reached
                {
                    var authResponse = massage.Content.ReadAsStringAsync().Result;

                    var data = JsonConvert.DeserializeObject<T>(authResponse);
                    return data;
                }
            }
            
        }

        public async Task<string> PostAsync(T t)
        {
            var httpClient = new HttpClient();

            var json = JsonConvert.SerializeObject(t);

            HttpContent httpContent = new StringContent(json);

            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var result = await httpClient.PostAsync(baseUri+subUrl, httpContent);
            
            return result.Content.ToString();
        }

        public async Task<string> PutAsync(int id, T t)
        {
            var httpClient = new HttpClient();

            var json = JsonConvert.SerializeObject(t);

            HttpContent httpContent = new StringContent(json);

            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var result = await httpClient.PutAsync(string.Format("{0}{1}?Id={2}", baseUri, subUrl, id), httpContent);

            return result.Content.ToString();
        }

        public async Task<string> DeleteAsync(int id, T t)
        {
            var httpClient = new HttpClient();

            var response = await httpClient.DeleteAsync(string.Format("{0}{1}?Id={2}", baseUri, subUrl, id));

            return response.Content.ToString();
        }

        public async Task<string> PostAsync(T t, int id)
        {
            var httpClient = new HttpClient();

            var json = JsonConvert.SerializeObject(t);

            HttpContent httpContent = new StringContent(json);

            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var result = await httpClient.PostAsync(string.Format("{0}{1}?Id={2}",baseUri,subUrl,id), httpContent);

            return result.Content.ToString();
        }
    }
}