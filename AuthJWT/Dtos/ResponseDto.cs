namespace AuthJWT.Dtos
{
    public class ResponseDto
    {
        public bool Error { get; set; }
        public string Message { get; set; }

        public ResponseDto(bool e, string m) 
        {
            Error = e;
            Message = m;
        }
    }
}
