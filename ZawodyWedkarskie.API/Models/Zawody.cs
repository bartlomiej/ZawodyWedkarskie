using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZawodyWedkarskie.API.Models
{
    public class Zawody
    {
        [Key]
        public int IdZawodow { get; set; }
        [Required]
        [Column(TypeName = "NVARCHAR(200)")]
        public string Nazwa { get; set; }
        [Required]
        [Column(TypeName = "DATETIME")]
        public DateTime Data { get; set; }
        [Required]
        [Column(TypeName = "DATETIME")]
        public DateTime DataKoncaZapisow { get; set; }
        [Required]
        [Column(TypeName = "DATETIME")]
        public DateTime DataZbiorki { get; set; }
        [Required]
        [Column(TypeName = "DATETIME")]
        public DateTime DataRozpoczecia { get; set; }
        [Required]
        [Column(TypeName = "DATETIME")]
        public DateTime DataZakonczenia { get; set; }
        [Required]
        public int IdRodzajuZawodow { get; set; }
        [ForeignKey(nameof(IdRodzajuZawodow))]
        public SlownikRodzajZawodow RodzajZawodow  { get; set; } 
        public int IdGrandPrix { get; set; }
        [ForeignKey(nameof(IdGrandPrix))]
        public GrandPrix GrandPrix { get; set; }
        public int IdKolaOrganizatora { get; set; }
        [ForeignKey(nameof(IdKolaOrganizatora))]
        public Kolo KoloOrganizator { get; set; }
        [Required]
        public bool TylkoDlaCzlonkowKola { get; set; }
        public int IdLowiska { get; set; }
        [ForeignKey(nameof(IdLowiska))]
        public SlownikLowisko Lowisko { get; set; }
        [Required]
        public bool Zakonczone { get; set; }
        public string UwagiLowisko { get; set; }
        public string Protesty { get; set; }
        public int PunktyZaWymiar { get; set; }
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