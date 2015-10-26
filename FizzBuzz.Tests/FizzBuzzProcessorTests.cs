using System;
using FizzBuzz.Console;
using FluentAssertions;
using Moq;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzProcessorTests
    {
        private Mock<IFizzBuzzOutput> _out;

        [SetUp]
        public void TestInitialize()
        {
            _out = new Mock<IFizzBuzzOutput>();
        }

        [Test]
        public void Constructor_Valid_Creates()
        {
            //Arrange


            //Act
            var actual = new FizzBuzzProcessor(1, 100, SetupFizzBuzz(), _out.Object);

            //Assert
            actual.Should().NotBeNull();
        }

        [Test]
        public void Constructor_EndLessThanStart_Throws()
        {
            //Arrange


            //Act
            // ReSharper disable once ObjectCreationAsStatement
            Action actual = () => new FizzBuzzProcessor(2, 1, SetupFizzBuzz(), _out.Object);

            //Assert
            actual.ShouldThrow<ArgumentOutOfRangeException>()
                .And.ParamName.Should().Be("end");
        }

        [Test]
        public void Constructor_NullFizzBuzz_Throws()
        {
            //Arrange


            //Act
            // ReSharper disable once ObjectCreationAsStatement
            Action actual = () => new FizzBuzzProcessor(1, 2, null, _out.Object);

            //Assert
            actual.ShouldThrow<ArgumentNullException>()
                .And.ParamName.Should().Be("fizzBuzz");
        }

        [Test]
        public void Constructor_NullOuput_Throws()
        {
            //Arrange


            //Act
            // ReSharper disable once ObjectCreationAsStatement
            Action actual = () => new FizzBuzzProcessor(1, 2, SetupFizzBuzz(), null);

            //Assert
            actual.ShouldThrow<ArgumentNullException>()
                .And.ParamName.Should().Be("output");
        }

        [Test]
        public void Run_15_DisplayProperResults()
        {
            //Arrange
            var processor = new FizzBuzzProcessor(1, 15, new Console.FizzBuzz(SetupInput(), new FizzBuzzInput(5, "Buzz")), _out.Object);

            //Act
            processor.Run();

            //Assert
            _out.Verify(x => x.WriteLine("1"));
            _out.Verify(x => x.WriteLine("Fizz"), Times.Exactly(4));
            _out.Verify(x => x.WriteLine("Buzz"), Times.Exactly(2));
            _out.Verify(x => x.WriteLine("FizzBuzz"), Times.Exactly(1));
            _out.Verify(x => x.WriteLine(It.IsAny<string>()), Times.Exactly(15));
        }

        private static Console.FizzBuzz SetupFizzBuzz(FizzBuzzInput fizz = null, FizzBuzzInput buzz = null)
        {
            return new Console.FizzBuzz(fizz ?? SetupInput(), buzz ?? SetupInput());
        }

        private static FizzBuzzInput SetupInput(int divisor = 3, string display = "Fizz")
        {
            return new FizzBuzzInput(divisor, display);
        }
    }
}