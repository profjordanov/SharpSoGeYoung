using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using SociateGeYoung.Models.BindingModels;
using SociateGeYoung.Models.ViewModels;
using SociateGeYoung.Services;

namespace SociateGeYoung.App.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminAdController : Controller
    {
        private AdsService service;

        public AdminAdController()
        {
            this.service = new AdsService();
        }
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Add([Bind(Include = "Position,ImageUrl,StudentProfile,Description")]AddJobAdBm bind)
        {
            if (ModelState.IsValid)
            {
                this.service.CreateJobAd(bind);
                return Redirect("/Ads");
            }
            AddJobAdVm vm = Mapper.Map<AddJobAdBm, AddJobAdVm>(bind);
            return View(vm);
        }
    }
}