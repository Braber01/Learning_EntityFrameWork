using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using EnitityFrameWorkReWrite.EnumsStaticClasses;

namespace EnitityFrameWorkReWrite {
    public class CreatureCard : MagicCard {
        private byte power;
        private byte toughness;
        private BigInteger creatureTypes;

        public byte Power { get; set; }
        public byte Toughness { get; set; }
        public BigInteger CreatureTypes { get; set; }

        public ICollection<BigInteger> Sets { get; set; }

        public CreatureCard() : base() {

        }

    }
}
