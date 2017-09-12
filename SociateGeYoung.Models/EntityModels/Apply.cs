using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SociateGeYoung.Models.EntityModels
{
    public class Apply
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Index("JobAd_Id", 1, IsUnique = true)]
        public virtual JobAd JobAd { get; set; }

        [Required]
        [Index("CarrerCv_Id", 2, IsUnique = true)]
        public virtual CarrerCV CarrerCv { get; set; }

    }
}