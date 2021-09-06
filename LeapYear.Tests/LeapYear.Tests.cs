using System;
using Xunit;
using LeapYear;

namespace LeapYear.Tests
{
    public class LeapYearTest
    {
        [Fact]
        public void is1953LeapYearMod4()
        {
            //Arrange

            //Act
            bool result = Program.IsLeapYear(1953);

            //Assert
            Assert.False(result);
        }
        
        [Fact]
        public void is1900LeapYearMod4and100()
        {
            //Arrange

            //Act
            bool result = Program.IsLeapYear(1900);

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void is2000LeapYearMod4and100and400()
        {
            //Arrange

            //Act
            bool result = Program.IsLeapYear(2000);

            //Assert
            Assert.True(result);
        }
        
        [Fact]
        public void is1500LeapYearExceptionIsThrown()
        {
            //Arrange

            //Act + Assert
            Assert.Throws<YearToEarlyException>(() => Program.IsLeapYear(1500));
        }
        /*
        [Fact]
        public void isABCLeapYearErrorMessagePrinted()
        {
            //Arrange
            var input = "abc";

            //Act
            YearToEarlyException exception = Assert.Throws<YearToEarlyException>(Program.IsLeapYear(input));

            //The thrown exception can be used for even more detailed assertions.
            Assert.Equal("YearToEarlyException: 1500 is earlier than 1582, so it can't be a leap year", exception.Message);
        }*/
    }
}