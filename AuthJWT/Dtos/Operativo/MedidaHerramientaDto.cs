namespace AuthJWT.Dtos.Operativo
{
    public class MedidaHerramientaDto
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public string Descripcion { get; set; }        
        public decimal RoscaCaja { get; set; }        
        public decimal RoscaPin { get; set; }            
        public decimal DiametroExterno { get; set; }
        public string BalinPaso { get; set; }        
        public decimal Longitud { get; set; }
        public string NumeroSerie { get; set; }
        public string Estatus { get; set; }        
        public decimal TensionMaxima { get; set; }        
        public decimal PresionMaxima { get; set; }
        public string BalinSub { get; set; }
        public string BalinDesconector { get; set; }
        public string Tipo { get; set; }
    }
}
