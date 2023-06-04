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

            // Add a Player
            game.PlayerList.Add(new Player(1));
            Console.WriteLine("Game created. Player Count: {0}", game.PlayerList.Count);
            foreach (Player player in game.PlayerList){
                Console.WriteLine("Player: {0}", player.Id);
            }

        }
    }
}