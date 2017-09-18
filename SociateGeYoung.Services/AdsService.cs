using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using AutoMapper;
using SociateGeYoung.Models.BindingModels;
using SociateGeYoung.Models.EntityModels;
using SociateGeYoung.Models.ViewModels;
using SociateGeYoung.Services.Interfaces;

namespace SociateGeYoung.Services
{
    public class AdsService : Service,IAdsService
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
                jobAds = this.Context.JobAds
                    .Where(j => DateTime.Compare(j.ValidUntil,DateTime.Now).Equals(1) && !j.IsDeleted)
                    .OrderByDescending(j => j.Id);
            }
            else
            {
                //int profileNumber = int.Parse(profile);
                jobAds = this.Context.JobAds
                    .Where(j => j.StudentProfile.ToString().Equals(profile) && DateTime.Compare(j.ValidUntil, DateTime.Now).Equals(1) && !j.IsDeleted)
                    .OrderByDescending(j => j.Id);
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
            jobAd.CreateOn = DateTime.Now;
            this.Context.JobAds.Add(jobAd);
            this.Context.SaveChanges();
        }


        public EditAdVm GetEditVm(int id)
        {
            JobAd jobAd = this.Context.JobAds.Find(id);
            EditAdVm vm = Mapper.Map<JobAd, EditAdVm>(jobAd);
            return vm;
        }

        public void EditJobAdd(EditAdBm bind)
        {
            JobAd jobAd = this.Context.JobAds.Find(bind.Id);
            jobAd = Mapper.Map<EditAdBm, JobAd>(bind);
            jobAd.CreateOn = DateTime.Now;
            jobAd.IsDeleted = false;
            this.Context.JobAds.AddOrUpdate(jobAd);
            this.Context.SaveChanges();
        }

        public DeleteJobAdVm GetDeleteVm(int id)
        {
            JobAd jobAd = this.Context.JobAds.Find(id);
            DeleteJobAdVm vm = Mapper.Map<JobAd, DeleteJobAdVm>(jobAd);
            return vm;
        }

        public void DeleteJobAd(DeleteJobAdBm bind)
        {
            JobAd jobAd = this.Context.JobAds.Find(bind.Id);
            jobAd.IsDeleted = true;
            this.Context.JobAds.AddOrUpdate(jobAd);
            this.Context.SaveChanges();
        }
    }
}