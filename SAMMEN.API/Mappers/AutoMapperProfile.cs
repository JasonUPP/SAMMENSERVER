using AuthJWT.Dtos;
using AutoMapper;
using DataBase.Models.Operativo;

namespace SAMMEN.API.Mappers
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<UserSignUpDto, User>();
            CreateMap<UserLoginDto, User>();
            CreateMap<User,UserListDto>();
        }
    }
}
