using Microsoft.AspNet.Identity.EntityFramework;
using SociateGeYoung.Models.EntityModels;

namespace SociateGeYoung.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class SociateGeYoungContext : IdentityDbContext<ApplicationUser>
    {
        
        public SociateGeYoungContext()
           : base("name=SociateGeYoungContext", throwIfV1Schema: false)
        {
        }

        public virtual DbSet<FirstTest> FirstTests { get; set; }
        public virtual DbSet<JobAd> JobAds { get; set; }



        public static SociateGeYoungContext Create()
        {
            return new SociateGeYoungContext();
        }

    }

   
}