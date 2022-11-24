using AuthJWT.Dtos;
using AutoMapper;
using SAMMEN.DataBase.Models;

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
