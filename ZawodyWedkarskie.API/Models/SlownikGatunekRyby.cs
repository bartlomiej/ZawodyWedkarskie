using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZawodyWedkarskie.API.Models
{
    public class SlownikGatunekRyby : ModelBase
    {
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
    }
}