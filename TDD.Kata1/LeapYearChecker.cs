namespace TDD.Kata1
{
    public class LeapYearChecker
    {
        public bool IsLeapYear(int year)
        {
            return IsTypicalLeapYear(year) && !IsAtypicalCommonYear(year);
        }

        private static bool IsAtypicalCommonYear(int year)
        {
            return (year % 100 == 0 && year % 400 != 0);
        }

        private static bool IsTypicalLeapYear(int year)
        {
            return year % 4 == 0;
        }
    }
}
