using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZawodyWedkarskie.API.Models
{
    public class Uzytkownik : ModelBase
    {
        [Required]
        [Column(TypeName = "NVARCHAR(40)")]
        public string Nazwisko { get; set; }
        [Required]
        [Column(TypeName = "NVARCHAR(30)")]
        public string Imie { get; set; }
        [Column(TypeName = "NVARCHAR(30)")]
        public string NrKartyWedkarskiej { get; set; }
        [Required]
        [Column(TypeName = "NVARCHAR(70)")]
        public string Login { get; set; }
        [Required]
        public byte[] HasloHash { get; set; }
        [Required]
        public byte[] HasloSalt { get; set; }
        [Column(TypeName = "NVARCHAR(50)")]
        public string Email { get; set; }
        [Required]
        public bool Aktywny { get; set; }
        public ICollection<UzytkownikUprawnienie> Uprawnienia { get; set; }
        public ICollection<Zdjecie> Zdjecia { get; set; }
    }
}