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
           ListOfArticles.ItemsSource = articlesViewModel.Data.articles;
            if (ListOfArticles.ItemsSource == null || articlesViewModel.NoContent)
            {
                NoData.IsVisible = true;
            }
        }

        private async void ListOfArticles_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedItem=  e.SelectedItem as Article;
            await Navigation.PushAsync(new ArticleDetailsPage(selectedItem));

        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var x = new Article();
            await Navigation.PushAsync(new ArticleDetailsPage(x));
        }
    }
}