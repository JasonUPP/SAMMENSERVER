﻿using AuthJWT.Dtos.Operativo;
using AutoMapper;
using DataBase.Models.Operativo;

namespace SAMMEN.API.Mappers
{
    public class AutoMapperOperativo : Profile
    {
        public AutoMapperOperativo() 
        {
            CreateMap<Herramienta, HerramientaDto>();//Herramienta a dto
            CreateMap<HerramientaDto, Herramienta>();//dto a herramienta
            CreateMap<MedidaHerramienta, MedidaHerramientaDto>();
            CreateMap<MedidaHerramientaDto, MedidaHerramienta>();
            CreateMap<HistorialHerramienta, HistorialHerramientaDto>();
            CreateMap<HistorialHerramientaDto, HistorialHerramienta>();
            CreateMap<Operador, OperadorDto>();
            CreateMap<OperadorDto, Operador>();
            CreateMap<UbicacionDto, Ubicacion>();
            CreateMap<Ubicacion, UbicacionDto>();
        }
    }
}
