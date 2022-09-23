using ConsoleApp;
namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsPalindrome_Given1_ReturnTrue()
        {
            // Arrange
            var excersise = new Excercise();

            // Act
            var res = excersise.IsPalindrome(1);

            // Assert
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void IsPalindrome_Given11_ReturnTrue()
        {
            // Arrange
            var excersise = new Excercise();

            // Act
            var res = excersise.IsPalindrome(11);

            // Assert
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void IsPalindrome_Given454_ReturnTrue()
        {
            // Arrange
            var excersise = new Excercise();

            // Act
            var res = excersise.IsPalindrome(454);

            // Assert
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void IsPalindrome_GivenMinus1_ThrowException()
        {
            // Arrange
            var excersise = new Excercise();

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => excersise.IsPalindrome(-1));
        }

        [TestMethod]
        public void Run_TwoInteger_Palindrome()
        {
            // Arrange
            var excersise = new Excercise();

            // Act
            var res = excersise.Run(2);

            // Assert
            Assert.AreEqual(9009, res);
        }

    }
}