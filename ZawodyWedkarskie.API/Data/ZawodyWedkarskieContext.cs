using Microsoft.EntityFrameworkCore;
using ZawodyWedkarskie.API.Models;

namespace ZawodyWedkarskie.API.Data
{
    public class ZawodyWedkarskieContext : DbContext
    {
        public ZawodyWedkarskieContext(DbContextOptions<ZawodyWedkarskieContext> options) : base(options) { }

        public DbSet<Kolo> Kola { get; set; }
        public DbSet<Uzytkownik> Uzytkownicy { get; set; }
        public DbSet<GrandPrix> GrandPrixy { get; set; }
        public DbSet<Stanowisko> Stanowiska { get; set; }
        public DbSet<Wedkarz> Wedkarze { get; set; }
    }
}