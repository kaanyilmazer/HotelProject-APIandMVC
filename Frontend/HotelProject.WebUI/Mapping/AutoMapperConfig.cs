using AutoMapper;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.ServiceDto;

namespace HotelProject.WebUI.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ServiceResultDto, Service>().ReverseMap();
            CreateMap<ServiceUpdateDto, Service>().ReverseMap();
            CreateMap<ServiceCreateDto, Service>().ReverseMap();
        }
    }
}
