using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZawodyWedkarskie.API.Models
{
    public class Wedkarz: ModelBase
    {
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
        public Kolo Kolo { get; set; }
        public SlownikStanowisko Stanowisko { get; set; }
        [Required]
        public bool Aktywny { get; set; }
        public ICollection<Zdjecie> Zdjecia { get; set; }
    }
}