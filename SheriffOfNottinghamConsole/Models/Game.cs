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

        public Game()
        {
            PlayerList = new List<Player>();
        }

        public void ListPlayers()
        {
            Console.WriteLine("================================");
            Console.WriteLine("Game created. Player Count: {0}", PlayerList.Count);
            foreach (Player player in PlayerList)
            {
                Console.WriteLine("Player: {0}, Name: {1}", player.Id, player.Name);
                Console.WriteLine("Player Colour: {0}", player.Colour.ToString());
            }
            Console.WriteLine("================================");
        }

        public int PlayerCount()
        {
            return PlayerList.Count;
        }

        // I want the code to add players here
        public void AddPlayer()
        {
            PlayerList.Add(new Player(PlayerCount()));
        }

        // Add a player with a defined name
        public void AddPlayer(string playerName)
        {
            PlayerList.Add(new Player(PlayerCount(), playerName));
        }

        // Add a player with a defined name and colour
        public int AddPlayer(string playerName, int colour)
        {
            // Check here to make sure the 
            int colourCount = PlayerList.Where(x => x.Colour == (PlayerColours)colour).Count();
            if (colourCount > 0) { return 0; }

            PlayerList.Add(new Player(PlayerCount(), playerName, (PlayerColours)colour));
            return 1;
        }

        public List<PlayerColours> GetAvailableColours()
        {
            var availableColours = new List<PlayerColours>();

            foreach (int i in Enum.GetValues(typeof(PlayerColours)))
            {
                availableColours.Add((PlayerColours)i);
            }

            foreach(Player player in PlayerList)
            {
                availableColours.Remove((PlayerColours)player.Colour);
            }
            return availableColours;
        }

        public void ListAvailableColours()
        {
            var availableColours = GetAvailableColours();
            Console.WriteLine("Available Colours:");
            foreach(PlayerColours colour in availableColours)
            {
                Console.Write("{0}, ",colour.ToString());
            }
            Console.WriteLine("===");
        }

        // Work out King/Queen
        public void SetTitle(string title, string produce)
        {
            throw new NotImplementedException();

        }

    }
}
