using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SociateGeYoung.Models.ViewModels;
using SociateGeYoung.Services;

namespace SociateGeYoung.App.Controllers
{
    [RoutePrefix("Ads")]

    public class AdsController : Controller
    {
        private AdsService service;

        public AdsController()
        {
            this.service = new AdsService();
        }

        [HttpGet]
        [Route("{profile?}")]
        public ActionResult All(string profile)
        {
            IEnumerable<JobAdVm> vms = this.service.GetAllAds(profile);
            return View(vms);
        }
        [Authorize]
        [HttpGet]
        [Route("details/{id}")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DatailsJobAdVm job = this.service.GetDetailsVm(id);
            return View(job);
        }
    }
}