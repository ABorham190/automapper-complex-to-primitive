using AutoMapper;
namespace mapping_complex_type_to_primitve_type.Models
{
    public class MyMappingProfile:Profile
    {
        public MyMappingProfile() {

            //CreateMap<User, UserDTO>()
            //    .ForMember(dest => dest.City, act => act.MapFrom(src => src.Address.City))
            //    .ForMember(dest => dest.State, act => act.MapFrom(src => src.Address.State))
            //    .ForMember(dest => dest.Country, act => act.MapFrom(src => src.Address.Country));

            CreateMap<User, UserDTO>()
                .ForMember(dest => dest.Address, act => act.MapFrom(src => new AddressDTO
                {
                    City = src.City,
                    State = src.State,
                    Country = src.Country
                }));
        
        
        }
    }
}
