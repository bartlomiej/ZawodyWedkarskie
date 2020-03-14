using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZawodyWedkarskie.API.Models
{
    public class Uzytkownik
    {
        [Key]
        public int IdUzytkownika { get; set; }
        [Required]
        [Column(TypeName = "NVARCHAR(40)")]
        public string Nazwisko { get; set; }
        [Required]
        [Column(TypeName = "NVARCHAR(30)")]
        public string Imie { get; set; }
        [Column(TypeName = "NVARCHAR(70)")]
        public string Login { get; set; }
        public byte[] Haslo { get; set; }
        public byte[] Sol { get; set; }
        [Column(TypeName = "NVARCHAR(50)")]
        public string Email { get; set; }
        [Required]
        public bool Aktywny { get; set; }
        [Required]
        [Column(TypeName = "NVARCHAR(70)")]
        public string UzytkownikUtworzyl { get; set; }
        [Required]
        [Column(TypeName = "NVARCHAR(70)")]
        public string UzytkownikModyfikowal { get; set; }
        [Required]
        [Column(TypeName = "DATETIME")]
        public DateTime DataUtworzenia { get; set; }
        [Required]
        [Column(TypeName = "DATETIME")]
        public DateTime DataModyfikacji { get; set; }
    }
}