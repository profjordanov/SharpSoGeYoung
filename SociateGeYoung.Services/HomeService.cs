﻿using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using SociateGeYoung.Models.EntityModels;
using SociateGeYoung.Models.ViewModels;

namespace SociateGeYoung.Services
{
    public class HomeService : Service
    {
        public IEnumerable<HomeNewsVm> GetAllNews()
        {
            IEnumerable<New> news = this.Context.News.OrderByDescending(x => x.ReleaseDate);
            IEnumerable<HomeNewsVm> vms = Mapper.Instance.Map<IEnumerable<New>, IEnumerable<HomeNewsVm>>(news);
            return vms;
        }
    }
}