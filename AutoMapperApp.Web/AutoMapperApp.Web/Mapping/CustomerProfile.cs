using AutoMapper;
using AutoMapperApp.Web.DTOs;
using AutoMapperApp.Web.Models;

namespace AutoMapperApp.Web.Mapping
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<Customer, CustomerDto>()
                .ForMember(dest => dest.Isim, opt => opt.MapFrom(x => x.Name))
                .ForMember(dest => dest.Eposta, opt => opt.MapFrom(x => x.Mail))
                .ForMember(dest => dest.Yas, opt => opt.MapFrom(x => x.Age));
           
        }
    }
}
