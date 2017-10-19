using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace EnitityFrameWorkReWrite.EnumsStaticClasses {
    public static class SetEnum {
        public static BigInteger NONE = 0;
        ///<summary>
        /// Alpha (Core Set)
        /// LEA
        /// </summary>
        public static BigInteger LEA = 1 << 0;
        ///<summary>
        /// Beta (Core Set)
        /// LEB
        /// </summary>
        public static BigInteger LEB = 1 << 1;
        ///<summary>
        /// Unlimited Edition (Core Set)
        /// II_ED
        /// </summary>
        public static BigInteger II_ED = 1 << 2;
        ///<summary>
        /// Arabian Nights (Expansion set)
        /// ARN
        /// </summary>
        public static BigInteger ARN = 1 << 3;
        ///<summary>
        /// Antiqueties (Expansion set)
        /// ATQ
        /// </summary>
        public static BigInteger ATQ = 1 << 4;
        ///<summary>
        /// Revised Edition (Core Set)
        /// III_ED
        /// </summary>
        public static BigInteger III_ED = 1 << 5;
        ///<summary>
        /// Legends (Expansion set)
        /// LEG
        /// </summary>
        public static BigInteger LEG = 1 << 6;
        ///<summary>
        /// The Dark (Expansion Set)
        /// DRK
        /// </summary>
        public static BigInteger DRK = 1 << 7;
        ///<summary>
        /// Fallen Empires (Expansion Set)
        /// FEM
        /// </summary>
        public static BigInteger FEM = 1 << 8;
        ///<summary>
        /// 4th Edition (Core Set)
        /// V_ED
        /// </summary>
        public static BigInteger IV_ED = 1 << 9;
        ///<summary>
        /// Ice Age (Expansion Set)
        /// ICE
        /// </summary>
        public static BigInteger ICE = 1 << 10;
        ///<summary>
        /// Chronicles (Compliation Set)
        /// CHR
        /// </summary>
        public static BigInteger CHR = 1 << 11;
        ///<summary>
        /// Renaissance (Compoliation Set)
        /// </summary>
        public static BigInteger RENAISSANCE = 1 << 12;
        ///<summary>
        /// Homelands (Expansion Set)
        /// HML
        /// </summary>
        public static BigInteger HML = 1 << 13;
        ///<summary>
        /// Alliances (Expansion Set)
        /// ALL
        /// </summary>
        public static BigInteger ALL = 1 << 14;
        ///<summary>
        /// Mirage (Expansion set)
        /// MIR
        /// </summary>
        public static BigInteger MIR = 1 << 15;
        ///<summary>
        /// Visions (Expansion set)
        /// VIS
        /// </summary>
        public static BigInteger VIS = 1 << 16;
        ///<summary>
        /// 5th Edition (Core Set)
        /// V_ED
        /// </summary>
        public static BigInteger V_ED = 1 << 17;
        ///<summary>
        /// Portal (Starter Set)
        /// POR
        /// </summary>
        public static BigInteger POR = 1 << 18;
        ///<summary>
        /// Weatherlight (Expansion Set)
        /// WTH
        /// </summary>
        public static BigInteger WTH = 1 << 19;
        ///<summary>
        /// Tempest (Expansion set)
        /// TMP
        /// </summary>
        public static BigInteger TMP = 1 << 20;
        ///<summary>
        /// Stronghold
        /// STH
        /// </summary>
        public static BigInteger STH = 1 << 21;
        ///<summary>
        /// Exodus
        /// EXO
        /// </summary>
        public static BigInteger EXO = 1 << 22;
        ///<summary>
        /// Portal Second Age
        /// P02
        /// </summary>
        public static BigInteger P02 = 1 << 23;
        ///<summary>
        /// Unglued (Un-set)
        /// UGL
        /// </summary>
        public static BigInteger UGL = 1 << 24;
        ///<summary>
        /// Urza's Saga
        /// USG
        /// </summary>
        public static BigInteger USG = 1 << 25;
        ///<summary>
        /// Anthologies
        /// ATH
        /// </summary>
        public static BigInteger ATH = 1 << 26;
        ///<summary>
        /// Urza's Legacy
        /// ULG
        /// </summary>
        public static BigInteger ULG = 1 << 27;
        ///<summary>
        /// 6th Edition
        /// VI_ED
        /// </summary>
        public static BigInteger VI_ED = 1 << 28;
        ///<summary>
        /// Urza's Destiny
        /// UDS
        /// </summary>
        public static BigInteger UDS = 1 << 29;
        ///<summary>
        /// Portal Three Kingdoms
        /// PTK
        /// </summary>
        public static BigInteger PTK = 1 << 30;
        ///<summary>
        /// Starter 1999
        /// S99
        /// </summary>
        public static BigInteger S99 = 1 << 31;
        ///<summary>
        /// Mercdian Masques
        /// MMQ
        /// </summary>
        public static BigInteger MMQ = 1 << 32;
        ///<summary>
        /// Battle Royale
        /// BRB
        /// </summary>
        public static BigInteger BRB = 1 << 33;
        ///<summary>
        /// Nemesis
        /// NEM
        /// </summary>
        public static BigInteger NEM = 1 << 34;
        ///<summary>
        /// Starter 2000
        /// S00
        /// </summary>
        public static BigInteger S00 = 1 << 35;
        ///<summary>
        /// Prophecy
        /// PCY
        /// </summary>
        public static BigInteger PCY = 1 << 36;
        ///<summary>
        /// Invasion
        /// INV
        /// </summary>
        public static BigInteger INV = 1 << 37;
        ///<summary>
        /// Beatdown
        /// BTD
        /// </summary>
        public static BigInteger BTD = 1 << 38;
        ///<summary>
        /// Planeshift
        /// PLS
        /// </summary>
        public static BigInteger PLS = 1 << 39;
        ///<summary>
        /// 7th Edidion
        /// VII_ED
        /// </summary>
        public static BigInteger VII_ED = 1 << 40;
        ///<summary>
        /// Apocalypse
        /// APC
        /// </summary>
        public static BigInteger APC = 1 << 41;
        ///<summary>
        /// Odyssey
        /// ODY
        /// </summary>
        public static BigInteger ODY = 1 << 42;
        ///<summary>
        /// Deckmasters 2001
        /// DKM
        /// </summary>
        public static BigInteger DKM = 1 << 43;
        ///<summary>
        /// Torment
        /// TOR
        /// </summary>
        public static BigInteger TOR = 1 << 44;

        ///<summary>
        /// Judgement
        /// JUD
        /// </summary>
        public static BigInteger JUD = 1 << 45;

        ///<summary>
        /// Onslaught
        /// ONS
        /// </summary>
        public static BigInteger ONS = 1 << 46;

        ///<summary>
        /// Legions
        /// LGN
        /// </summary>
        public static BigInteger LGN = 1 << 47;

        ///<summary>
        /// Scourge
        /// SCG
        /// </summary>
        public static BigInteger SCG = 1 << 48;

        ///<summary>
        /// 8th Edition
        /// VIII_ED
        /// </summary>
        public static BigInteger VIII_ED = 1 << 49;

        ///<summary>
        /// Mirrodin
        /// MRD
        /// </summary>
        public static BigInteger MRD = 1 << 50;

        ///<summary>
        /// Darkseteel
        /// DST
        /// </summary>
        public static BigInteger DST = 1 << 51;

        ///<summary>
        /// Fifth Dawn
        /// V_DN
        /// </summary>
        public static BigInteger V_DN = 1 << 52;

        ///<summary>
        /// Champions of Kamigawa
        /// CHK
        /// </summary>
        public static BigInteger CHK = 1 << 53;

        ///<summary>
        /// Unhinged
        /// UNH
        /// </summary>
        public static BigInteger UNH = 1 << 54;

        ///<summary>
        /// Betrayers of Kamaigawa
        /// BOK
        /// </summary>
        public static BigInteger BOK = 1 << 55;

        ///<summary>
        /// Saviors of Kamigawa
        /// SOK
        /// </summary>
        public static BigInteger SOK = 1 << 56;

        ///<summary>
        /// 9th Edition
        /// IX_ED
        /// </summary>
        public static BigInteger IX_ED = 1 << 57;

        ///<summary>
        /// Ravnica: City of Guilds
        /// RAV
        /// </summary>
        public static BigInteger RAV = 1 << 58;

        ///<summary>
        /// Guildpact
        /// GPT
        /// </summary>
        public static BigInteger GPT = 1 << 59;

        ///<summary>
        /// Dissension
        /// CSP
        /// </summary>
        public static BigInteger CSP = 1 << 60;

        ///<summary>
        /// Time Spiral
        /// TSP
        /// </summary>
        public static BigInteger TSP = 1 << 61;

        ///<summary>
        /// Planar Chaos
        /// PLC
        /// </summary>
        public static BigInteger PLC = 1 << 62;

        ///<summary>
        /// Future Sight
        /// FUT
        /// </summary>
        public static BigInteger FUT = 1 << 63;

        ///<summary>
        /// 10th Edition
        /// X_ED
        /// </summary>
        public static BigInteger X_ED = 1 << 64;

        ///<summary>
        /// Masters Edition
        /// MED
        /// </summary>
        public static BigInteger MED = 1 << 65;

        ///<summary>
        /// Lorwyn
        /// LRW
        /// </summary>
        public static BigInteger LRW = 1 << 66;

        ///<summary>
        /// Duel Ducks: Elves vs. Goblins
        /// EVG
        /// </summary>
        public static BigInteger EVG = 1 << 67;

        ///<summary>
        /// Morningtide
        /// MOR
        /// </summary>
        public static BigInteger MOR = 1 << 68;

        ///<summary>
        /// Shadowmoor
        /// SHM
        /// </summary>
        public static BigInteger SHM = 1 << 69;

        ///<summary>
        /// Eventide
        /// EVE
        /// </summary>
        public static BigInteger EVE = 1 << 70;

        ///<summary>
        /// From the Vault: Dragons
        /// DRB
        /// </summary>
        public static BigInteger DRB = 1 << 71;

        ///<summary>
        /// Masters Edition II
        /// ME2
        /// </summary>
        public static BigInteger ME2 = 1 << 72;

        ///<summary>
        /// Shards of Alara
        /// ALA
        /// </summary>
        public static BigInteger ALA = 1 << 73;

        ///<summary>
        /// Duel Decks: Jace vs Chandra
        /// DD2
        /// </summary>
        public static BigInteger DD2 = 1 << 74;

        ///<summary>
        /// Conflux
        /// CON
        /// </summary>
        public static BigInteger CON = 1 << 75;

        ///<summary>
        /// Duel Decks: Devine vs. Demonic
        /// DDC
        /// </summary>
        public static BigInteger DDC = 1 << 76;

        ///<summary>
        ///Alara Reborn
        /// ARB
        /// </summary>
        public static BigInteger ARB = 1 << 77;

        ///<summary>
        /// Magic 2010
        /// M10
        /// </summary>
        public static BigInteger M10 = 1 << 78;

        ///<summary>
        /// Commander Theme Decks
        /// TD0
        /// </summary>
        public static BigInteger TD0 = 1 << 79;

        ///<summary>
        /// From the Valut: Exiled
        /// V09
        /// </summary>
        public static BigInteger V09 = 1 << 80;

        ///<summary>
        /// Planechase (2009)
        /// HOP
        /// </summary>
        public static BigInteger HOP = 1 << 81;

        ///<summary>
        /// Masters Edition III
        /// ME3
        /// </summary>
        public static BigInteger ME3 = 1 << 82;

        ///<summary>
        /// Zendikar
        /// ZEN
        /// </summary>
        public static BigInteger ZEN = 1 << 83;

        ///<summary>
        /// Duel Decks: Garruk vs. Liliana
        /// DDD
        /// </summary>
        public static BigInteger DDD = 1 << 84;

        ///<summary>
        /// Premium Deck Series: Slivers
        /// H09
        /// </summary>
        public static BigInteger H09 = 1 << 85;

        ///<summary>
        /// Worldwake
        /// WWK
        /// </summary>
        public static BigInteger WWK = 1 << 86;

        ///<summary>
        /// Duel Decks: Phyrexia vs. The Coalition
        /// DDE
        /// </summary>
        public static BigInteger DDE = 1 << 87;

        ///<summary>
        /// Rise of the Eldrazi
        /// ROE
        /// </summary>
        public static BigInteger ROE = 1 << 88;

        ///<summary>
        /// Duels of the Planeswalkers
        /// DPA
        /// </summary>
        public static BigInteger DPA = 1 << 89;

        ///<summary>
        /// Archenemy
        /// ARC
        /// </summary>
        public static BigInteger ARC = 1 << 90;

        ///<summary>
        /// Magi 2011
        /// M11
        /// </summary>
        public static BigInteger M11 = 1 << 91;

        ///<summary>
        /// From the Valut: Relics
        /// V10
        /// </summary>
        public static BigInteger V10 = 1 << 92;

        ///<summary>
        /// Duel Decks: Elspeth vs. Tezzeret
        /// DDF
        /// </summary>
        public static BigInteger DDF = 1 << 93;

        ///<summary>
        /// Scars of Mirrodin
        /// SOM
        /// </summary>
        public static BigInteger SOM = 1 << 94;

        ///<summary>
        /// Premium Deck Series: Fire &amp; Lightning
        /// PD2
        /// </summary>
        public static BigInteger PD2 = 1 << 95;

        ///<summary>
        /// Masters Edition IV
        /// ME4
        /// </summary>
        public static BigInteger ME4 = 1 << 96;

        ///<summary>
        /// Mirrodin Besieged
        /// MBS
        /// </summary>
        public static BigInteger MBS = 1 << 97;

        ///<summary>
        /// Duel Decks: Knights vs. Dragons
        /// DDG
        /// </summary>
        public static BigInteger DDG = 1 << 98;

        ///<summary>
        /// New Phyrexia
        /// NPH
        /// </summary>
        public static BigInteger NPH = 1 << 99;

        ///<summary>
        /// Commander (2011)
        /// CMD
        /// </summary>
        public static BigInteger CMD = 1 << 100;

        ///<summary>
        /// Magic 2012
        /// M12
        /// </summary>
        public static BigInteger M12 = 1 << 101;

        ///<summary>
        /// From the Vault: Legends
        /// V11
        /// </summary>
        public static BigInteger V11 = 1 << 102;

        ///<summary>
        /// Duel Decks Ajani Vs. Nicol Bolas
        /// DDH
        /// </summary>
        public static BigInteger DDH = 1 << 103;

        ///<summary>
        /// Innistrad
        /// ISD
        /// </summary>
        public static BigInteger ISD = 1 << 104;

        ///<summary>
        /// Premium Deck Series: Graveborn
        /// PD3
        /// </summary>
        public static BigInteger PD3 = 1 << 105;

        ///<summary>
        /// Dark Ascension
        /// DKA
        /// </summary>
        public static BigInteger DKA = 1 << 106;

        ///<summary>
        /// Duel Decks: Venser vs. Koth
        /// DDI
        /// </summary>
        public static BigInteger DDI = 1 << 107;

        ///<summary>
        /// Avacyn Restored
        /// AVR
        /// </summary>
        public static BigInteger AVR = 1 << 108;

        ///<summary>
        /// Planchase 2012
        /// PC2
        /// </summary>
        public static BigInteger PC2 = 1 << 109;

        ///<summary>
        /// Magic 2013
        /// M13
        /// </summary>
        public static BigInteger M13 = 1 << 110;

        ///<summary>
        /// From the Vault: Realms
        /// V12
        /// </summary>
        public static BigInteger V12 = 1 << 111;

        ///<summary>
        /// Duel Decks: Izzet vs. Golgari
        /// DDJ
        /// </summary>
        public static BigInteger DDJ = 1 << 112;

        ///<summary>
        /// Return To Ravnica
        /// RTR
        /// </summary>
        public static BigInteger RTR = 1 << 113;

        ///<summary>
        /// Commander's Arsenal
        /// CM1
        /// </summary>
        public static BigInteger CM1 = 1 << 114;

        ///<summary>
        /// Duel Decks: Mirrodin Pure vs. New Phyrexia
        /// TD2
        /// </summary>
        public static BigInteger TD2 = 1 << 115;

        ///<summary>
        /// Gatecrash
        /// GTC
        /// </summary>
        public static BigInteger GTC = 1 << 116;

        ///<summary>
        /// Duel Decks: Sorin vs. Tibalt
        /// DDK
        /// </summary>
        public static BigInteger DDK = 1 << 117;

        ///<summary>
        /// Dragon's Maze
        /// DGM
        /// </summary>
        public static BigInteger DGM = 1 << 118;

        ///<summary>
        /// Modern Masters (2013)
        /// MMA
        /// </summary>
        public static BigInteger MMA = 1 << 119;

        ///<summary>
        /// Magic 2014
        /// M14
        /// </summary>
        public static BigInteger M14 = 1 << 120;

        ///<summary>
        /// From the Vault: Twenty
        /// V13
        /// </summary>
        public static BigInteger V13 = 1 << 121;

        ///<summary>
        /// Duel Decks: Heros vs. Monsters
        /// DDL
        /// </summary>
        public static BigInteger DDL = 1 << 122;

        ///<summary>
        /// Theros
        /// THS
        /// </summary>
        public static BigInteger THS = 1 << 123;

        ///<summary>
        /// Commander 2013
        /// C13
        /// </summary>
        public static BigInteger C13 = 1 << 124;

        ///<summary>
        /// Born of the Gods
        /// BNG
        /// </summary>
        public static BigInteger BNG = 1 << 125;

        ///<summary>
        /// Duel Decks: Jace vs. Vraska
        /// DDM
        /// </summary>
        public static BigInteger DDM = 1 << 126;

        ///<summary>
        /// Journey into Nyx
        /// JOU
        /// </summary>
        public static BigInteger JOU = 1 << 127;

        ///<summary>
        /// Modern Event Deck
        /// MD1
        /// </summary>
        public static BigInteger MD1 = 1 << 128;

        ///<summary>
        /// Conspiracy
        /// CNS
        /// </summary>
        public static BigInteger CNS = 1 << 129;

        ///<summary>
        /// Magic 2015
        /// M15
        /// </summary>
        public static BigInteger M15 = 1 << 130;

        ///<summary>
        /// From the Vault: Annihilation
        /// V14
        /// </summary>
        public static BigInteger V14 = 1 << 131;

        ///<summary>
        /// Duel Decks: Speed vs. Cunning
        /// DDN
        /// </summary>
        public static BigInteger DDN = 1 << 132;

        ///<summary>
        /// Khans of Tarkir
        /// KTK
        /// </summary>
        public static BigInteger KTK = 1 << 133;

        ///<summary>
        /// Commander 2014
        /// C14
        /// </summary>
        public static BigInteger C14 = 1 << 134;

        ///<summary>
        /// Duel Decks Anthology
        /// DD3
        /// </summary>
        public static BigInteger DD3 = 1 << 135;

        ///<summary>
        /// Fate Reforged
        /// FRF
        /// </summary>
        public static BigInteger FRF = 1 << 136;

        ///<summary>
        /// Duel Decks: Elspeth vs. Kiora
        /// DDO
        /// </summary>
        public static BigInteger DDO = 1 << 137;

        ///<summary>
        /// Dragons of Tarkir
        /// DTK
        /// </summary>
        public static BigInteger DTK = 1 << 138;

        ///<summary>
        /// Modern Masters 2015
        /// MM2
        /// </summary>
        public static BigInteger MM2 = 1 << 139;

        ///<summary>
        /// Magic Orgins
        /// ORI
        /// </summary>
        public static BigInteger ORI = 1 << 140;

        ///<summary>
        /// From the Vault: Angels
        /// V15
        /// </summary>
        public static BigInteger V15 = 1 << 141;

        ///<summary>
        /// Duel Decks: Zendikar vs. Eldrazi
        /// DDP
        /// </summary>
        public static BigInteger DDP = 1 << 142;

        ///<summary>
        /// Dattle for Zendikar
        /// BFZ
        /// </summary>
        public static BigInteger BFZ = 1 << 143;

        ///<summary>
        /// Zendikar Expeditions
        /// EXP
        /// </summary>
        public static BigInteger EXP = 1 << 144;

        ///<summary>
        /// Commander 2015
        /// C15
        /// </summary>
        public static BigInteger C15 = 1 << 145;

        ///<summary>
        /// Oath of the Gatewatch
        /// OGW
        /// </summary>
        public static BigInteger OGW = 1 << 146;

        ///<summary>
        /// Duel Decks: Blessed vs. Cursed
        /// DDQ
        /// </summary>
        public static BigInteger DDQ = 1 << 147;

        ///<summary>
        /// Welcome Deck 2016
        /// W16
        /// </summary>
        public static BigInteger W16 = 1 << 148;

        ///<summary>
        /// Shadows over Innistrad
        /// SOI
        /// </summary>
        public static BigInteger SOI = 1 << 149;

        ///<summary>
        /// Eternal Masters
        /// EMA
        /// </summary>
        public static BigInteger EMA = 1 << 150;

        ///<summary>
        /// Eldrich Moon
        /// EMN
        /// </summary>
        public static BigInteger EMN = 1 << 151;

        ///<summary>
        /// From the Vault: Lore
        /// V16
        /// </summary>
        public static BigInteger V16 = 1 << 152;

        ///<summary>
        /// Conspiracy: Take the Crown
        /// CN2
        /// </summary>
        public static BigInteger CN2 = 1 << 153;

        ///<summary>
        /// Duel Decks: Nissa Vs. Ob Nixilis
        /// DDR
        /// </summary>
        public static BigInteger DDR = 1 << 154;

        ///<summary>
        /// Kaladesh
        /// KLD
        /// </summary>
        public static BigInteger KLD = 1 << 155;

        ///<summary>
        /// Kaladesh Inventions
        /// MPS
        /// </summary>
        public static BigInteger MPS = 1 << 156;

        ///<summary>
        /// Commander 2016
        /// C16
        /// </summary>
        public static BigInteger C16 = 1 << 157;

        ///<summary>
        /// Plancechase Anthology
        /// PCA
        /// </summary>
        public static BigInteger PCA = 1 << 158;

        ///<summary>
        /// Aether Revolt
        /// AER
        /// </summary>
        public static BigInteger AER = 1 << 159;

        ///<summary>
        /// Modern masters 2017
        /// MM3
        /// </summary>
        public static BigInteger MM3 = 1 << 160;

        ///<summary>
        /// Duel Decks: Mind vs. Might
        /// DDS
        /// </summary>
        public static BigInteger DDS = 1 << 161;

        ///<summary>
        /// Welcome Deck 2017
        /// W17
        /// </summary>
        public static BigInteger W17 = 1 << 162;

        ///<summary>
        /// Amonkhet
        /// AKH
        /// </summary>
        public static BigInteger AKH = 1 << 163;

        ///<summary>
        /// Commander Anthology
        /// CMA
        /// </summary>
        public static BigInteger CMA = 1 << 164;

        ///<summary>
        /// Archenemy: Nicol Bolas
        /// E01
        /// </summary>
        public static BigInteger E01 = 1 << 165;

        ///<summary>
        /// Hour of Devastation
        /// HOU
        /// </summary>
        public static BigInteger HOU = 1 << 166;

        ///<summary>
        /// Commander 2017
        /// C17
        /// </summary>
        public static BigInteger C17 = 1 << 167;

        ///<summary>
        /// Ixalan
        /// XLN
        /// </summary>
        public static BigInteger XLN = 1 << 168;

        ///<summary>
        /// Duel Decks: Merfolk vs Goblins
        /// DDT
        /// </summary>
        public static BigInteger DDT = 1 << 169;

        ///<summary>
        /// Iconic Masters
        /// IMA
        /// </summary>
        public static BigInteger IMA = 1 << 170;

        ///<summary>
        /// Explorers of Ixalan
        /// E02
        /// </summary>
        public static BigInteger E02 = 1 << 171;

        ///<summary>
        /// From the Vault: Transform
        /// V17
        /// </summary>
        public static BigInteger V17 = 1 << 172;

        ///<summary>
        /// Unstable
        /// UST
        /// </summary>
        public static BigInteger UNT = 1 << 173;

        ///<summary>
        /// Rivals of Ixalian
        /// RIX
        /// </summary>
        public static BigInteger RIX = 1 << 174;

        ///<summary>
        /// Masters 205
        /// A25
        /// </summary>
        public static BigInteger A25 = 1 << 175;

        ///<summary>
        /// Dominaria
        /// DOM
        /// </summary>
        public static BigInteger DOM = 1 << 176;

        ///<summary>
        /// Core 2019
        /// M19
        /// </summary>
        public static BigInteger M19 = 1 << 177;


    }
}
