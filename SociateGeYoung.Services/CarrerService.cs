using System.Linq;
using System.Web;
using SociateGeYoung.Models.EntityModels;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SociateGeYoung.Data;

namespace SociateGeYoung.Services
{
    public class CarrerService : Service
    {
        public void CreateFile(CarrerCV carrerCv, string fileName, string userId)
        {
            ApplicationUser user = this.UserManager.FindByIdAsync(userId).Result;

            carrerCv.CVpath = fileName;
            carrerCv.ApplicationUser = user;
            this.Context.CarrerCvs.Add(carrerCv);
            this.Context.SaveChanges();
        }
    }
}