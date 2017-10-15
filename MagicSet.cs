using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnitityFrameWorkReWrite {
    public class MagicSet {

        private string name;
        private string setCode;
        private int totalCards;
        private int commonCards;
        private int uncommonCards;
        private int rareCards;
        private int? mythicRareCards;
        private int? otherCards;
        private DateTime? releaseDate;

        public string Name { get; set; }
        public string SetCode { get; set; }
        public int CommonCards { get; set; }
        public int UncommonCards { get; set; }
        public int RareCards { get; set; }
        public int MythicRareCards { get; set; }
        public int OtherCards { get; set; }
        public int TotalCards {
            get {
                return (CommonCards + UncommonCards + RareCards + MythicRareCards + OtherCards);
            }
        }

        public MagicSet(string name,string setCode,
            int commonCards,int uncommonCards, int rareCards,int? mythicRareCards,int? otherCards,DateTime? releaseDate) {
            this.name = name;
            this.setCode = setCode;
            this.commonCards = commonCards;
            this.uncommonCards = uncommonCards;
            this.rareCards = rareCards;
            if(mythicRareCards == null) {
                this.mythicRareCards = 0;
            }
            if(this.otherCards == null) {
                this.otherCards = 0;
            }
            if (this.releaseDate == null) {
                //override to string to show that release date is unknown
                Console.WriteLine("Release Date Unknown");
            }
            this.totalCards = TotalCards;
        }
    }
}
