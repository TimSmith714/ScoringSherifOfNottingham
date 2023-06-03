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
        }
    }
}