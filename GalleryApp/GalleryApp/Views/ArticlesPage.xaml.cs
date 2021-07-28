using GalleryApp.Models;
using GalleryApp.Services;
using GalleryApp.ViewModel;
using Newtonsoft.Json;
using Plugin.Connectivity;
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

        }

        protected override  void OnAppearing()
        {
            base.OnAppearing();

            DrawListView();
        }

        private void DrawListView()
        {
            if (articlesViewModel.Data?.articles == null)
            {
                var article = new List<Article>();
                
                article.Add(new Article()
                {
                    author = "Author one",
                    title = "Title one",
                    description="This is first description of first title",
                    urlToImage = "https://img-cdn.tnwcdn.com/image/plugged?filter_last=1&fit=1280%2C640&url=https%3A%2F%2Fcdn0.tnwcdn.com%2Fwp-content%2Fblogs.dir%2F1%2Ffiles%2F2021%2F07%2FMaxPro-Fitness-Machine-Gym-1-of-3.jpg&signature=16dd88583338a4976e24e9b26bd91de4",

                });

                article.Add(new Article()
                {
                    author = "Author two",
                    title = "Title two",
                    description = "This is second description of second title",
                    urlToImage = "https://img-cdn.tnwcdn.com/image/plugged?filter_last=1&fit=1280%2C640&url=https%3A%2F%2Fcdn0.tnwcdn.com%2Fwp-content%2Fblogs.dir%2F1%2Ffiles%2F2021%2F07%2FMaxPro-Fitness-Machine-Gym-1-of-3.jpg&signature=16dd88583338a4976e24e9b26bd91de4",
                });

                article.Add(new Article()
                {
                    author = "Author three",
                    title = "Title three",
                    description = "This is third description of third title",
                    urlToImage = "https://img-cdn.tnwcdn.com/image/plugged?filter_last=1&fit=1280%2C640&url=https%3A%2F%2Fcdn0.tnwcdn.com%2Fwp-content%2Fblogs.dir%2F1%2Ffiles%2F2021%2F07%2FMaxPro-Fitness-Machine-Gym-1-of-3.jpg&signature=16dd88583338a4976e24e9b26bd91de4",
                });

                foreach (var item in article)
                {
                    if (!CrossConnectivity.Current.IsConnected)
                        item.urlToImage = "placeholder";
                }

                ListOfArticles.ItemsSource = article;
            }

            else
                ListOfArticles.ItemsSource = articlesViewModel.Data.articles;

            //if (ListOfArticles.ItemsSource == null || articlesViewModel.NoContent)
            //{
            //    NoData.IsVisible = true;
            //}
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