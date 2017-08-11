using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using SociateGeYoung.Models.EntityModels;
using SociateGeYoung.Services;

namespace SociateGeYoung.App.Controllers
{
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
                ModelState.AddModelError("CustomError", "Please select CV");
                return this.View();
            }

            if (!(file.ContentType == "application/vnd.openxmlformats-officedocument.wordprocessingml.document" ||
    file.ContentType == "application/pdf"))
            {
                ModelState.AddModelError("CustomError", "Only .docx and .pdf file allowed");
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
                    ViewBag.Message = "Successfully Done";

                }
                catch (Exception e)
                {
                    ViewBag.Message = "Error! Please try again";
                    return View();
                }
            }
            return this.View();
        }
    }
}