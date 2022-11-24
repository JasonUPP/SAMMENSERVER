using AuthJWT.Data.Interfaces;
using AuthJWT.Dtos;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SAMMEN.DataBase.Models;

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
            userSignUpDto.UserName = userSignUpDto.UserName.ToLower();
            if (await _repository.UserExist(userSignUpDto.UserName))
                return BadRequest("usuario ya existe");

            var newUser = _mapper.Map<User>(userSignUpDto);
            var createdUser = await _repository.SignUp(newUser, userSignUpDto.Password);
            var returnUser = _mapper.Map<UserListDto>(createdUser);
            return Ok(returnUser);
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(UserLoginDto userLoginDto)
        {
            var user = await _repository.Login(userLoginDto.UserName, userLoginDto.Password);
            if (user == null)
                return Unauthorized();
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
