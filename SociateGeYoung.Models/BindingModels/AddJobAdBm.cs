using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using SociateGeYoung.Models.Enums;

namespace SociateGeYoung.Models.BindingModels
{
    public class AddJobAdBm
    {
        public string Position { get; set; }

        //TODO: Image tobe from the computer
        public string ImageUrl { get; set; }
        public StudentProfile StudentProfile { get; set; }
        public string Location { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime ValidUntil { get; set; }

        [DataType(DataType.MultilineText)]
        [AllowHtml]
        public string Description { get; set; }
        public bool IsDeleted { get; set; }

    }
}