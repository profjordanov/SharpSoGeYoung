using SociateGeYoung.Models.Enums;

namespace SociateGeYoung.Models.BindingModels
{
    public class UserInfoBm
    {
        public int ApplyId { get; set; }
        public string UserEmail { get; set; }
        public string JobPosition { get; set; }
        public ApplyStatus ApplyStatus { get; set; }
    }
}