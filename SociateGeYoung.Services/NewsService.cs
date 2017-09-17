using System;
using AutoMapper;
using SociateGeYoung.Models.BindingModels;
using SociateGeYoung.Models.EntityModels;
using SociateGeYoung.Services.Interfaces;

namespace SociateGeYoung.Services
{
    public class NewsService : Service, INewsService
    {
        public void AddToNews(AddNewBm bind)
        {
            New news = Mapper.Instance.Map<AddNewBm, New>(bind);
            news.ReleaseDate = DateTime.Now;
            this.Context.News.Add(news);
            this.Context.SaveChanges();
        }
    }
}