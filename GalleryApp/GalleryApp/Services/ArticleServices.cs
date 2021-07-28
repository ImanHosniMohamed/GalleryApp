using GalleryApp.Models;
using Newtonsoft.Json;
using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace GalleryApp.Services
{
    public class ArticleServices :IArticleServices 
    {
        private static string Api_URL = "https://newsapi.org/v1/articles?source=the-next-web&apiKey=1c0f731cca954a13875e6965f9c7e9de";
        private static string SecondApi_URL = "https://newsapi.org/v1/articles?source=associated-press&apiKey=1c0f731cca954a13875e6965f9c7e9de";

        public async Task<Data> GetData()
        {
           
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "application/json");
                client.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "Mozilla/5.0 (Windows NT 6.2; WOW64; rv:19.0) Gecko/20100101 Firefox/19.0");
                client.BaseAddress = new Uri(Api_URL);
                HttpResponseMessage response = client.GetAsync(Api_URL).Result;

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var posts = JsonConvert.DeserializeObject<Data>(content);
                    return posts;
                }

                else
                    return new Data();
            }
        }
        public async Task<Data> GetSecondData()
        {

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "application/json");
                client.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "Mozilla/5.0 (Windows NT 6.2; WOW64; rv:19.0) Gecko/20100101 Firefox/19.0");
                client.BaseAddress = new Uri(SecondApi_URL);
                HttpResponseMessage response = client.GetAsync(SecondApi_URL).Result;

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var posts = JsonConvert.DeserializeObject<Data>(content);
                    return posts;
                }

                else
                    return new Data();
            }
        }
    }
}
