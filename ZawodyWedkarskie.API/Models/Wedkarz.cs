using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZawodyWedkarskie.API.Models
{
    public class Wedkarz
    {
        [Key]
        public int IdWedkarza { get; set; }
        [Column(TypeName = "NVARCHAR(20)")]
        public string NrKartyWedkarskiej { get; set; }
        [Required]
        [Column(TypeName = "NVARCHAR(40)")]
        public string Nazwisko { get; set; }
        [Required]
        [Column(TypeName = "NVARCHAR(30)")]
        public string Imie { get; set; }
        [Column(TypeName = "NVARCHAR(30)")]
        public string ImieDrugie { get; set; }
        [Required]
        public bool UprawnieniaSedziego { get; set; }
        public int? IdKola { get; set; }
        [ForeignKey(nameof(IdKola))]
        public Kolo Kolo { get; set; }
        public int? IdStanowiska { get; set; }
        [ForeignKey(nameof(IdStanowiska))]
        public SlownikStanowisko Stanowisko  { get; set; } 
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