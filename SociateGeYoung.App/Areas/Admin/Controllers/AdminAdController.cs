using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using SociateGeYoung.Models.BindingModels;
using SociateGeYoung.Models.ViewModels;
using SociateGeYoung.Services;
using SociateGeYoung.Services.Interfaces;
using SociateGeYoung.Services.ServiceConnectedAttributes;

namespace SociateGeYoung.App.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminAdController : Controller
    {
        private IAdsService service;

        public AdminAdController(IAdsService service)
        {
            this.service = service;
        }
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateInput(false)]
        //[EmailAll]
        public ActionResult Add([Bind(Include = "Position,ImageUrl,StudentProfile,Location,ValidUntil,Description")]AddJobAdBm bind)
        {
            if (ModelState.IsValid)
            {
                this.service.CreateJobAd(bind);
                return Redirect("/Ads");
            }
            AddJobAdVm vm = Mapper.Map<AddJobAdBm, AddJobAdVm>(bind);
            return View(vm);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            EditAdVm vm = this.service.GetEditVm(id);
            return this.View(vm);
        }

        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id,Position,ImageUrl,Location,ValidUntil,StudentProfile,Description")]EditAdBm bind)
        {
            if (this.ModelState.IsValid)
            {
                this.service.EditJobAdd(bind);
                return Redirect("/Ads/details/"+bind.Id);
            }
            EditAdVm vm = this.service.GetEditVm(bind.Id);
            return this.View(vm);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            DeleteJobAdVm vm = this.service.GetDeleteVm(id);
            return this.View(vm);
        }
        [HttpPost]
        public ActionResult Delete([Bind(Include = "Id")]DeleteJobAdBm bind)
        {
            if (this.ModelState.IsValid)
            {
                this.service.DeleteJobAd(bind);
                return Redirect("/Ads");
            }
            DeleteJobAdVm vm = this.service.GetDeleteVm(bind.Id);
            return this.View(vm);
        }
    }
}