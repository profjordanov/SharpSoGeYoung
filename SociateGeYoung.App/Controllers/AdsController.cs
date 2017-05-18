using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SociateGeYoung.App.Controllers
{
    [RoutePrefix("Ads")]

    public class AdsController : Controller
    {
        [HttpGet]
        [Route]
        public ActionResult All()
        {
            return View();
        }
    }
}