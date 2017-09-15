using System.Collections.Generic;
using System.Linq;

namespace SociateGeYoung.Services
{
    public class EmailAttributeService : Service
    {
        public IEnumerable<string> GetAllUserMails()
        {
            IEnumerable<string> mails = this.Context.Users.Select(x => x.Email);
            return mails;
        }
    }
}