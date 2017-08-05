using System.ComponentModel.DataAnnotations;

namespace SociateGeYoung.Models.ViewModels
{
    public class DatailsJobAdVm
    {
        public int Id { get; set; }
        public string Position { get; set; }
        public string ImageUrl { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
    }
}