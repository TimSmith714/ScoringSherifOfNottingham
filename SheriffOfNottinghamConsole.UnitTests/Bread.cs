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
    class BreadCreate
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void CreateBread()
        {
            // Arrange
            var newBread = new Bread();

            // Act
            // Not actualy going to do anything here as just checking the class constructor

            // Asset
            Assert.AreEqual(3, newBread.Value);
        }

        [Test]
        public void BreadScoreNoTitle()
        {
            // Arrange
            var newBread = new Bread();

            // Act
            // This time set add a value
            newBread.Number = 5;

            // Assert
            // Check the score
            Assert.That(newBread.ProduceScore(), Is.EqualTo(15));
        }

        [Test]
        public void BreadScoreQueen()
        {
            // Arrange
            var newBread = new Bread();

            // Act
            // Set a number and Queen status
            newBread.Number = 5;
            newBread.IsQueen = true;

            // Assert
            Assert.That(newBread.ProduceScore(), Is.EqualTo(25));
        }

        [Test]
        public void BreadScoreKing()
        {
            // Arrange
            var newBread = new Bread();
            // Act
            // Set a number and King Status
            newBread.Number = 5;
            newBread.IsKing = true;
            // Assert
            Assert.That(newBread.ProduceScore(), Is.EqualTo(30));
        }

    }
}
