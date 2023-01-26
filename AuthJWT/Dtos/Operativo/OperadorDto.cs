namespace AuthJWT.Dtos.Operativo
{
    public class OperadorDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Direccion { get; set; }
        public string NumeroCelular { get; set; }
        public int NSS { get; set; }
        public string CursosAbordaje { get; set; }//posible arreglo o tabla
        public DateTime VigenciaCursosAbordaje { get; set; }
        public string CursosSSPA { get; set; }//posible arreglo o tabla
        public DateTime VigenciaCursosSSPA { get; set; }
        public string CursosTecnicos { get; set; }
        public DateTime VigenciaCursosTecnicos { get; set; }
        public string CVSAMMEN { get; set; }//posible archivo
        public string ExamenesMedicos { get; set; }//posible archivo
        public string CursosOExperiencia { get; set; }//posible archivo
    }
}
