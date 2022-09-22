namespace Excercise1_Tests;

using Excercise1;
using FluentAssertions;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void Run_NumbersBellow10_ResultIs23()
    {
        // Arrange
        var exercise = new Excercise();

        // Act
        var result = exercise.Run(10);

        // Assert
        result.Should().Be(23);        
    }
}