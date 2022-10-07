using Microsoft.VisualStudio.TestPlatform.TestHost;
using Ejercicio5Euler;

namespace testExercise5
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void numDivisibleForAll_given1and10_return2520() //nombreMethod,condiciones,resultado esperado
        {          
            // Arrange
            var exercise = new Ejercicio5Euler.Program();

            // Act
            var result = exercise.numDivisibleForAll(1,10);

            // Assert
            // result.Should().Be(2520);
            Assert.AreEqual(2520, result);
            
        }

        [TestMethod]
        public void numDivisibleForAll_given1and20_returnX() //nombreMethod,condiciones,resultado esperado
        {
            // Arrange
            var exercise = new Ejercicio5Euler.Program();

            // Act
            var result = exercise.numDivisibleForAll(1, 20);

            // Assert
            Assert.AreEqual(232792560, result);

        }
    }
}