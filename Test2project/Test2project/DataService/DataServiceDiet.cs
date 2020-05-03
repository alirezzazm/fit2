using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Tracing;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Android.Database;
using CarouselView.FormsPlugin.Abstractions;
using Newtonsoft.Json;
using Test2project.Models;

namespace Test2project.DataService
{
    public class DataServiceDiet
    {
        public string Url = "http://localhost/api/DietApis";


        public async Task<List<DietModels>> GetDietModels()
        {
            todoes = new List<DietModels>();
            var httpClient = new HttpClient();

            var uri = new Uri("http://localhost/api/DietApis");
            try
            {
                var response = await httpClient.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    todoes = JsonConvert.DeserializeObject<List<DietModels>>(json);
                }
            }
            catch (Exception ex)
            {
                return null;
            }

            return todoes;
        }
        public async Task<List<DietModels>> GetDietModels()
        {
            


            var httpClient = new HttpClient();

            var json = await httpClient.GetStringAsync("http://localhost/api/DietApis");

             var todoes = JsonConvert.DeserializeObject<List<DietModels>>(json);

            ObservableCollection<DietModels> dietModels = new ObservableCollection<DietModels>();

            //  EventListView.ItemsSource = dietModels;
            


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
