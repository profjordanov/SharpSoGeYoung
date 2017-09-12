using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SociateGeYoung.App.Areas.Admin.Controllers
{
    //[RoutePrefix("AdminHome")]
    [Authorize(Roles = "Admin")]
    public class AdminHomeController : Controller
    {
        //[Route]
        public ActionResult Index()
        {
            return View();
        }
    }
}