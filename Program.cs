using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnitityFrameWorkReWrite.EnumsStaticClasses;
using System.Numerics;

namespace EnitityFrameWorkReWrite {
    class Program {
        static void Main(string[] args) {

            using (var ctx = new MagicCardCollectionContext()) {
                PlainswalkerCard Ajani_Caller_of_the_Pride = new PlainswalkerCard {
                    CardName = "Ajani, Caller of the Pride",
                    CardColor = Enums.CardColor.WHITE,
                    CardType = Enums.CardType.PLAINSWALKER,
                    ManaCost = "1WW",
                    ConvertedManaCost = 3,
                    Loyatly = 4,
                    //Set = SetEnum.M13,
                    Rareity = Enums.Rareity.MYTHIC
                };

                PlainswalkerCard Chandra_the_Firebrand = new PlainswalkerCard {
                    CardName = "Chandra, the Firebrand",
                    CardColor = Enums.CardColor.RED,
                    ManaCost = "3R",
                    ConvertedManaCost = 4,
                    CardType = Enums.CardType.PLAINSWALKER,
                    //Set = SetEnum.M13,
                    Loyatly = 3,
                    Rareity = Enums.Rareity.MYTHIC
                };
                PlainswalkerCard Vraska_the_Unseen = new PlainswalkerCard {
                    CardName = "Vraska the Unseen",
                    CardColor = Enums.CardColor.GOLGARI, //Enums.CardColor.BLACK | Enums.CardColor.GREEN
                    Loyatly = 5,
                    //Set = SetEnum.RTR,
                    ManaCost = "3BG",
                    ConvertedManaCost = 5,
                    Rareity = Enums.Rareity.MYTHIC
                };

                CreatureCard Agadeem_Occultist = new CreatureCard {
                    CardName = "Agadeem Occultist",
                    CardColor = Enums.CardColor.BLACK,
                    ManaCost = "2B",
                    ConvertedManaCost = 3,
                    Set = SetEnum.WWK,
                    Power = 0,
                    Toughness = 2,
                    Rareity = Enums.Rareity.RARE,
                    CreatureTypes = CreatureSubtypes.HUMAN | CreatureSubtypes.SHAMAN | CreatureSubtypes.ALLY
                };


            }

        }
    }
}
