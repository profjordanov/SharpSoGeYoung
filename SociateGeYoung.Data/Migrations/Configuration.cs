using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SociateGeYoung.Models.EntityModels;

namespace SociateGeYoung.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SociateGeYoung.Data.SociateGeYoungContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(SociateGeYoung.Data.SociateGeYoungContext context)
        {
            //Create Admin role
            if (!context.Roles.Any(r => r.Name == "Admin"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "Admin" };

                manager.Create(role);
            }
            //Create Student role
            if (!context.Roles.Any(r => r.Name == "Student"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "Student" };

                manager.Create(role);
            }
            //Create admin
            if (!context.Users.Any(u => u.UserName == "maria.filipova@gmail.com"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "maria.filipova@gmail.com", Email = "maria.filipova@gmail.com"};

                var result = manager.Create(user, "@soge1234");
                manager.AddToRole(user.Id, "Admin");
                manager.AddToRole(user.Id, "Student");
                context.SaveChanges();
            }
        }
    }
}
