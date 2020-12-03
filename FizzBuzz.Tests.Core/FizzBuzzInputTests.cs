using System;
using FizzBuzz.Console;
using FluentAssertions;
using Xunit;

namespace FizzBuzz.Tests
{
    public class FizzBuzzInputTests
    {
        [Fact]
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

        [Fact]
        public void Constructor_Zero_Throws()
        {
            //Arrange


            //Act
            // ReSharper disable once ObjectCreationAsStatement
            Action actual = () => new FizzBuzzInput(0, "display");

            //Assert
            actual.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Fact]
        public void Constructor_EmptyDisplay_Throws()
        {
            //Arrange


            //Act
            // ReSharper disable once ObjectCreationAsStatement
            Action actual = () => new FizzBuzzInput(1, "");

            //Assert
            actual.Should().Throw<ArgumentNullException>();
        }
    }
}
