using System.Linq;
using Microsoft.AspNet.Identity;
using SociateGeYoung.Models.EntityModels;
using SociateGeYoung.Models.ViewModels;

namespace SociateGeYoung.Services
{
    public class ApplyService : Service
    {
        public ApplyIndexVm GetApplyTokens(string userId, int jobAdId)
        {
            ApplyIndexVm vm = new ApplyIndexVm()
            {
                ApplicationUser = this.UserManager.FindById(userId),
                JobAd = this.Context.JobAds.FirstOrDefault(x => x.Id == jobAdId)
            };
            return vm;
        }

        public bool CreateNewApply(int jobAdId, int cvId)
        {
            JobAd jobAd = this.Context.JobAds.FirstOrDefault(x => x.Id == jobAdId);
            CarrerCV carrerCv = this.Context.CarrerCvs.FirstOrDefault(c => c.Id == cvId);
            if (!this.Context.Applies.Any(x => x.JobAd.Id == jobAd.Id && x.CarrerCv.Id == carrerCv.Id))
            {
                Apply apply = new Apply()
                {
                    CarrerCv = carrerCv,
                    JobAd = jobAd
                };
                this.Context.Applies.Add(apply);
                this.Context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}