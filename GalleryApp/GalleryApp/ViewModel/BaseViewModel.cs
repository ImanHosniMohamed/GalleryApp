using Acr.UserDialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Essentials;

namespace GalleryApp.ViewModel
{
    
        public class BaseViewModel : INotifyPropertyChanged
        {
            public BaseViewModel()
            {
                Connectivity.ConnectivityChanged += Connectivity_ConnectivityChanged;
            }

            ~BaseViewModel()
            {
                Connectivity.ConnectivityChanged -= Connectivity_ConnectivityChanged;
            }
            void Connectivity_ConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
            {
                if (e.NetworkAccess != NetworkAccess.Internet)
                    UserDialogs.Instance.Toast("Please check your internet connection");
                else
                    UserDialogs.Instance.Toast("Your internet connection is back :)");
            }
            public event PropertyChangedEventHandler PropertyChanged;


    }
}
