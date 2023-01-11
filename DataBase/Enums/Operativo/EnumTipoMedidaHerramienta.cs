using System.Runtime.Serialization;

namespace DataBase.Enums.Operativo
{
    public enum EnumTipoMedidaHerramienta
    {        
        General = 1,
        [EnumMember(Value = "Barras Rigidas")]
        BarrasRigidas = 2,
        [EnumMember(Value = "Canasta y Chatarrera")]
        CanastaYChatarrera = 3,
        Centralizadores = 4,
        [EnumMember(Value = "Conectores Dimple")]
        ConectoresDimple = 5,
        [EnumMember(Value = "Conectores EZ")]
        ConectoresEZ = 6,
        [EnumMember(Value = "Conectores Roll On")]
        ConectoresRollOn = 7,
        Crossovers = 8,
        [EnumMember(Value = "Ensambles de Seguridad")]
        EnsamblesSeguridad = 9,
        Molinos = 10,
        [EnumMember(Value = "Motor Filtro Roto Martillo")]
        MotorFiltroRotoMartillo = 11,
        Optimizadores = 12,
        Pescantes = 13,
        [EnumMember(Value = "Sellos de Plomo")]
        SellosPlomo = 14,
        Zapatas = 15,
        [EnumMember(Value = "Junta de Rodilla")]
        JuntaRodilla = 16
    }
}
