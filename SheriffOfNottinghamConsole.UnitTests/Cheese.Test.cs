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
    class CheeseCreate
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void CreateCheese()
        {
            // Arrange
            var newCheese = new Cheese();

            // Act
            // Not actualy going to do anything here as just checking the class constructor

            // Asset
            Assert.AreEqual(3, newCheese.Value);
        }

        [Test]
        public void CheeseScoreNoTitle()
        {
            // Arrange
            var newCheese = new Cheese();

            // Act
            // This time set add a value
            newCheese.Number = 5;

            // Assert
            // Check the score
            Assert.That(newCheese.ProduceScore(), Is.EqualTo(15));
        }

        [Test]
        public void CheeseScoreQueen()
        {
            // Arrange
            var newCheese = new Cheese();

            // Act
            // Set a number and Queen status
            newCheese.Number = 5;
            newCheese.IsQueen = true;

            // Assert
            Assert.That(newCheese.ProduceScore(), Is.EqualTo(25));
        }

        [Test]
        public void CheeseScoreKing()
        {
            // Arrange
            var newCheese = new Cheese();
            // Act
            // Set a number and King Status
            newCheese.Number = 5;
            newCheese.IsKing = true;
            // Assert
            Assert.That(newCheese.ProduceScore(), Is.EqualTo(30));
        }

    }
}
