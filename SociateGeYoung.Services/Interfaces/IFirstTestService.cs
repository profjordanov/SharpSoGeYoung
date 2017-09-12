using SociateGeYoung.Models.BindingModels;

namespace SociateGeYoung.Services.Interfaces
{
    public interface IFirstTestService
    {
        bool IsThereUser { get; }
        string CodeForUser { get;  }
        void AddTest(FirstTestBM bind);
        string Calculator();
        void AddTestCodeForUser(AddTestCodeBm bind);
    }
}