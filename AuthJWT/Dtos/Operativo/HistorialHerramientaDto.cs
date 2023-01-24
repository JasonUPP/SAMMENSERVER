using DataBase.Enums.Operativo;
using DataBase.Models.Operativo;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AuthJWT.Dtos.Operativo
{
    public class HistorialHerramientaDto
    {            
        public int Id { get; set; }
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public string Pozo { get; set; }
        public string Estructura { get; set; }
        public int TipoOperacion { get; set; }
        public int Unidad { get; set; }
        public int IdOperador { get; set; }
        public int ProfundidadMax { get; set; }
        public decimal OD { get; set; }
        public decimal MaxWHP { get; set; }
        public decimal TemperaturaMaxima { get; set; }
        public decimal MaxCircPressure { get; set; }
        public decimal Diesel { get; set; }
        public decimal Solvente { get; set; }        
        public decimal Acido { get; set; }        
        public decimal Divergente { get; set; }         
        public decimal Nitrogeno { get; set; }        
        public decimal GelLineal { get; set; }        
        public decimal Agua { get; set; }        
        public decimal Inhibidor { get; set; }
        public int HorasOperativas { get; set; }
        public int HorasEfectivas { get; set; }
        public string Notas { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string NumeroSerie { get; set; }
    }
}
