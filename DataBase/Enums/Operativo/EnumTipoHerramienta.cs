using System.Runtime.Serialization;

namespace DataBase.Enums.Operativo
{
    public enum EnumTipoHerramienta
    {
        [EnumMember(Value = "Ensambles Seguridad")]
        EnsamblesSeguridad = 1,
        [EnumMember(Value = "Barras Rigidas")]
        BarrasRigidas = 2,
        Dimples = 3,
        [EnumMember(Value = "Cuñas EZ")]
        ConectoresEZ = 4,
        [EnumMember(Value = "Roll y Dimple On")]
        ConectoresRollOn = 5,
        Molinos = 6,
        [EnumMember(Value = "Motores y Filtros")]
        MotoresFondoYFiltros = 7,
        Optimizadores = 8,
        Crossovers = 9,
        Centralizadores = 10,
        Pescantes = 11,
        [EnumMember(Value = "Sellos de Plomo")]
        SellosPlomo = 12,
        [EnumMember(Value = "Zapatas Lavadoras")]
        ZapatasLavadoras = 13,
        [EnumMember(Value = "Juntas de Rodilla")]
        JuntasRodilla = 14,
    }
}
