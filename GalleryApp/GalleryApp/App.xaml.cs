using GalleryApp.Services;
using GalleryApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GalleryApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            DependencyService.Register<IArticleServices,ArticleServices>();
            MainPage = new  MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
