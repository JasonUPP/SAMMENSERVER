using AuthJWT.Dtos;
using AutoMapper;
using DataBase.Models.Operativo;

namespace SAMMEN.API.Mappers
{
    public class AutoMapperJson : Profile
    {
        public AutoMapperJson() 
        {
            CreateMap<Ubicacion,JsonDto>();
        }
    }
}
