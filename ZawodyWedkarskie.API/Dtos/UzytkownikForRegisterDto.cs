using System.ComponentModel.DataAnnotations;

namespace ZawodyWedkarskie.API.Dtos
{
    public class UzytkownikForRegisterDto
    {
        [Required(ErrorMessage = "Nazwisko jest wymagane !")]
        public string Nazwisko { get; set; }
        [Required(ErrorMessage = "Imię jest wymagane !")]
        public string Imie { get; set; }
        [Required(ErrorMessage = "Nr karty wędkarskiej jest wymagany !")]
        public string NrKartyWedkarskiej { get; set; }
        [Required(ErrorMessage = "Login jest wymagany !")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Hasło jest wymagane !")]
        [StringLength(24, MinimumLength = 8, ErrorMessage = "Hasło musi się składać z 8 do 24 znaków !")]
        public string Haslo { get; set; }
        [Required(ErrorMessage = "Adres email jest wymagany !")]
        public string Email { get; set; }
    }
}