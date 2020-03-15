using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZawodyWedkarskie.API.Models
{
    public class SlownikRodzajZawodow
    {
        [Key]
        public int IdRodzaju { get; set; }
        [Required]
        [Column(TypeName = "NVARCHAR(30)")]
        public string Rodzaj { get; set; }
        [Required]
        [Column(TypeName = "NVARCHAR(30)")]
        public string Dyscyplina { get; set; }
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
