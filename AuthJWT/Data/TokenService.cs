using AuthJWT.Data.Interfaces;
using DataBase.Models.Operativo;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AuthJWT.Data
{
    public class TokenService : ITokenService
    {
        private readonly SymmetricSecurityKey _ssKey;

        public TokenService(IConfiguration configuration)
        {
            _ssKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Token"]));
        }

        public string CreateToken(User user)
        {
            var claims = new List<Claim> 
            { 
                new Claim(JwtRegisteredClaimNames.NameId, user.Email) 
            };
            var credentials = new SigningCredentials(_ssKey, SecurityAlgorithms.HmacSha512Signature);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = System.DateTime.Now.AddHours(8),
                SigningCredentials = credentials
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);            
        }
    }
}
