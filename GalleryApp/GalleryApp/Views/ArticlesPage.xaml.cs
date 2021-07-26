using GalleryApp.Models;
using GalleryApp.Services;
using GalleryApp.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GalleryApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ArticlesPage : ContentPage
    {
        ArticlesViewModel articlesViewModel = new ArticlesViewModel();

        public ArticlesPage()
        {
            InitializeComponent();
            ListOfArticles.ItemsSource = articlesViewModel.Data;

        }

       
    }
}