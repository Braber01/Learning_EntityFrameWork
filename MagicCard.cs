using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnitityFrameWorkReWrite.EnumsStaticClasses;
using System.Numerics;

namespace EnitityFrameWorkReWrite {
    public class MagicCard {
        private string cardName;
        private string manaCost;
        private int convertedManaCost;
        private Enums.CardType cardType;
        private Enums.CardColor cardColor;
        private Enums.Rareity rareity;
        private BigInteger set;
        private BigInteger keyworkds;

        public int CardID { get; set; }

        public string CardName { get; set; }

        public string ManaCost { get; set; }

        public int ConvertedManaCost {
            get {
                return this.convertedManaCost;
            }
            set {
                int tempValue = manaCost.Length;
                tempValue = value;
            }
        }

        public Enums.CardColor CardColor { get; set; }

        public Enums.CardType CardType { get; set; }

        public Enums.Rareity Rareity { get; set; }

        public BigInteger Set { get; set; }

        public BigInteger Keywords { get; set; }

        public MagicCard() {

        }

    }
}
