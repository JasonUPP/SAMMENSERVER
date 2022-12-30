﻿using DataBase.Models.Operativo;

namespace SAMMEN.API.Services.Operativo.Interfaces
{
    public interface IHerramientaRepository
    {
        public Task<List<Herramienta>> GetHerramientas();
    }
}
