
using AirTransferLines.Dall;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTransferLines.Repos.Concrete
{
   public class AirTransferLinesContext:DbContext
    {
        public DbSet<Acente> Acenteler { get; set; }
        public DbSet<Surucu> Suruculer { get; set; }
        public DbSet<Transfer> Transferler { get; set; }
        public DbSet<Rezervasyon> Rezervasyonlar { get; set; }
        public DbSet<Arac> Araclar { get; set; }
        public DbSet<Ulke> Ulkeler { get; set; }
        public DbSet<Sehir> Sehirler { get; set; }
        public DbSet<Dil> Diller { get; set; }
        public DbSet<Uye> Uyeler { get; set; }
    }
}
