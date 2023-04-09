using AutoMapper;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.LoginDto;
using HotelProject.WebUI.Dtos.RegisterDto;
using HotelProject.WebUI.Dtos.ServiceDto;

namespace HotelProject.WebUI.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ServiceResultDto, Service>().ReverseMap();
            CreateMap<ServiceUpdateDto, Service>().ReverseMap();
            CreateMap<ServiceCreateDto, Service>().ReverseMap();
            CreateMap<NewUserCreateDto, AppUser>().ReverseMap();
            CreateMap<UserLoginDto, AppUser>().ReverseMap();
        }
    }
}
