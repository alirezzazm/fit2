using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace Test2project.DataService
{
  public  class DataServicePost
    {
        private string Url = "";
        public async Task<List<PostData>> GetPostData()
        {

            var httpClient = new HttpClient();

            var json = await httpClient.GetStringAsync(Url);

            var todoes = JsonConvert.DeserializeObject<List<PostData>>(json);

            return todoes;

        }

        public async Task PostPostData(PostData PostData)
        {
            var httpsClient = new HttpClient();

            var json = JsonConvert.SerializeObject(PostData);

            StringContent content = new StringContent(json);

            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var result = await httpsClient.PostAsync(Url, content);
        }
        public async Task PutPostData(int id, PostData PostData)
        {
            var httpsClient = new HttpClient();

            var json = JsonConvert.SerializeObject(PostData);

            StringContent content = new StringContent(json);

            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var result = await httpsClient.PutAsync(Url + id, content);
        }
    }
}
