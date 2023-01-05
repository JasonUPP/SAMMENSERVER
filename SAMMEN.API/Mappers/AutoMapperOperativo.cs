using AuthJWT.Dtos.Operativo;
using AutoMapper;
using DataBase.Models.Operativo;

namespace SAMMEN.API.Mappers
{
    public class AutoMapperOperativo : Profile
    {
        public AutoMapperOperativo() 
        {
            CreateMap<Herramienta, HerramientaDto>();
            CreateMap<MedidaHerramienta, MedidaHerramientaDto>();
        }
    }
}
