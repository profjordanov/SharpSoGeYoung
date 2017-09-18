using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using SociateGeYoung.Models.Enums;

namespace SociateGeYoung.Models.ViewModels
{
    public class DeleteJobAdVm
    {
        [Key]
        public int Id { get; set; }
        public string Position { get; set; }

        //TODO: Image tobe from the computer
        public string ImageUrl { get; set; }
        public StudentProfile StudentProfile { get; set; }
        public string Location { get; set; }
        public DateTime CreateOn { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime ValidUntil { get; set; }

        [DataType(DataType.MultilineText)]
        [AllowHtml]
        public string Description { get; set; }

        public bool IsDeleted { get; set; }
    }
}