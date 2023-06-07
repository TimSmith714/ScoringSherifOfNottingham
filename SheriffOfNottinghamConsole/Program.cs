using SheriffOfNottinghamConsole.Models;

namespace SheriffOfNottinghamConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting setup!");
            var game = new Game();
            Console.WriteLine("Game created. Player Count: {0}", game.PlayerList.Count);
            game.ListAvailableColours();

            game.AddPlayer("BluePlayer", 0);
            // Add a default colour player (0:Green)
            game.AddPlayer("GreenPlayer", 1);
            // add a default colour player the would be blue
            game.AddPlayer("TealPlayer");

            game.ListPlayers();
            game.ListAvailableColours();
        }

        
    }
}