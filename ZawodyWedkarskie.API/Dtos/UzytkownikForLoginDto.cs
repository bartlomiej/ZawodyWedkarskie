using System.ComponentModel.DataAnnotations;

namespace ZawodyWedkarskie.API.Dtos
{
    public class UzytkownikForLoginDto
    {
        [Required(ErrorMessage = "Login jest wymagany !")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Hasło jest wymagane !")]
        public string Haslo { get; set; }
    }
}