using Microsoft.EntityFrameworkCore;
using ZawodyWedkarskie.API.Models;

namespace ZawodyWedkarskie.API.Data
{
    public class ZawodyWedkarskieContext : DbContext
    {
        public ZawodyWedkarskieContext(DbContextOptions<ZawodyWedkarskieContext> options) : base(options) { }

        public DbSet<GrandPrix> GrandPrixy { get; set; }
        public DbSet<Kolo> Kola { get; set; }
        public DbSet<SlownikGatunekRyby> SlownikGatunkiRyb { get; set; }
        public DbSet<SlownikLowisko> SlownikLowiska { get; set; }
        public DbSet<SlownikNagroda> SlownikNagrody { get; set; }
        public DbSet<SlownikRodzajZawodow> SlownikRodzajeZawodow { get; set; }
        public DbSet<SlownikStanowisko> SlownikStanowiska { get; set; }
        public DbSet<Uzytkownik> Uzytkownicy { get; set; }
        public DbSet<UzytkownikUprawnienie> UzytkownikyUprawnienia { get; set; }
        public DbSet<Wedkarz> Wedkarze { get; set; }
        public DbSet<Zawody> Zawody { get; set; }
        public DbSet<Zdjecie> Zdjecia { get; set; }
    }
}