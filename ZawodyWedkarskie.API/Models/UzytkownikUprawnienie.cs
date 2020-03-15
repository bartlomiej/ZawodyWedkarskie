using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZawodyWedkarskie.API.Models
{
    public class UzytkownikUprawnienie
    {
        [Key]
        public int IdUprawnienia { get; set; } 
        [Required]
        public int IdUzytkownika { get; set; } 
        [ForeignKey(nameof(IdUzytkownika))]
        public Uzytkownik Uzytkownik  { get; set; } 
        [Required]
        [Column(TypeName = "NVARCHAR(6)")]
        public string Klucz { get; set; }
        [Required]
        [Column(TypeName = "NVARCHAR(1)")]
        public string Uprawnienie { get; set; }
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