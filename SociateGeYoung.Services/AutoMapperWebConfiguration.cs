using AutoMapper;
using SociateGeYoung.Models.BindingModels;
using SociateGeYoung.Models.EntityModels;
using SociateGeYoung.Models.ViewModels;

namespace SociateGeYoung.Services
{
    public static class AutoMapperWebConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(expression =>
            {
                expression.CreateMap<FirstTestBM, FirstTest>()
                    .IgnoreAllPropertiesWithAnInaccessibleSetter()
                    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter();
                expression.CreateMap<JobAd, JobAdVm>();
                expression.CreateMap<JobAd, DatailsJobAdVm>();
                expression.CreateMap<AddJobAdBm, JobAd>();
                expression.CreateMap<AddJobAdBm, AddJobAdVm>();
                expression.CreateMap<CarrerCV, AllCarrerCVs>()
                    .ForMember(vm => vm.ApplicationUser, 
                         configurationExpression => configurationExpression.MapFrom(cv => cv.ApplicationUser));
                expression.CreateMap<CarrerCV, DeleteCvVm>();
                expression.CreateMap<AddNewBm, New>();
                expression.CreateMap<New, HomeNewsVm>();
                expression.CreateMap<JobAd, EditAdVm>();
                expression.CreateMap<EditAdBm, JobAd>();
                expression.CreateMap<JobAd, DeleteJobAdVm>();

            });
        }
    }
}