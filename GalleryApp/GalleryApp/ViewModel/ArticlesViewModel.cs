using GalleryApp.Models;
using GalleryApp.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GalleryApp.ViewModel
{
    public class ArticlesViewModel:INotifyPropertyChanged
    {
        private ObservableCollection<Article> articles;
        IArticleServices articleServices = new ArticleServices();

        private ObservableCollection<Data> _data;
        public ObservableCollection<Data> Data
        {
            get { return _data; }
            set
            {
                _data = value;
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Data"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void onpropertyChanged()
        {
            throw new NotImplementedException();
        }

        public ArticlesViewModel()
        {

            GetArticles();
        }
        public async Task GetArticles()
        {
             Data = await articleServices.GetData();
        }
       
    }
       
    
}
