using System.Threading.Tasks;
using SociateGeYoung.Models.ViewModels;

namespace SociateGeYoung.Services.Interfaces
{
    public interface IApplyService
    {
        ApplyIndexVm GetApplyTokens(string userId, int jobAdId);
        bool CreateNewApply(int jobAdId, int cvId);

    }
}