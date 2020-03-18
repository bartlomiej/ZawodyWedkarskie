using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZawodyWedkarskie.API.Models
{
    public class SlownikNagroda : ModelBase
    {
        [Required]
        [Column(TypeName = "NVARCHAR(30)")]
        public string Nazwa { get; set; }
        [Required]
        [Column(TypeName = "MONEY")]
        public decimal SredniaCena { get; set; }
    }
}