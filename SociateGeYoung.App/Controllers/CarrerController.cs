using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using SociateGeYoung.Models.BindingModels;
using SociateGeYoung.Models.EntityModels;
using SociateGeYoung.Models.ViewModels;
using SociateGeYoung.Services;

namespace SociateGeYoung.App.Controllers
{
    [Authorize]
    [RoutePrefix("carrer")]
    public class CarrerController : Controller
    {
        private CarrerService service;

        public CarrerController()
        {
            this.service = new CarrerService();
        }
        [Route("{userId}")]
        public ActionResult SubmitCV(string userId)
        {
            return View();
        }

        [HttpPost]
        [Route("{userId}")]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitCV(string userId, CarrerCV c, HttpPostedFileBase file)
        {
            if (file == null)
            {
                ModelState.AddModelError("CustomError", "Моля, избери CV!");
                return this.View();
            }
            if (file.ContentLength > 2000000)
            {
                ModelState.AddModelError("CustomError", "Прекалено голям файл!");
                return this.View();
            }

            if (!(file.ContentType == "application/vnd.openxmlformats-officedocument.wordprocessingml.document" ||
    file.ContentType == "application/pdf"))
            {
                ModelState.AddModelError("CustomError", "Позволени са само .docx и .pdf документи!");
                return View();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    string fileName = Path.GetFileName(file.FileName);
                    file.SaveAs(Path.Combine(Server.MapPath("~/UploadedCVs"), fileName));
                    this.service.CreateFile(c, fileName, userId);
                    ModelState.Clear();
                    ViewBag.Message = "Успешно качи CV!";

                }
                catch (Exception e)
                {
                    ViewBag.Message = "Възникна грешка. Моля, опитай отново!";
                    return View();
                }
            }
            return this.View();
        }

        [HttpGet]
        [Route("all/{userId}")]
        public ActionResult All(string userId)
        {
            IEnumerable<AllCarrerCVs> vms = this.service.GetAllCvsVm(userId);
            return this.View(vms);
        }

        [HttpGet]
        [Route("delete/{id}")]
        public ActionResult Delete(int id)
        {
            DeleteCvVm vm = this.service.GetDeleteCvVm(id);
            return this.View(vm);
        }

        [HttpPost]
        [Route("delete/{id}")]
        public ActionResult Delete([Bind(Include = "CvId")]DeleteCvBm bind)
        {
            if (this.ModelState.IsValid)
            {
                this.service.DeleteCv(bind);
                return this.RedirectToAction("All","Ads");//TODO: Redirect?
            }
            DeleteCvVm vm = this.service.GetDeleteCvVm(bind.CvId);
            return this.View(vm);
        }


    }
}