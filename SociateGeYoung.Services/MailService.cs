using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using SociateGeYoung.Models.BindingModels;
using SociateGeYoung.Services.Interfaces;

namespace SociateGeYoung.Services
{
    public class MailService : Service, IMailService
    {
        public IEnumerable<string> GetAllUserMails()
        {
            IEnumerable<string> mails = this.Context.Users.Select(x => x.Email);
            return mails;
        }
        public bool SendEmailToStudent(UserInfoBm bind)
        {
            try
            {
                using (MailMessage mm = new MailMessage("ugdaka@students.softuni.bg", bind.UserEmail))
                {
                    mm.Subject = $"Отговор за {bind.JobPosition}";
                    mm.Body = $"Вашата кандидатура за {bind.JobPosition} e маркирана като {bind.ApplyStatus}";
                    mm.IsBodyHtml = false;
                    using (SmtpClient smtp = new SmtpClient())
                    {
                        smtp.Host = "smtp-mail.outlook.com";
                        smtp.EnableSsl = true;
                        NetworkCredential NetworkCred = new NetworkCredential("ugdaka@students.softuni.bg", "Fc4b51b3$");
                        smtp.UseDefaultCredentials = true;
                        smtp.Credentials = NetworkCred;
                        smtp.Port = 587;
                        smtp.Send(mm);
                    }
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}