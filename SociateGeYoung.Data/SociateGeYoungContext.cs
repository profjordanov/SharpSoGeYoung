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
        public virtual DbSet<CarrerCV> CarrerCvs { get; set; }
        public virtual DbSet<Apply> Applies { get; set; }


        public static SociateGeYoungContext Create()
        {
            return new SociateGeYoungContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CarrerCV>()
                .HasMany<Apply>(c => c.Applies)
                .WithOptional(x => x.CarrerCv)
                .WillCascadeOnDelete(true);

            base.OnModelCreating(modelBuilder);
        }
    }

   
}