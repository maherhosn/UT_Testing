using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.GameEngine
{
    [TestFixture]
    public class HelperEngineUnitTests
    {
        [Test]
        public void RollDice_Roll_1_Dice_10_Should_Pass()
        {
            // Arrange
            var Roll = 1;
            var Dice = 10;
            var Expected = 1;

            // Act
            var Actual = Crawl.GameEngine.HelperEngine.RollDice(Roll, Dice);

            // Assert "Actual value is greater than or equal to 1
            Assert.GreaterOrEqual(Actual, Expected, TestContext.CurrentContext.Test.Name);
        }
        [Test]
        public void RollDice_Roll_2_Dice_10_Should_Pass()
        {
            // Arrange
            var Roll = 2;
            var Dice = 10;
            var Expected = 1;

            // Act
            var Actual = Crawl.GameEngine.HelperEngine.RollDice(Roll, Dice);

            // Assert "Actual value is greater than or equal to 1
            Assert.GreaterOrEqual(Actual, Expected, TestContext.CurrentContext.Test.Name);
        }
        [Test]
        public void RollDice_Roll_0_Dice_10_Should_Pass()
        {
            // Arrange
            var Roll = 0;
            var Dice = 10;
            var Expected = 0;

            // Act
            var Actual = Crawl.GameEngine.HelperEngine.RollDice(Roll, Dice);

            // Assert that return value is 0 with unsupported Roll or Dic values
            Assert.AreEqual(Expected, Actual, TestContext.CurrentContext.Test.Name);
        }
        [Test]
        public void RollDice_Roll_Neg1_Dice_10_Should_Fail()
        {
            // Arrange
            var Roll = -1;
            var Dice = 10;
            var Expected = 0;

            // Act
            var Actual = Crawl.GameEngine.HelperEngine.RollDice(Roll, Dice);

            // Assert that return value is 0 with unsupported Roll or Dic values
            Assert.AreEqual(Expected, Actual, TestContext.CurrentContext.Test.Name);
        }

        [Test]
        public void RollDice_Roll_1_Dice_Neg1_Should_Fail()
        {
            // Arrange
            var Roll = 1;
            var Dice = -1;
            var Expected = 0;

            // Act
            var Actual = Crawl.GameEngine.HelperEngine.RollDice(Roll, Dice);

            // Assert that return value is 0 with unsupported Roll or Dic values
            Assert.AreEqual(Expected, Actual, TestContext.CurrentContext.Test.Name);
        }
        [Test]
        public void RollDice_Roll_1_Dice_Zero_Should_Fail()
        {
            // Arrange
            var Roll = 1;
            var Dice = 0;
            var Expected = 0;

            // Act
            var Actual = Crawl.GameEngine.HelperEngine.RollDice(Roll, Dice);

            // Assert that return value is 0 with unsupported Roll or Dic values
            Assert.AreEqual(Expected, Actual, TestContext.CurrentContext.Test.Name);
        }

        [Test]
        public void RollDice_Roll_1_Dice_10_Fixed_5_Should_Return_5()
        {
            // Arrange
            var Roll = 1;
            var Dice = 10;
            var Expected = 5;

            //Force Expected Value of 5
            Crawl.Models.GameGlobals.SetForcedRandomNumbersValue(Expected);

            // Act
            var Actual = Crawl.GameEngine.HelperEngine.RollDice(Roll, Dice);

            // Reset
            Crawl.Models.GameGlobals.DisableRandomValues();

            // Assert "Actual value is greater than or equal to 1
            Assert.AreEqual(Expected, Actual, TestContext.CurrentContext.Test.Name);
        }

    }
}
