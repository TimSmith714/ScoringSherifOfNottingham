using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheriffOfNottinghamConsole.Models
{
    public class Chicken : IProduce
    {

        public Chicken()
        {
            Value = 4;
            IsKing = false;
            KingValue = 10;
            IsQueen = false;
            QueenValue = 5;
            Number = 0;
            RoyalNumber = 0;
        }
    }
}
