using System.Collections.Generic;
using SociateGeYoung.Models.BindingModels;
using SociateGeYoung.Models.ViewModels;

namespace SociateGeYoung.Services.Interfaces
{
    public interface IAdsService
    {
        IEnumerable<JobAdVm> GetAllAds(string profile);
        DatailsJobAdVm GetDetailsVm(int? id);
        void CreateJobAd(AddJobAdBm bind);
    }
}