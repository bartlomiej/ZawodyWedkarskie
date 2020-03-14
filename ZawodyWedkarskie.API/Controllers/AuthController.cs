using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using ZawodyWedkarskie.API.Data;
using ZawodyWedkarskie.API.Dtos;
using ZawodyWedkarskie.API.Models;

namespace ZawodyWedkarskie.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _repository;
        private readonly IConfiguration _configuration;

        public AuthController(IAuthRepository repository, IConfiguration configuration)
        {
            _configuration = configuration;
            _repository = repository;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UzytkownikForRegisterDto uzytkownikForRegisterDto)
        {
            uzytkownikForRegisterDto.Login = uzytkownikForRegisterDto.Login.ToLower();

            if (await _repository.Exist(uzytkownikForRegisterDto.Login))
            {
                return BadRequest("Użytkownik o takim loginie już istnieje !");
            }

            var user = new Uzytkownik();
            user.Login = uzytkownikForRegisterDto.Login;
            user.Nazwisko = uzytkownikForRegisterDto.Nazwisko;
            user.Imie = uzytkownikForRegisterDto.Imie;
            user.NrKartyWedkarskiej = uzytkownikForRegisterDto.NrKartyWedkarskiej;
            user.Aktywny = false;
            user.Email = uzytkownikForRegisterDto.Email;

            var createdUser = await _repository.Register(user, uzytkownikForRegisterDto.Haslo);

            return StatusCode(201);
        }
        
        [HttpPost("login")]
        public async Task<IActionResult> Login(UzytkownikForLoginDto uzytkownikForLoginDto)
        {
            var user = await _repository.Login(uzytkownikForLoginDto.Login.ToLower(), uzytkownikForLoginDto.Haslo);

            if (user == null)
                return Unauthorized();

            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.IdUzytkownika.ToString()),
                new Claim(ClaimTypes.Name, user.Nazwisko)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetSection("AppSettings:Token").Value));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddHours(12),
                SigningCredentials = creds
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);

            return Ok(new { token = tokenHandler.WriteToken(token) });
        }
    }
}