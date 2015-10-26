using System;
using FizzBuzz.Console;
using FluentAssertions;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzInputTests
    {
        [Test]
        public void Constructor_Valid_Creates()
        {
            //Arrange
            

            //Act
            var actual = new FizzBuzzInput(1, "display");

            //Assert
            actual.Should().NotBeNull();
            actual.Divisor.Should().Be(1);
            actual.Display.Should().Be("display");
        }

        [Test]
        public void Constructor_Zero_Throws()
        {
            //Arrange
            

            //Act
            Action actual = () => new FizzBuzzInput(0, "display");

            //Assert
            actual.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void Constructor_EmptyDisplay_Throws()
        {
            //Arrange


            //Act
            Action actual = () => new FizzBuzzInput(1, "");

            //Assert
            actual.ShouldThrow<ArgumentNullException>();
        }
    }
}