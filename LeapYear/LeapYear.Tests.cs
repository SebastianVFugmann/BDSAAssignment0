using System;
using Xunit;
using LeapYear;

namespace LeapYear
{
    public class LeapYearTest
    {
        [Fact]
        public void is400LeapYearMod4()
        {
            //Arrange

            //Act
            bool result = LeapYear.IsLeapYear(4);

            //Assert
            Assert.Equal(true, result);
        }
        
        [Fact]
        public void is1700LeapYearMod4and100()
        {
            //Arrange

            //Act
            bool result = LeapYear.IsLeapYear(1700);

            //Assert
            Assert.Equal(false, result);
        }

        [Fact]
        public void is2000LeapYearMod4and100and400()
        {
            //Arrange

            //Act
            bool result = LeapYear.IsLeapYear(2000);

            //Assert
            Assert.Equal(true, result);
        }
    }
}
