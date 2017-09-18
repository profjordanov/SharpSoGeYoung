using System.ComponentModel.DataAnnotations;
using System.Web;
using SociateGeYoung.Models.EntityModels;

namespace SociateGeYoung.Models.BindingModels
{
    public class SubmitCVBm
    {
        public HttpPostedFileBase File { get; set; }
    }
}