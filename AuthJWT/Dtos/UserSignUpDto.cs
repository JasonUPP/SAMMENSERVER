namespace AuthJWT.Dtos
{
    public class UserSignUpDto
    {        
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public bool IsAdmin { get; set; }
        public DateTime RegisterDate { get; set; }

        public UserSignUpDto()
        {
            RegisterDate = DateTime.Now;
            IsActive = true;
            IsAdmin = false;
    }

    }
}
