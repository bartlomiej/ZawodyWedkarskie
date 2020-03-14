using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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

        public AuthController(IAuthRepository repository)
        {
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
    }
}