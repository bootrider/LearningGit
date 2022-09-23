namespace Excercise1_Tests;

using Excercise1;
using FluentAssertions;
using System.Diagnostics;

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

    [TestMethod]
    public void Run_NumberBellow1000_ResultX()
    {
        // Arrange
        var exercise = new Excercise();

        // Act
        var result = exercise.Run(1000);

        // Assert
        result.Should().Be(233168);
    }

    [TestMethod]
    public void Run_SerializedVsParalell()    
    {
        // Arrange
        var exercise = new Excercise();

        // Act
        Stopwatch sw1 = new Stopwatch();
        sw1.Start();
        var result = exercise.Run(100000);
        sw1.Stop();

        Stopwatch sw2 = new Stopwatch();
        sw2.Start();
        var result2 = exercise.RunSerialized(100000);
        sw2.Stop();
        // Assert
        sw1.ElapsedMilliseconds.Should().BeLessThan(sw2.ElapsedMilliseconds);
    }
}