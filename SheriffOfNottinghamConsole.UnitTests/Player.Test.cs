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
    class PlayerCreate
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void CreatePlayerWithId()
        {
            // Arrange
            var newPlayer = new Player(1);

            // Act
            // Not actualy going to do anything here as just checking the class constructor

            // Assert
            Assert.That(newPlayer.Name, Is.EqualTo("Player1"));
            Assert.That(((int)newPlayer.Colour), Is.EqualTo(1));
        }

        [Test]
        public void CreatePlayer()
        {
            // Arrange
            // So I'll need to create a game instance
            var game = new Game();
            // Add a Player
            game.PlayerList.Add(new Player(1));

            //Act
            // Leave as is to get the first player

            // Assert
            Assert.That(game.PlayerList.Count, Is.EqualTo(1));
            Assert.That(game.PlayerList[0].Name, Is.EqualTo("Player1"));
            Assert.That(game.PlayerList[0].Colour, Is.EqualTo(PlayerColours.Blue));
        }

        [Test]
        public void CreateNamedPlayer()
        {
            // Arrange
            // So I'll need to create a game instance
            var game = new Game();
            // Add a Player
            game.PlayerList.Add(new Player(1, "Victor"));

            //Act
            // Leave as is to get the first player

            // Assert
            Assert.That(game.PlayerList.Count, Is.EqualTo(1));
            Assert.That(game.PlayerList[0].Name, Is.EqualTo("Victor"));
            Assert.That(game.PlayerList[0].Colour, Is.EqualTo(PlayerColours.Blue));
        }


    }
}
