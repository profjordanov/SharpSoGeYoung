using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SociateGeYoung.Models.Enums;

namespace SociateGeYoung.Models.EntityModels
{
    public class Apply
    {
        [Key]
        public int Id { get; set; }

        [Index("JobAd_Id", 1, IsUnique = true)]
        public virtual JobAd JobAd { get; set; }

        [Index("CarrerCv_Id", 2, IsUnique = true)]
        public virtual CarrerCV CarrerCv { get; set; }
        public ApplyStatus ApplyStatus { get; set; }

    }
}