using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Kørselsbidrag;

namespace Kørselsbidrag
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void Test20Km()
        {
            // Arrange
            Logic logic = new Logic();
            logic.kmPerDag = 20;
            logic.broType = 0;

            // Act
            double result = logic.Output();

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Test25Km()
        {
            // Arrange
            Logic logic = new Logic();
            logic.kmPerDag = 25;
            logic.broType = 0;

            // Act
            double result = logic.Output();

            // Assert
            Assert.AreEqual(2.16, result);
        }
        [TestMethod]
        public void TestMinus50Km()
        {
            // Arrange
            Logic logic = new Logic();
            logic.kmPerDag = -50;
            logic.broType = 0;

            // Act
            double result = logic.Output();

            // Assert
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void Test100Km()
        {
            // Arrange
            Logic logic = new Logic();
            logic.kmPerDag = 100;
            logic.broType = 0;

            // Act
            double result = logic.Output();

            // Assert
            Assert.AreEqual(164, 16, result);
        }
        [TestMethod]
        public void Test120Km()
        {
            // Arrange
            Logic logic = new Logic();
            logic.kmPerDag = 120;
            logic.broType = 0;

            // Act
            double result = logic.Output();

            // Assert
            Assert.AreEqual(207,36, result);
        }
        [TestMethod]
        public void Test200Km()
        {
            // Arrange
            Logic logic = new Logic();
            logic.kmPerDag = 200;
            logic.broType = 0;

            // Act
            double result = logic.Output();

            // Assert
            Assert.AreEqual(293.76, result);
        }
    }
}
