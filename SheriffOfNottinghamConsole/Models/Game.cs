using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheriffOfNottinghamConsole.Models
{
    public class Game
    {
        public List<Player> PlayerList { get; set; }

        public Game() {
        PlayerList= new List<Player>();
        }


    }
}
