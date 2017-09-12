using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using SociateGeYoung.Models.Enums;

namespace SociateGeYoung.Models.EntityModels
{
    public class JobAd
    {
        //TODO: I need to put the whole information about "Add"
        public JobAd()
        {
            this.Applies = new HashSet<Apply>();
        }
        [Key]
        public int Id { get; set; }
        public string Position { get; set; }
        public string ImageUrl { get; set; }
        public StudentProfile StudentProfile { get; set; }

        [DataType(DataType.MultilineText)]
        [AllowHtml]
        public string Description { get; set; }

        public virtual ICollection<Apply> Applies { get; set; }
    }
}