using GalleryApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace GalleryApp.Services
{
    public interface IArticleServices
    {
        Task<Data> GetData();
    }
}
