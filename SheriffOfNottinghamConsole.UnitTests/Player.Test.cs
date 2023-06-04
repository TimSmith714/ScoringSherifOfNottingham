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
        public void CreatePlayer()
        {
            // Arrange
            var newPlayer = new Player(1);

            // Act
            // Not actualy going to do anything here as just checking the class constructor

            // Asset
            Assert.That(newPlayer.Name, Is.EqualTo("Player1"));
            Assert.That(((int)newPlayer.Colour), Is.EqualTo(1));
        }

        [Test]


    }
}
