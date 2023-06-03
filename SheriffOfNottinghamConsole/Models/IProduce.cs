using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheriffOfNottinghamConsole.Models
{
    public class IProduce
    {
        // The gold value per item of produce
        public int Value { get; set; }
        public bool IsKing { get; set; }
        public int KingValue { get; set; }
        public int QueenValue { get; set; }
        public bool IsQueen { get; set; }
        // The number of items the player has
        public int Number { get; set; }
        // The number of royal items
        // These are handled separately because they do not count towards the
        // ProduceScore only the calculation for Title
        public int RoyalNumber { get; set; }

        // The Score from the title
        public int TitleScore()
        {
            if (IsKing)
                return KingValue;
            if (IsQueen)
                return QueenValue;
            return 0;
        }

        public int ProduceScore()
        {
            int produceValue = Value * Number;
            return produceValue + TitleScore();
        }
    }

}
