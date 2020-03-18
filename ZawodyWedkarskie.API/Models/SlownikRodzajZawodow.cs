using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZawodyWedkarskie.API.Models
{
    public class SlownikRodzajZawodow : ModelBase
    {
        [Required]
        [Column(TypeName = "NVARCHAR(30)")]
        public string Rodzaj { get; set; }
        [Required]
        [Column(TypeName = "NVARCHAR(30)")]
        public string Dyscyplina { get; set; }
    }
}
