using AuthJWT.Data.Interfaces;
using DataBase;
using DataBase.Models.Operativo;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;

namespace AuthJWT.Data
{
    public class AuthRepository : IAuthRepository
    {
        private readonly SAMMENContext _context;

        public AuthRepository(SAMMENContext context)
        {
            _context = context;
        }
        public async Task<User> Login(string email, string password)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Email == email);
            if (user == null) return null;
            if (!VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt)) return null;
            return user;            
        }

        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512(passwordSalt))
            {
                var computeHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for(int i = 0; i<computeHash.Length; i++)
                {
                    if (computeHash[i] != passwordHash[i]) return false;
                }
            }
                return true;
        }

        public async Task<User> SignUp(User user, string password)
        {
            byte[] passwordHash;
            byte[] passwordSalt;
            CreatePasswordHash(password, out passwordHash, out passwordSalt);
            user.PasswordSalt = passwordSalt;
            user.PasswordHash = passwordHash;
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return user;
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        public async Task<bool> UserExist(string email)
        {
            if(await _context.Users.AnyAsync(x => x.Email == email)) return true;
            return false;            
        }
    }
}
