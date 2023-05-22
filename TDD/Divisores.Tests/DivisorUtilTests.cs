namespace Divisores.Tests
{
    [TestClass]
    public class DivisorUtilTests
    {
        [TestMethod]
        public void IsDividedBy_Given4and2_ReturnTrue()
        {
            // Arrange
            var util = new DivisorUtil();

            // Act
            var result = util.IsDividedBy(4, 2);

            // Assert
            Assert.IsTrue(result, null);
        }

        [TestMethod]
        public void IsDividedBy_Given5and2_ReturnTrue()
        {
            // Arrange
            var util = new DivisorUtil();

            // Act
            var result = util.IsDividedBy(5, 2);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsDividedBy_GivenAIsLessThanB_ReturnException()
        {
            // Arrange
            var util = new DivisorUtil();

            // Act
            // Assert
            Assert.ThrowsException<Exception>(() => util.IsDividedBy(2, 4));
        }

        [TestMethod]
        public void IsDividedBy_GivenBAs0_ReturnAgumentException()
        {
            // Arrange
            var util = new DivisorUtil();

            // Act
            // Assert
            Assert.ThrowsException<ArgumentException>(() => util.IsDividedBy(2, 0));
        }
    }
}