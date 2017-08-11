using System.Collections.Generic;
using SociateGeYoung.Models.EntityModels;

namespace SociateGeYoung.Services
{
    public class InfoService : Service
    {
        public IEnumerable<ApplicationUser> GetAllUserInfo()
        {
            IEnumerable<ApplicationUser> users = this.Context.Users;
            return users;
        }
    }
}