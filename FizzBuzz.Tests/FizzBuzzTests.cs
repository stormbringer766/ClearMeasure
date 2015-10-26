using System;
using FizzBuzz.Console;
using FluentAssertions;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        private const string Fizz = "Fizz";
        private const string Buzz = "Buzz";

        private Console.FizzBuzz _processor;

        [SetUp]
        public void TestInitialize()
        {
            var fizz = new FizzBuzzInput(3, Fizz);
            var buzz = new FizzBuzzInput(5, Buzz);

            _processor = new Console.FizzBuzz(fizz, buzz);
        }

        [Test]
        public void Process_3_ReturnsFizz()
        {
            var actual = _processor.Process(3);

            actual.Should().Be(Fizz);
        }

        [Test]
        public void Process_5_ReturnsBuzz()
        {
            var actual = _processor.Process(5);

            actual.Should().Be(Buzz);
        }

        [Test]
        public void Process_15_ReturnsFizzBuzz()
        {
            var actual = _processor.Process(15);

            actual.Should().Be(Fizz + Buzz);
        }

        [Test]
        public void Constructor_NullFizz_Throws()
        {
            //Arrange


            //Act
            // ReSharper disable once ObjectCreationAsStatement
            Action actual = () => new Console.FizzBuzz(null, new FizzBuzzInput(1, "Display"));

            //Assert
            actual.ShouldThrow<ArgumentNullException>()
                .And.ParamName.Should().Be("fizz");
        }

        [Test]
        public void Constructor_NullBuzz_Throws()
        {
            //Arrange


            //Act
            // ReSharper disable once ObjectCreationAsStatement
            Action actual = () => new Console.FizzBuzz(new FizzBuzzInput(1, "Display"), null);

            //Assert
            actual.ShouldThrow<ArgumentNullException>()
                .And.ParamName.Should().Be("buzz");
        }
    }
}