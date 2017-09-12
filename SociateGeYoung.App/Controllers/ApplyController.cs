using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SociateGeYoung.Models.Attributes;
using SociateGeYoung.Models.ViewModels;
using SociateGeYoung.Services;

namespace SociateGeYoung.App.Controllers
{
    [CustomAuthorize]
    [RoutePrefix("apply")]
    public class ApplyController : Controller
    {
        private ApplyService service;

        public ApplyController()
        {
            this.service = new ApplyService();
        }
        [HttpGet]
        [Route]
        [Route("{userId}/{jobAdId}")]

        public ActionResult Index(string userId, int jobAdId)
        {
            ApplyIndexVm vm = this.service.GetApplyTokens(userId, jobAdId);
            return View(vm);
        }
        [HttpPost]
        [Route]
        [Route("{userId}/{jobAdId}")]
        public ActionResult Index(int jobAdId, int cvId)
        {
            if (ModelState.IsValid)
            {
                var result = this.service.CreateNewApply(jobAdId, cvId);
                if (result)
                {
                    return Content("BRAVO!");
                }
                else
                {
                    return Content("Ne moje pak!");
                }

            }
            return this.View();
        }
    }
}