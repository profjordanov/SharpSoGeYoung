using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace SociateGeYoung.Models.EntityModels
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            this.CarrerCvs = new HashSet<CarrerCV>();      
        }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            return userIdentity;
        }

        public virtual ICollection<CarrerCV> CarrerCvs { get; set; }
    }
}