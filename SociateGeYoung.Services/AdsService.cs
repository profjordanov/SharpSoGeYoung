﻿using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using SociateGeYoung.Models.BindingModels;
using SociateGeYoung.Models.EntityModels;
using SociateGeYoung.Models.ViewModels;

namespace SociateGeYoung.Services
{
    public class AdsService : Service
    {
        //  public IEnumerable<JobAdVm> GetAllAds()
        //  {
        //      IEnumerable<JobAd> jobAds = this.Context.JobAds;
        //      IEnumerable<JobAdVm> vms = Mapper.Map<IEnumerable<JobAd>, IEnumerable<JobAdVm>>(jobAds);
        //      return vms;
        //  }


        public IEnumerable<JobAdVm> GetAllAds(string profile)
        {
            IEnumerable<JobAd> jobAds;
            if (profile == null)
            {
                jobAds = this.Context.JobAds.OrderByDescending(j => j.Id);
            }
            else
            {
                //int profileNumber = int.Parse(profile);
                jobAds = this.Context.JobAds.Where(j => j.StudentProfile.ToString().Equals(profile)).OrderByDescending(j => j.Id);
            }
            IEnumerable<JobAdVm> vms = Mapper.Instance.Map<IEnumerable<JobAd>, IEnumerable<JobAdVm>>(jobAds);
            return vms;
        }

        public DatailsJobAdVm GetDetailsVm(int? id)
        {
            JobAd jobAd = this.Context.JobAds.FirstOrDefault(x => x.Id == id);
            if (jobAd == null)
            {
                return null;
            }
            DatailsJobAdVm vm = Mapper.Map<JobAd, DatailsJobAdVm>(jobAd);
            return vm;
        }

        public void CreateJobAd(AddJobAdBm bind)
        {
            JobAd jobAd = Mapper.Map<AddJobAdBm, JobAd>(bind);
            this.Context.JobAds.Add(jobAd);
            this.Context.SaveChanges();
        }


    }
}