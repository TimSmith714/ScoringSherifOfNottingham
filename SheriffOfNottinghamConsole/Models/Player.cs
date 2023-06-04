using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheriffOfNottinghamConsole.Models
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        public Apple apples { get; set; }
        public Bread bread { get; set; }
        public Cheese cheese { get; set; }
        public Chicken chickens { get; set; }
        public PlayerColours PlayerColour { get; set; }

        public Player(int Id) {
            PlayerId = Id;
            PlayerName = "Player" + PlayerId.ToString();
            PlayerColour = (PlayerColours)PlayerId;
            apples = new Apple();
            bread = new Bread();
            cheese = new Cheese();
            chickens= new Chicken();
        }
    }
}
