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
        }

        private void OpenUrl_Clicked(object sender, EventArgs e)
        {
            Uri uri = new Uri(SelectedArticle.urlToImage);
            openBrowser(uri);
        }

        public async void openBrowser(Uri uri)
        {
            await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
    }
}