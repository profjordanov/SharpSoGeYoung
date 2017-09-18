using System;
using System.Collections.Generic;
using Microsoft.AspNet.Identity.EntityFramework;
using SociateGeYoung.Models.BindingModels;
using SociateGeYoung.Models.EntityModels;

namespace SociateGeYoung.Services.Interfaces
{
    public interface IInfoService
    {
        IEnumerable<ApplicationUser> GetAllUserInfo();
        Tuple<IEnumerable<ApplicationUser>, IEnumerable<IdentityRole>> ModifyUsers(string searchString);
        ApplicationUser TakeUserForDelete(string id);
        void DeleteUser(DeleteUserBm bind);
        IEnumerable<IdentityRole> GetUserRoles();
        void SaveStatusToApply(UserInfoBm bind);
        IEnumerable<Apply> GetAllInterviewApplies();
        IEnumerable<JobAd> GetAllJobAds();
    }
}