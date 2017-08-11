using System.ComponentModel.DataAnnotations.Schema;

namespace SociateGeYoung.Models.EntityModels
{
    public class Apply
    {
        public int Id { get; set; }
        [Index("JobAd_Id", 1, IsUnique = true)]
        public virtual JobAd JobAd { get; set; }
        [Index("CarrerCv_Id", 2, IsUnique = true)]

        public virtual CarrerCV CarrerCv { get; set; }
    }
}