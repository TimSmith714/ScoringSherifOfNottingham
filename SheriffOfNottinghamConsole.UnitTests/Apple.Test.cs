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
    class AppleCreate
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void CreateApple()
        {
            // Arrange
            var newApple = new Apple();

            // Act
            // Not actualy going to do anything here as just checking the class constructor

            // Asset
            Assert.AreEqual(2, newApple.Value);
        }

        [Test]
        public void AppleScoreNoTitle()
        {
            // Arrange
            var newApple = new Apple();

            // Act
            // This time set add a value
            newApple.Number = 5;

            // Assert
            // Check the score
            Assert.That(newApple.ProduceScore(), Is.EqualTo(10));
        }

        [Test]
        public void AppleScoreQueen()
        {
            // Arrange
            var newApple = new Apple();

            // Act
            // Set a number and Queen status
            newApple.Number = 5;
            newApple.IsQueen = true;

            // Assert
            Assert.That(newApple.ProduceScore(), Is.EqualTo(20));
        }

        [Test]
        public void AppleScoreKing()
        {
            // Arrange
            var newApple = new Apple();
            // Act
            // Set a number and King Status
            newApple.Number = 5;
            newApple.IsKing = true;
            // Assert
            Assert.That(newApple.ProduceScore(), Is.EqualTo(30));
        }

    }
}
