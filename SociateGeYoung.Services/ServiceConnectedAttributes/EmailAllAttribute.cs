using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Web.Mvc;
using SociateGeYoung.Models.EntityModels;

namespace SociateGeYoung.Services.ServiceConnectedAttributes
{
    public class EmailAllAttribute : ActionFilterAttribute
    {
        private EmailAttributeService service;
        public EmailAllAttribute()
        {
            this.service = new EmailAttributeService();
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            IEnumerable<string> usersMails = this.service.GetAllUserMails();
            foreach (var mail in usersMails)
            {
                using (MailMessage mm = new MailMessage("ugdaka@students.softuni.bg", mail))
                {
                    mm.Subject = $"Нова обява в SoGeYoung. Приложението, което мисли за теб!";
                    mm.Body = $"Туко що качихме нова обява! Влез и виж дали е подходяща за теб. Поздрави!!!";
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
            }
        }
    }
}