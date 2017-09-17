using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using SociateGeYoung.Models.EntityModels;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SociateGeYoung.Data;
using SociateGeYoung.Models.BindingModels;
using SociateGeYoung.Models.ViewModels;
using SociateGeYoung.Services.Interfaces;

namespace SociateGeYoung.Services
{
    public class CarrerService : Service,ICarrerService
    {
        public void CreateFile(string fileName, string userId)
        {
            ApplicationUser user = this.UserManager.FindById(userId);
            CarrerCV carrerCv = new CarrerCV();
            carrerCv.CVpath = fileName;
            carrerCv.ApplicationUser = user;
            this.Context.CarrerCvs.Add(carrerCv);
            this.Context.SaveChanges();
        }

        public IEnumerable<AllCarrerCVs> GetAllCvsVm(string userId)
        {
            IEnumerable<CarrerCV> carrerCvs = this.Context.CarrerCvs.Where(c => c.ApplicationUser.Id == userId);
            IEnumerable<AllCarrerCVs> vms = Mapper.Map<IEnumerable<CarrerCV>, IEnumerable<AllCarrerCVs>>(carrerCvs);
            return vms;
        }

        public DeleteCvVm GetDeleteCvVm(int id)
        {
            CarrerCV cv = this.Context.CarrerCvs.Find(id);
            DeleteCvVm vm = Mapper.Map<CarrerCV, DeleteCvVm>(cv);
            return vm;
        }

        public void DeleteCv(DeleteCvBm bind)
        {
            CarrerCV cv = this.Context.CarrerCvs.Find(bind.CvId);
            this.Context.CarrerCvs.Remove(cv);
            this.Context.SaveChanges();
            //TODO: Delete CV from server!
        }
    }
}