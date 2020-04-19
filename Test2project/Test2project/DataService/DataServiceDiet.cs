using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Test2project.Models;

namespace Test2project.DataService
{
    public class DataServiceDiet
    {
        private string Url = "http://localhost/api/DietApis";
        public async Task<List<DietModels>> GetDietModels()
        {

            var httpClient = new HttpClient();

            var json = await httpClient.GetStringAsync(Url);

            var todoes = JsonConvert.DeserializeObject<List<DietModels>>(json);

            return todoes;

        }

        public async Task PostDietModels(DietModels DietModels)
        {
            var httpsClient = new HttpClient();

            var json = JsonConvert.SerializeObject(DietModels);

            StringContent content = new StringContent(json);

            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var result = await httpsClient.PostAsync(Url, content);
        }
        public async Task PutDietModels(int id, DietModels DietModels)
        {
            var httpsClient = new HttpClient();

            var json = JsonConvert.SerializeObject(DietModels);

            StringContent content = new StringContent(json);

            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var result = await httpsClient.PutAsync(Url + id, content);
        }
    }
}
