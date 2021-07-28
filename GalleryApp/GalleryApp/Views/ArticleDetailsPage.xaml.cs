using GalleryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GalleryApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ArticleDetailsPage : ContentPage
    {
        Article SelectedArticle;
        public ArticleDetailsPage(Article selectedArticle)
        {
            InitializeComponent();
            SelectedArticle = selectedArticle;
            image.Source = selectedArticle.urlToImage;
            date.Text = selectedArticle.Date;
            title.Text = selectedArticle.title;
            author.Text = selectedArticle.AuthorBy;
            description.Text = selectedArticle.description;
        }

        private void OpenUrl_Clicked(object sender, EventArgs e)
        {
            if (SelectedArticle.urlToImage != "placeholder")
            {
                Uri uri = new Uri(SelectedArticle.urlToImage);
                openBrowser(uri);
            }

            else
                DisplayAlert("Warning", "No image found", "ok");
            
        }

        public async void openBrowser(Uri uri)
        {
            await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
    }
}