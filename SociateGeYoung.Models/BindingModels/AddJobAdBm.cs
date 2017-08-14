using System.ComponentModel.DataAnnotations;
using SociateGeYoung.Models.Enums;

namespace SociateGeYoung.Models.BindingModels
{
    public class AddJobAdBm
    {
        public string Position { get; set; }
        public string ImageUrl { get; set; }
        public StudentProfile StudentProfile { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
    }
}