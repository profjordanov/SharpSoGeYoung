using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SociateGeYoung.App.Controllers
{
    [RoutePrefix("Status")]

    public class StatusController : Controller
    {
        [HttpGet]
        [Route]
        public ActionResult Index()
        {
            return View();
        }
    }
}