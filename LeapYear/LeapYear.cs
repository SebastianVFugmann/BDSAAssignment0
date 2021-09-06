using System;

namespace LeapYear
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please, type in a year and press [Enter]");
            
            var input = Console.ReadLine().Trim();
            int number;
            bool converted = int.TryParse(input, out number);
            if(converted)
            {
                try
                {
                    bool result = IsLeapYear(number);
                    if(result) Console.WriteLine("Yay");
                    else Console.WriteLine("Nay");
                } catch (YearToEarlyException e)
                {
                    Console.WriteLine("YearToEarlyException: " + e.Message);
                }
            } else
            {
                Console.WriteLine("The input: '" + input + "' is not a valid year");
            } 
        }

        public static bool IsLeapYear(int year)
        {
            if(year < 1582) throw (new YearToEarlyException(year + " is earlier than 1582, so it can't be a leap year"));
            if(year % 4 != 0) return false;
            if(year % 400 == 0) return true;
            if(year % 100 == 0) return false;
            return true;
        }
    }

    public class YearToEarlyException: Exception 
    {
        public YearToEarlyException(string message): base(message) {
        }
}
}
