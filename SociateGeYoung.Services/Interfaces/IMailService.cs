using System.Collections.Generic;
using SociateGeYoung.Models.BindingModels;

namespace SociateGeYoung.Services.Interfaces
{
    public interface IMailService
    {
        IEnumerable<string> GetAllUserMails();
        bool SendEmailToStudent(UserInfoBm bind);
    }
}