using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SociateGeYoung.Models.EntityModels
{
    public class JobAd
    {
        public JobAd()
        {
            this.Applies = new HashSet<Apply>();
        }
        public int Id { get; set; }
        public string Position { get; set; }
        public string ImageUrl { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public virtual ICollection<Apply> Applies { get; set; }
    }
}