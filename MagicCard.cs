using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnitityFrameWorkReWrite.EnumsStaticClasses;

namespace EnitityFrameWorkReWrite {
    public class MagicCard {
        private string cardName;
        private string manaCost;
        private int convertedManaCost;
        private Enums.CardType cardType;
        private Enums.CardColor cardColor;
        private Enums.Rareity rareity;

        public int CardID { get; set; }

        protected string CardName { get; set; }

        protected string ManaCost { get; set; }

        protected int ConvertedManaCost {
            get {
                return this.convertedManaCost;
            }
            set {
                int tempValue = manaCost.Length;
                tempValue = value;
            }
        }

        protected Enums.CardColor CardColor { get; set; }

        protected Enums.CardType CardType { get; set; }

        protected Enums.Rareity Rareity { get; set; }

        public MagicCard() {

        }

    }
}
