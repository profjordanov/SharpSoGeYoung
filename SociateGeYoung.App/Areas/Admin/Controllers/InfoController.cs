using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SociateGeYoung.Models.EntityModels;
using SociateGeYoung.Services;

namespace SociateGeYoung.App.Areas.Admin.Controllers
{
    public class InfoController : Controller
    {
        private InfoService service;

        public InfoController()
        {
            this.service = new InfoService();
        }
        [HttpGet]
        public ActionResult UserInfo()
        {
            IEnumerable<ApplicationUser> applicationUsers = this.service.GetAllUserInfo();
            return View(applicationUsers);
        }
    }
}