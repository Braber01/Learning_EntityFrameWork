using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnitityFrameWorkReWrite.EnumsStaticClasses {

    /**
     * <summary>
     * A class that repesents all the simple enums
     * </summary>
     */
    public class Enums{

        /// <summary>
        /// Repesents a Type of magic Card
        /// </summary>
        /// <remarks>
        ///There is a such thing as flip, and split cards
        /// </remarks>
        [Flags]
        public enum CardType {
            NONE = 0, //0 | 0b0
            ARTIFACT = 1 << 0, //1 | 0b1
            CREATURE = 1 << 1,//2 | 0b10
            INSTANT = 1 << 2,//4 | 0b100
            LAND = 1 << 3,//8 | 0b1000
            PLAINSWALKER = 1 << 4,//16 | 0b1_0000
            SORCERY = 1 << 5 //32 | 0b10_0000
        }

        [Flags]
        public enum CardColor {
            NONE = 0,
            WHITE = 1 << 0,
            BLUE = 1 << 1,
            BLACK = 1 << 2,
            RED = 1 << 3,
            GREEN = 1 << 4,
            /// <summary>
            /// White | Blue
            /// </summary>
            AZORIUS = WHITE | BLUE,
            /// <summary>
            /// Blue | Black
            /// </summary>
            DIMIR = BLUE | BLACK,
            /// <summary>
            /// Black | Red
            /// </summary>
            RAKDOS = BLACK | RED,
            /// <summary>
            /// RED | Green
            /// </summary>
            GRUUL = RED | GREEN,
            /// <summary>
            /// White | Black
            /// </summary>
            ORZHOV = WHITE | BLACK,
            /// <summary>
            /// Blue | Red
            /// </summary>
            IZZET = BLUE | RED,
            /// <summary>
            /// Black | Green
            /// </summary>
            GOLGARI = BLACK | GREEN,
            /// <summary>
            /// Red | White
            /// </summary>
            BOROS = RED | WHITE,
            /// <summary>
            /// Green | Blue
            /// </summary>
            SIMIC = GREEN | BLUE,
            //three color shards
            JUND = RED | GREEN | BLACK,
            BANT = WHITE | GREEN | BLUE,
            GRIXIS = BLACK | RED | BLUE,
            NAYA = GREEN | WHITE | RED,
            ESPER = BLUE | WHITE | BLACK,
            //Three color wedges
            JESKAI = BLUE | RED | WHITE,
            MARDU = RED | WHITE | BLACK,
            SULTAI = BLACK | GREEN | BLUE,
            TEMUR = GREEN | BLUE | RED,
            ABZAN = WHITE | BLACK | GREEN,
            //Four color decks
            ARTIFICE = WHITE | BLUE | BLACK | RED,
            CHAOS = BLUE | BLACK |RED | GREEN,
            AGGRESSION = BLACK | RED | GREEN | WHITE,
            ALTRUISM = RED | GREEN | WHITE | BLUE,
            GROWTH = GREEN | WHITE | BLUE | BLACK,
            //Five color deck
            STARBURST = WHITE | BLUE | BLACK | RED | GREEN
        }

        [Flags]
        public enum LegalIn {
            NONE = 0,
            BLOCK = 1 << 0,
            STANDARD = 1 << 1,
            MODERN = 1 << 2,
            LEGACY = 1 << 3,
            VINTAGE = 1 << 4,
            COMMANDER = 1 << 5
        }

        public enum PlainswalkerSubtypes {
            NONE = 0,
            AJANI,
            ASHIOK,
            CHANDRA,
            DACK,
            DOMRI,
            ELSPETH,
            GARRUK,
            GIDEON,
            JACE,
            KARN,
            KIORA,
            KOTH,
            LILIANA,
            NARSET,
            BOLAS,
            NISSA,
            NIXLIS,
            RAL,
            SARKHAN,
            SORIN,
            TAMIYO,
            TEZZERT,
            TIBALT,
            UGIN,
            VENSER,
            VRASKA,
            XENAGOS
        }

        public enum ArtifactSubtypes {
            NONE = 0,
            CLUE,
            CONTRAPTION,
            EQUIPMENT,
            FORTIFACATION,
            VEHICLE
        }

        public enum EnchantmentSubtypes {
            NONE = 0,
            AURA,
            CURSE,
            CARTOUCHE,
            SHRINE
        }

        public enum Rareity {
            OTHER = 0,
            COMMON,
            UNCOMMON,
            RARE,
            MYTHIC
        }

    }
}
