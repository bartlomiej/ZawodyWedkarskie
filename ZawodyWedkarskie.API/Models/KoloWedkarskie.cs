using System.ComponentModel.DataAnnotations;

namespace ZawodyWedkarskie.API.Models
{
    public class KoloWedkarskie
    {
        [Key]
        public int Id { get; set; }    
        [Required] 
        public string Nazwa { get; set; }
    }
}