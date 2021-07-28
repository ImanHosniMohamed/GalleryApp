using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GalleryApp.Models
{
    public class Article
    {
        public string author { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string url { get; set; }
        public string urlToImage { get; set; }
        public DateTime publishedAt { get; set; }

        public string AuthorBy
        {
            get
            {
                return $"{"By" +" "+ author}";
            }
        }

        public string Date
        {
            get
            {
                return $"{publishedAt.ToString("MMMM dd, yyyy")}";
            }
        }

       
    }
}
