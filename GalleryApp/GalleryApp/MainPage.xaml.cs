using GalleryApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GalleryApp
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            Detail = new NavigationPage(new ArticlesPage());
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
