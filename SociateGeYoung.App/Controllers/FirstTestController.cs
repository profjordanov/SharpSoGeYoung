using System;
using System.Web.Mvc;
using SociateGeYoung.Models.BindingModels;
using SociateGeYoung.Services;
using SociateGeYoung.Services.Interfaces;

namespace SociateGeYoung.App.Controllers
{
    [RoutePrefix("FirstTest")]
    [AllowAnonymous]
    public class FirstTestController : Controller
    {
        private FirstTestService firstTestService;

        public FirstTestController()
        {
            this.firstTestService = new FirstTestService();
        }

        [Route("{userId?}")]
        public ActionResult Index(string userId)
        {
            return View();
        }

        [HttpPost]
        [Route("{userId?}")]
        public ActionResult Index([Bind(Include = "quest1, quest2,quest3,quest4,quest5,quest6,quest7,quest8,quest9," +
                                                  "quest10,quest11,quest12,quest13,quest14,quest15,quest16,quest17,quest18,quest19,"+
                                                  "quest20,quest21,quest22,quest23,quest24,quest25,quest26,quest27,quest28,quest29,"+
                                                  "quest30,quest31,quest32,quest33,quest34,quest35,quest36,quest37,quest38,quest39,"+
                                                  "quest40,quest41,quest42,quest43,quest44,quest45,quest46,quest47,quest48,quest49,"+
                                                  "quest50,quest51,quest52,quest53,quest54,quest55,quest56,quest57,quest58,quest59,"+
                                                  "quest60,quest61,quest62,quest63,quest64,quest65,quest66,quest67,quest68,quest69,"+
                                                  "quest70,quest71,quest72,quest73,quest74,quest75,quest76,quest77,quest78,quest79,"+
                                                  "quest80,UserId"
                                                  )] FirstTestBM bind)
        {
            this.firstTestService.IsThereUser = bind.UserId != null;
            this.firstTestService.AddTest(bind);

            if (this.firstTestService.Calculator() == "style1")
            {
                return this.RedirectToAction("Style1", new { UserCode = this.firstTestService.CodeForUser});
            }

            if (this.firstTestService.Calculator() == "style2")
            {
                return this.RedirectToAction("Style2", new { UserCode = this.firstTestService.CodeForUser });
            }

            if (this.firstTestService.Calculator() == "style3")
            {
                return this.RedirectToAction("Style3", new { UserCode = this.firstTestService.CodeForUser });
            }

            if (this.firstTestService.Calculator() == "style4")
            {
                return this.RedirectToAction("Style4", new { UserCode = this.firstTestService.CodeForUser });
            }

            return this.RedirectToAction("Index");
        }

        [HttpGet]
        [Route("Style1")]
        public ActionResult Style1(string UserCode)
        {
            ViewBag.Message = UserCode;
            return View();
        }

        [HttpGet]
        [Route("Style2")]
        public ActionResult Style2(string UserCode)
        {
            ViewBag.Message = UserCode;

            return View();
        }

        [HttpGet]
        [Route("Style3")]
        public ActionResult Style3(string UserCode)
        {
            ViewBag.Message = UserCode;

            return View();
        }

        [HttpGet]
        [Route("Style4")]
        public ActionResult Style4(string UserCode)
        {
            ViewBag.Message = UserCode;

            return View();
        }

        [HttpGet]
        public ActionResult Error()
        {
            return View();
        }

        [HttpGet]
        [Route("AddCode/{userId}")]
        public ActionResult AddTestCode()
        {
            return this.View();
        }

        [HttpPost]
        [Route("AddCode/{userId}")]
        public ActionResult AddTestCode([Bind(Include = "userId,TestCode")]AddTestCodeBm bind)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    this.firstTestService.AddTestCodeForUser(bind);
                    ModelState.Clear();
                    ViewBag.Message = "Успешно прати теста към ЧР";
                }
                catch (Exception e)
                {
                    ViewBag.Message = "Възникна грешка. Моля, опитай отново!";
                    return this.View();
                }
            }
            return this.View();
        }
    }
}