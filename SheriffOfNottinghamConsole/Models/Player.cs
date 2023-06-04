using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheriffOfNottinghamConsole.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Gold { get; set; }
        public Apple apples { get; set; }
        public Bread bread { get; set; }
        public Cheese cheese { get; set; }
        public Chicken chickens { get; set; }
        public PlayerColours Colour { get; set; }

        public Player(int id) {
            Id = id;
            Name = "Player" + Id.ToString();
            Colour = (PlayerColours)Id;
            apples = new Apple();
            bread = new Bread();
            cheese = new Cheese();
            chickens= new Chicken();
        }
    }
}
