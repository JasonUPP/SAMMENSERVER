using AuthJWT.Dtos.Operativo;

namespace SAMMEN.API.Services.Operativo.Interfaces
{
    public interface IHerramientaRepository
    {
        public Task<List<HerramientaDto>> GetHerramientas();
        public Task<object> NewHerramienta(HerramientaDto herramientaDto);
        public Task<object> DeleteHerramienta(int id);
        public Task<object> UpdateHerramienta(HerramientaDto herramientaDto);
    }
}
