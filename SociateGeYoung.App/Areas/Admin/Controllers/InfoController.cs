using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity.EntityFramework;
using SociateGeYoung.Models.EntityModels;
using SociateGeYoung.Models.ViewModels;
using SociateGeYoung.Services;
using PagedList;
using SociateGeYoung.Models.BindingModels;

namespace SociateGeYoung.App.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class InfoController : Controller
    {
        private InfoService service;

        public InfoController()
        {
            this.service = new InfoService();
        }
        [HttpGet]
        public ActionResult UserInfo(int? page)
        {
            IEnumerable<ApplicationUser> applicationUsers = this.service.GetAllUserInfo();
            int pageSize = 3;
            int pageNumber = (page ?? 1);
            return View(applicationUsers.ToPagedList(pageNumber,pageSize));
        }

        [HttpPost]
        public ActionResult UserInfo(int? page,[Bind(Include = "ApplyId, ApplyStatus")]UserInfoBm bind)
        {
            if (ModelState.IsValid)
            {
                //TODO: Save Apply Status to the Apply
                //TODO: Add apropriate paging
                //TODO: SEND EMAIL
            }
            IEnumerable<ApplicationUser> applicationUsers = this.service.GetAllUserInfo();
            int pageSize = 3;
            int pageNumber = (page ?? 1);
            return View(applicationUsers.ToPagedList(pageNumber, pageSize));
        }

        [HttpGet]
        public ActionResult ManageUsers()
        {
            string searchString = String.Empty;
            Tuple<IEnumerable<ApplicationUser>, IEnumerable<IdentityRole>> usersAndRoles = this.service.ModifyUsers(searchString);
            return this.View(usersAndRoles);
        }

        [HttpPost]
        public ActionResult ManageUsers(string searchString)
        {
            Tuple<IEnumerable<ApplicationUser>, IEnumerable<IdentityRole>> usersAndRoles = this.service.ModifyUsers(searchString);
            ModelState.Clear();
            return this.View(usersAndRoles);
        }

        [HttpGet]
        public ActionResult Delete(string id)
        {
            ApplicationUser user = this.service.TakeUserForDelete(id);
            return this.View(user);
        }

        [HttpGet]
        public ActionResult ModifyRoles(string userId)
        {
            IEnumerable<IdentityRole> roles = this.service.GetUserRoles();
            return this.View(roles);
        }

        /*
        [HttpPost]
        public ActionResult ModifyRoles([Bind(Include = "RoleId")]ModifyRoleBm bind)
        {
            if (!ModelState.IsValid)
            {
                IEnumerable<IdentityRole> roles = this.service.GetUserRoles();
                return this.View(roles);
            }
            return this.View();

        }
        */

        /*
        [HttpPost]
        public ActionResult Delete([Bind(Include = "Id")] DeleteUserBm bind)
        {
            if (!ModelState.IsValid)
            {
                ApplicationUser user = this.service.TakeUserForDelete(bind.Id);
                return this.View(user);
            }
            this.service.DeleteUser(bind);
            return this.RedirectToAction("UserInfo", "Info");
        }
        */
    }
}