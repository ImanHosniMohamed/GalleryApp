using System;
using System.Collections.Generic;
using System.Text;

namespace GalleryApp.Models
{
    public class Data
    {
        public string status { get; set; }
        public string source { get; set; }
        public string sortBy { get; set; }
        public List<Article> articles { get; set; }
    }
}
