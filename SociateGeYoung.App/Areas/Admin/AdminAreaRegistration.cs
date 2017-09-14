using System.Web.Mvc;

namespace SociateGeYoung.App.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                 "Delete_User",
                 "Admin/{controller}/Delete/{id}",
                  new { action = "Delete", id = UrlParameter.Optional }
             );

            context.MapRoute(
                "Admin_paged",
                "Admin/{controller}/{action}/{page}",
                new { action = "UserInfo", page = UrlParameter.Optional }
            );

            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}