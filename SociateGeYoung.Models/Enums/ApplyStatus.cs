using System.ComponentModel.DataAnnotations;

namespace SociateGeYoung.Models.Enums
{
    public enum ApplyStatus
    {
        [Display(Name = "Неопределен")]
        Undefined,

        [Display(Name = "Неподходящ")]
        Inappropriate,

        [Display(Name = "Подходящ")]
        Appropriate,

        [Display(Name = "Средноподходящ")]
        ModeratelyAppropriate,

        [Display(Name = "За Интервю")]
        ForAnInterview
    }
}