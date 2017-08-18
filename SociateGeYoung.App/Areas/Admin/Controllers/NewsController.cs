using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SociateGeYoung.Models.BindingModels;
using SociateGeYoung.Services;

namespace SociateGeYoung.App.Areas.Admin.Controllers
{
    public class NewsController : Controller
    {
        private NewsService service;
        public NewsController()
        {
            this.service = new NewsService();
        }

        [HttpGet]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost]
        public ActionResult New([Bind(Include = "Title,Video,ImageThumbnail,Description")] AddNewBm bind)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            this.service.AddToNews(bind);
            return this.Redirect("/Home");
        }
    }
}