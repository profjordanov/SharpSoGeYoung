using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SociateGeYoung.Data;
using SociateGeYoung.Models.EntityModels;

namespace SociateGeYoung.Services
{
    public abstract class Service
    {
        protected SociateGeYoungContext Context;
        protected UserManager<ApplicationUser> UserManager;

        protected Service()
        {
            this.Context = new SociateGeYoungContext();
            this.UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(this.Context));
        }
    }
}