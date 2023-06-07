using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SheriffOfNottinghamConsole;
using NUnit.Framework;
using SheriffOfNottinghamConsole.Models;

namespace SheriffOfNottinghamConsole
{
    [TestFixture]
    class GameCreate
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void CreateGame()
        {
            // Arrange
            var newGame = new Game();

            // Act
            // Not actualy going to do anything here as just checking the class constructor

            // Assert
            Assert.That(newGame.PlayerList.Count, Is.EqualTo(0));

        }

        [Test]
        public void CreateGamePlayer()
        {
            // Arrange
            // So I'll need to create a game instance
            var game = new Game();
            // Add a Game
            game.AddPlayer();

            //Act
            // Leave as is to get the first Game

            // Assert
            Assert.That(game.PlayerList.Count, Is.EqualTo(1));
        }

        [Test]
        public void CreateGameWith2Players()
        {
            // Arrange
            // So I'll need to create a game instance
            var game = new Game();
            // Add a Game
            game.AddPlayer();
            game.AddPlayer();

            //Act
            // Leave as is to get the first Game

            // Assert
            Assert.That(game.PlayerList.Count, Is.EqualTo(2));
        }

        [Test]
        public void CreateGameWithNamedPlayer()
        {
            // Arrange
            var game = new Game();

            // Act - Add a player
            game.AddPlayer("Peter");

            // Assert
            Assert.That(game.PlayerList[0].Name, Is.EqualTo("Peter"));
        }

        [Test]
        public void CreateGameWithNamedPlayerColourChoice()
        {
            // Arrange
            var game = new Game();

            // Act - Add a player with custom colour
            game.AddPlayer("Peter", 3);

            // Assert
            Assert.That(game.PlayerList[0].Colour, Is.EqualTo(PlayerColours.Yellow));    
        }

        [Test]
        public void GetAvailableColoursAll()
        {
            // Arrange 
            var game = new Game();
            // Act
            // Nothing to do here as not going to assign any colours yet
            // Assert
            var availableColours = game.GetAvailableColours();
            Assert.That(availableColours.Count, Is.EqualTo(6));
        }

        [Test]
        public void GetAvailableColoursTwoAssigned()
        {
            // Arrange 
            var game = new Game();
            // Act
            // This time add a couple of players to assign some colours
            game.AddPlayer();
            game.AddPlayer();
            // Assert
            var availableColours = game.GetAvailableColours();
            Assert.That(availableColours.Count, Is.EqualTo(4));
        }

        [Test]
        public void CreatePlayersWithColourCollision()
        {
            // Arrange
            var game = new Game();

            // Act
            // Add a Player with Blue (colour 1)
            game.AddPlayer("BluePlayer", 1);
            // Add a default colour player (The playerId will be 1 so also blue)
            game.AddPlayer("GreenPlayer");

            Assert.That(game.PlayerList[0].Colour, Is.Not.EqualTo(game.PlayerList[1].Colour));


        }


    }
}
