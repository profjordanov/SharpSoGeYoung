using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using SociateGeYoung.Models.Enums;

namespace SociateGeYoung.Models.BindingModels
{
    public class DeleteJobAdBm
    {
        [Key]
        public int Id { get; set; }
        
    }
}