using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheriffOfNottinghamConsole.Models
{
    public class Bread : IProduce
    {

        public Bread()
        {
            Value = 3;
            IsKing = false;
            KingValue = 15;
            IsQueen = false;
            QueenValue = 10;
            Number = 0;
            RoyalNumber = 0;
        }
    }
}
