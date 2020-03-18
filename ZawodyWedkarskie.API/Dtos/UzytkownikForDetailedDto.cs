using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZawodyWedkarskie.API.Dtos
{
    public class UzytkownikForDetailedDto
    {
        public int IdUzytkownika { get; set; }
        public string Nazwisko { get; set; }
        public string Imie { get; set; }
        public string NrKartyWedkarskiej { get; set; }
    }
}