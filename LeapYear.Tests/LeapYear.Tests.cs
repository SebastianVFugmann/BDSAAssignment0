using System;
using Xunit;
using LeapYear;
using System.IO;

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
        
        [Fact]
        public void isABCLeapYearErrorMessagePrinted()
        {
            //Arrange
            StringReader stdIn = new("abc");
            Console.SetIn(stdIn);

            var writer = new StringWriter();
            Console.SetOut(writer);

            //Act
            Program.Main(new string[0]);
            string[] output = writer.ToString().Split(Environment.NewLine);

            //Assert
            Assert.Equal("The input: 'abc' is not a valid year", output[1].Trim());
        }
    }
}