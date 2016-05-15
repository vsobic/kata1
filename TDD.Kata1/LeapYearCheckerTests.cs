using Xunit;

namespace TDD.Kata1
{
    //Write a function that returns true or false depending on
    //whether its input integer is a leap year or not.

    //A leap year is defined as one that is divisible by 4,
    //but is not otherwise divisible by 100 unless it is
    //also divisible by 400.

    //For example, 2001 is a typical common year and 1996
    //is a typical leap year, whereas 1900 is an atypical
    //common year and 2000 is an atypical leap year.

    // author : Vlada Šobić
    public class LeapYearCheckerTests
    {
        [Fact]
        public void ShouldReturnFalseForTypicalCommonYear()
        {
            LeapYearChecker checker = GetLeapYearChecker();
            bool result = checker.IsLeapYear(2001);
            Assert.False(result);
        }

        [Fact]
        public void ShouldReturnTrueForTypicalLeapYear()
        {
            LeapYearChecker checker = GetLeapYearChecker();
            bool result = checker.IsLeapYear(1996);
            Assert.True(result);
        }

        [Fact]
        public void ShouldReturnFalseForAtypicalCommonYear()
        {
            LeapYearChecker checker = GetLeapYearChecker();
            bool result = checker.IsLeapYear(1900);
            Assert.False(result);
        }

        [Fact]
        public void ShouldReturnTrueForAtypicalLeapYear()
        {
            LeapYearChecker checker = GetLeapYearChecker();
            bool result = checker.IsLeapYear(2000);
            Assert.True(result);
        }

        private LeapYearChecker GetLeapYearChecker()
        {
            return new LeapYearChecker();
        }
    }
}