using System.Runtime.Serialization;

namespace DataBase.Enums.Operativo
{
    public enum EnumEstatus
    {        
        Desconocido = 0,
        Operativo = 1,
        [EnumMember(Value = "Fuera de Servicio")]
        FueraServicio = 2,
        [EnumMember(Value = "Necesita Mtto")]
        NecesitaMtto = 3,
        [EnumMember(Value = "Necesita PND")]
        NecesitaPND = 4,
    }
}
