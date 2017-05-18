using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SociateGeYoung.App.Controllers
{
    [RoutePrefix("Robo")]

    public class RoboController : Controller
    {
        [HttpGet]
        [Route]
        public ActionResult Index()
        {
            return View();
        }
    }
}