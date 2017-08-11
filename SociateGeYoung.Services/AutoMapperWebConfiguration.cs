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
                expression.CreateMap<FirstTestBM, FirstTest>();
                expression.CreateMap<JobAd, JobAdVm>();
                expression.CreateMap<JobAd, DatailsJobAdVm>();
                expression.CreateMap<AddJobAdBm, JobAd>();
                expression.CreateMap<AddJobAdBm, AddJobAdVm>();
            });
        }
    }
}