using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZawodyWedkarskie.API.Models
{
    public class SlownikGatunekRyby
    {
        [Key]
        public int IdGatunku { get; set; }
        [Required]
        [Column(TypeName = "NVARCHAR(30)")]
        public string Nazwa { get; set; }
        public int WymiarOchronny { get; set; }
        public int Punkty { get; set; }
        public int PunktyPonadWymiar { get; set; }
        [Column(TypeName = "DATETIME")]
        public DateTime OkresOchronnyOd { get; set; }
        [Column(TypeName = "DATETIME")]
        public DateTime OkresOchronnyDo { get; set; }
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