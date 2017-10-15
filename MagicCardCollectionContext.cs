using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnitityFrameWorkReWrite {
    public class MagicCardCollectionContext : DbContext{

        public MagicCardCollectionContext() : base() {

        }

        public DbSet<MagicCard> Spells { get; set; }
        public DbSet<CreatureCard> Creatures { get; set; }
        public DbSet<PlainswalkerCard> Plainswalkers { get; set; }
    }
}
