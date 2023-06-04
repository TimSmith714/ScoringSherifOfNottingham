using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheriffOfNottinghamConsole.Models
{
    public class Apple : IProduce
    {

        public Apple()
        {
            Value = 2;
            IsKing = false;
            KingValue = 20;
            IsQueen = false;
            QueenValue = 10;
            Number = 0;
            RoyalNumber = 0;
        }
    }
}
