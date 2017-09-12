using System.Collections.Generic;
using SociateGeYoung.Models.BindingModels;
using SociateGeYoung.Models.EntityModels;
using SociateGeYoung.Models.ViewModels;

namespace SociateGeYoung.Services.Interfaces
{
    public interface ICarrerService
    {
        void CreateFile(CarrerCV carrerCv, string fileName, string userId);
        IEnumerable<AllCarrerCVs> GetAllCvsVm(string userId);
        DeleteCvVm GetDeleteCvVm(int id);
        void DeleteCv(DeleteCvBm bind);
    }
}