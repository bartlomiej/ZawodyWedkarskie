using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZawodyWedkarskie.API.Models
{
    public class Zdjecie : ModelBase
    {
        [Required]
        [Column(TypeName = "NVARCHAR(255)")]
        public string Url { get; set; } 
        [Required]
        [Column(TypeName = "NVARCHAR(200)")]
        public string Opis { get; set; }  
        [Required]  
        public bool Glowne { get; set; }
        public Uzytkownik Uzytkownik { get; set; }
        public int UzytkownikId { get; set; }
        public Wedkarz Wedkarz { get; set; }
        public int WedkarzId { get; set; }
    }
}