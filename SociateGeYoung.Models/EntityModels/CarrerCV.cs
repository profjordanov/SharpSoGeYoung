namespace SociateGeYoung.Models.EntityModels
{
    public class CarrerCV
    {
        public int Id { get; set; }
        public string CVpath { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}