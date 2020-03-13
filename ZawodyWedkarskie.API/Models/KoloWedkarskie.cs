using System.ComponentModel.DataAnnotations;

namespace ZawodyWedkarskie.API.Models
{
    public class KoloWedkarskie
    {
        [Key]
        public int Id { get; set; }     
        public string Nazwa { get; set; }
    }
}