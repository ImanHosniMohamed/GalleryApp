using GalleryApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GalleryApp.Services
{
   public class ArticleServices :IArticleServices
    {
        public const string BASE_URL = "https://newsapi.org/v1/articles?source=the-next-web&apiKey=1c0f731cca954a13875e6965f9c7e9de";
       

        public async Task<ObservableCollection<Data>> GetData()
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync(BASE_URL);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var posts = JsonConvert.DeserializeObject<ObservableCollection<Data>>(content);
                return posts;

            }
            else
                return new ObservableCollection<Data>();
        }
    }
}
