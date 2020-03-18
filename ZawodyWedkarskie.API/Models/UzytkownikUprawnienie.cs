using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZawodyWedkarskie.API.Models
{
    public class UzytkownikUprawnienie : ModelBase
    {
        [Required]
        [Column(TypeName = "NVARCHAR(6)")]
        public string Klucz { get; set; }
        [Required]
        [Column(TypeName = "NVARCHAR(1)")]
        public string Uprawnienie { get; set; }
        public Uzytkownik Uzytkownik { get; set; }
        public int UzytkownikId { get; set; }
    }
}