using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SociateGeYoung.Data;
using SociateGeYoung.Models.EntityModels;

namespace SociateGeYoung.Services
{
    public class Service
    {
        protected SociateGeYoungContext Context;
        protected UserManager<ApplicationUser> UserManager;

        public Service()
        {
            this.Context = new SociateGeYoungContext();
            this.UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(this.Context));
        }
    }
}