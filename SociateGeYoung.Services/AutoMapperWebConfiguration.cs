using AutoMapper;
using SociateGeYoung.Models.BindingModels;
using SociateGeYoung.Models.EntityModels;

namespace SociateGeYoung.Services
{
    public static class AutoMapperWebConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(expression =>
            {
                expression.CreateMap<FirstTestBM, FirstTest>();
            });
        }
    }
}