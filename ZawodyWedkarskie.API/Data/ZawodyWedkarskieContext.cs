using Microsoft.EntityFrameworkCore;
using ZawodyWedkarskie.API.Models;

namespace ZawodyWedkarskie.API.Data
{
    public class ZawodyWedkarskieContext : DbContext
    {
        public ZawodyWedkarskieContext(DbContextOptions<ZawodyWedkarskieContext> options) : base(options) {}

        public DbSet<KoloWedkarskie> KolaWedkarskie { get; set; } 
    }
}