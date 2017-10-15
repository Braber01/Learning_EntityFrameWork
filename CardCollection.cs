using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnitityFrameWorkReWrite {
    public class CardCollection {
        public ICollection<MagicCard> Spells { get; set; }
        public ICollection<CreatureCard> Creatures { get; set; }
        public ICollection<PlainswalkerCard> Plainswalkers { get; set; }
    }

}
