using GalleryApp.Models;
using GalleryApp.Views;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace GalleryApp.Views
{
    public partial class MainPage : MasterDetailPage
    {
       

        public MainPage()
        {
            InitializeComponent();
            var current = Connectivity.NetworkAccess;
            if (current == NetworkAccess.Internet)
            {
                Detail = new NavigationPage(new ArticlesPage());

            }
            DetailsPage.Navigation.PushAsync(new ArticlesPage()); 
        }

        protected   override void OnAppearing()
        {
            base.OnAppearing();
        }

        private void OpenLiveChatPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new LiveChatPage());
            IsPresented = false;
        }

        private void OpenGalleryPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new GalleryPage());
            IsPresented = false;

        }

        private void OpenWishListPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new WishListPage());
            IsPresented = false;
        }

        private void OpenOnlineNewsPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new OnlineNewsPage());
            IsPresented = false;

        }

        private void OpenArticlesPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new ArticlesPage());
            IsPresented = false;
        }
    }
}
