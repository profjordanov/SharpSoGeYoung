using System;
using System.ComponentModel.DataAnnotations;

namespace SociateGeYoung.Models.ViewModels
{
    public class AddNewVm
    {
        public string Title { get; set; }
        public string Video { get; set; }
        public string ImageThumbnail { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

    }
}