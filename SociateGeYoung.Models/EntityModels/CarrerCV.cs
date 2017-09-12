using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SociateGeYoung.Models.EntityModels
{
    public class CarrerCV
    {
        public CarrerCV()
        {
            this.Applies = new HashSet<Apply>();
        }

        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string CVpath { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual ICollection<Apply> Applies { get; set; }
    }
}