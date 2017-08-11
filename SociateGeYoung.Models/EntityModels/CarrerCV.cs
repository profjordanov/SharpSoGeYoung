using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SociateGeYoung.Models.EntityModels
{
    public class CarrerCV
    {
        public CarrerCV()
        {
            this.Applies = new HashSet<Apply>();
        }
        public int Id { get; set; }
        public string CVpath { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual ICollection<Apply> Applies { get; set; }
    }
}