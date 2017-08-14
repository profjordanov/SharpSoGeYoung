using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SociateGeYoung.App.Areas.Admin.Controllers
{
    [RoutePrefix("AdminHome")]
    public class AdminHomeController : Controller
    {
        // GET: Admin/AdminHome
        [Route]
        public ActionResult Index()
        {
            return View();
        }
    }
}