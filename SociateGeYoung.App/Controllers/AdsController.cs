using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SociateGeYoung.Models.ViewModels;
using SociateGeYoung.Services;
using SociateGeYoung.Services.Interfaces;

namespace SociateGeYoung.App.Controllers
{
    [RoutePrefix("Ads")]
    [AllowAnonymous]

    public class AdsController : Controller
    {
        private IAdsService service;

        public AdsController(IAdsService service)
        {
            this.service = service;
        }

        [HttpGet]
        [Route("{profile?}")]
        public ActionResult All(string profile)
        {
            IEnumerable<JobAdVm> vms = this.service.GetAllAds(profile);
            return View(vms);
        }
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