using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZawodyWedkarskie.API.Models
{
    public class Kolo
    {
        [Key]
        public int IdKola { get; set; }    
        [Required]
        [Column(TypeName = "NVARCHAR(200)")]
        public string Nazwa { get; set; }
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