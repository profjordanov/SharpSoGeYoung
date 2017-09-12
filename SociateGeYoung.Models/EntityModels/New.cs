using System;
using System.ComponentModel.DataAnnotations;

namespace SociateGeYoung.Models.EntityModels
{
    public class New
    {
        //TODO: What is gona have this?
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Video { get; set; }
        public string ImageThumbnail { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Description { get; set; }
    }
}