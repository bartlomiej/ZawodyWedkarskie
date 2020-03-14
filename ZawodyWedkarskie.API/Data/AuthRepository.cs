using System;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ZawodyWedkarskie.API.Models;

namespace ZawodyWedkarskie.API.Data
{
    public class AuthRepository : IAuthRepository
    {
        private readonly ZawodyWedkarskieContext _context;

        public AuthRepository(ZawodyWedkarskieContext context)
        {
            _context = context;
        }
        public async Task<bool> Exist(string login)
        {
            if(await _context.Uzytkownicy.AnyAsync(x => x.Login == login))
                return true;
            return false;
        }

        public async Task<Uzytkownik> Login(string login, string haslo)
        {
            var user = await _context.Uzytkownicy.FirstOrDefaultAsync(x => x.Login == login);

            if (user == null)
                return null;

            if (!VerifyPasswordHash(haslo, user.HasloHash, user.HasloSalt))
                return null;

            return user;
        }

        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

                for(int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i])
                        return false;
                }
            }
            return true;
        }

        public async Task<Uzytkownik> Register(Uzytkownik user, string password)
        {
            byte[] passwordHash, passwordSalt;

            CreatePassword(password, out passwordHash, out passwordSalt);

            user.HasloHash = passwordHash;
            user.HasloSalt = passwordSalt;

            await _context.Uzytkownicy.AddAsync(user);
            await _context.SaveChangesAsync();
            return user;
        }

        private void CreatePassword(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }
    }
}