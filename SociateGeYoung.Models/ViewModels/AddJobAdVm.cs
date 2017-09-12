using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using SociateGeYoung.Models.Enums;

namespace SociateGeYoung.Models.ViewModels
{
    public class AddJobAdVm
    {
        public string Position { get; set; }
        public string ImageUrl { get; set; }
        public StudentProfile StudentProfile { get; set; }

        [DataType(DataType.MultilineText)]
        [AllowHtml]
        public string Description { get; set; }
    }
}