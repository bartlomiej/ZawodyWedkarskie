using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZawodyWedkarskie.API.Models
{
    public class SlownikLowisko : ModelBase
    {
        [Required]
        [Column(TypeName = "NVARCHAR(200)")]
        public string Nazwa { get; set; }
    }
}