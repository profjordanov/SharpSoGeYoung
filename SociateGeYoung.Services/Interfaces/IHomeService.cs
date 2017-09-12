using System.Collections.Generic;
using SociateGeYoung.Models.ViewModels;

namespace SociateGeYoung.Services.Interfaces
{
    public interface IHomeService
    {
        IEnumerable<HomeNewsVm> GetAllNews();
    }
}