using PagedList;
using SociateGeYoung.Models.EntityModels;

namespace SociateGeYoung.Models.ViewModels
{
    public class UserInfoVm
    {
        public IPagedList<ApplicationUser> ApplicationUsers { get; set; }
    }
}