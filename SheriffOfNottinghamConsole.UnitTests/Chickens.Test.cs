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
    class ChickenCreate
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void CreateChicken()
        {
            // Arrange
            var newChicken = new Chicken();

            // Act
            // Not actualy going to do anything here as just checking the class constructor

            // Asset
            Assert.AreEqual(4, newChicken.Value);
        }

        [Test]
        public void ChickenScoreNoTitle()
        {
            // Arrange
            var newChicken = new Chicken();

            // Act
            // This time set add a value
            newChicken.Number = 5;

            // Assert
            // Check the score
            Assert.That(newChicken.ProduceScore(), Is.EqualTo(20));
        }

        [Test]
        public void ChickenScoreQueen()
        {
            // Arrange
            var newChicken = new Chicken();

            // Act
            // Set a number and Queen status
            newChicken.Number = 5;
            newChicken.IsQueen = true;

            // Assert
            Assert.That(newChicken.ProduceScore(), Is.EqualTo(25));
        }

        [Test]
        public void ChickenScoreKing()
        {
            // Arrange
            var newChicken = new Chicken();
            // Act
            // Set a number and King Status
            newChicken.Number = 5;
            newChicken.IsKing = true;
            // Assert
            Assert.That(newChicken.ProduceScore(), Is.EqualTo(30));
        }

    }
}
