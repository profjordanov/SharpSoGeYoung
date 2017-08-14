using System.Collections.Generic;
using SociateGeYoung.Models.EntityModels;

namespace SociateGeYoung.Models.ViewModels
{
    public class AllCarrerCVs
    {
        public AllCarrerCVs()
        {
            this.Applies = new HashSet<Apply>();
        }
        public int Id { get; set; }
        public string CVpath { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual ICollection<Apply> Applies { get; set; }
    }
}