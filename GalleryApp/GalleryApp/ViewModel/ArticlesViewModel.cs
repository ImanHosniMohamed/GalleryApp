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
    public class ArticlesViewModel:BaseViewModel
    {
        private ObservableCollection<Article> articles;
        IArticleServices articleServices = new ArticleServices();
        public bool NoContent = false;
        private Data _data;
        public Data Data
        {
            get { return _data; }
            set
            {
                _data = value;
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Data"));
            }
        }

        private Data _secondData;
        public Data SecondData
        {
            get { return _secondData; }
            set
            {
                _secondData = value;
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Data"));
            }
        }

        private List<Article> _allData;
        public List<Article> AllData
        {
            get { return _allData; }
            set
            {
                _allData = value;
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

            GetArticles2();

            if(Data?.articles == null || SecondData?.articles == null)
                NoContent = true;

            else
            Data.articles.AddRange(SecondData.articles);
        }
        public async Task GetArticles()
        {
             Data = await articleServices.GetData();
             
        }

        public async Task GetArticles2()
        {
            SecondData = await articleServices.GetSecondData();
        }

    }
       
    
}
