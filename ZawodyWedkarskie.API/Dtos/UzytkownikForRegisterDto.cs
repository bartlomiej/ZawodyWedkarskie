namespace ZawodyWedkarskie.API.Dtos
{
    public class UzytkownikForRegisterDto
    {
        //string nazwisko, string imie, string nrKartyWedkarskiej, string login, string password, string email
        public string Nazwisko { get; set; }
        public string Imie { get; set; }
        public string NrKartyWedkarskiej { get; set; }
        public string Login { get; set; }
        public string Haslo { get; set; }
        public string Email { get; set; }
    }
}