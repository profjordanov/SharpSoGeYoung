using SociateGeYoung.Models.EntityModels;

namespace SociateGeYoung.Models.ViewModels
{
    public class CarrerCvVm
    {
        public int Id { get; set; }
        public string CVpath { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}