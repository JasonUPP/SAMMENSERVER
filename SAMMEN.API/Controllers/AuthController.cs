using AuthJWT.Data.Interfaces;
using AuthJWT.Dtos;
using AutoMapper;
using DataBase.Models.Operativo;
using Microsoft.AspNetCore.Mvc;

namespace SAMMEN.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _repository;
        private readonly ITokenService _tokenService;
        private readonly IMapper _mapper;

        public AuthController(IAuthRepository repository, ITokenService tokenService, IMapper mapper)
        {
            _repository = repository;
            _tokenService = tokenService;
            _mapper = mapper;
        }

        [HttpPost("SignUp")]
        public async Task<IActionResult> SignUp(UserSignUpDto userSignUpDto)
        {
            userSignUpDto.Email = userSignUpDto.Email.ToLower();
            if (await _repository.UserExist(userSignUpDto.Email))
                return BadRequest("Email ya en uso");

            var newUser = _mapper.Map<User>(userSignUpDto);
            var createdUser = await _repository.SignUp(newUser, userSignUpDto.Password);
            var returnUser = _mapper.Map<UserListDto>(createdUser);
            return Ok(returnUser);
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(UserLoginDto userLoginDto)
        {
            var user = await _repository.Login(userLoginDto.Email, userLoginDto.Password);
            if (user == null)
                return BadRequest("Credenciales incorrectas");
            var returnUser = _mapper.Map<UserListDto>(user);
            var token = _tokenService.CreateToken(user);
            return Ok(new 
                { 
                    token = token,
                    user= returnUser
            });
        }
                
    }
}
