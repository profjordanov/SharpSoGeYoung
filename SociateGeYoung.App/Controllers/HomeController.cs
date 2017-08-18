using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SociateGeYoung.Models.ViewModels;
using SociateGeYoung.Services;

namespace SociateGeYoung.App.Controllers
{
    public class HomeController : Controller
    {
        private HomeService service;

        public HomeController()
        {
            this.service = new HomeService();
        }
        public ActionResult Index()
        {
            IEnumerable<HomeNewsVm> vm = this.service.GetAllNews();
            return View(vm);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}