using System;

namespace displayDayProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 5
            //* Display the Day properties(year, month, day, hour, minute, second) from the today's date. *Expected Output :
            //*year = 2020
            //* day = 26
            //* hour = 23
            //* second = 22
            DateTime dateTime = DateTime.Now;
            int year = dateTime.Year;
            int month = dateTime.Month;
            int day = dateTime.Day;
            int hour = dateTime.Hour;
            int minutes = dateTime.Minute;
            int seconds = dateTime.Second;

            Console.WriteLine("year =" + year + "\nmonth =" + month + "\nday = " + day + "\nhour = " + hour +
                "\nminutes = " + minutes + "\nseconds = " + seconds);

        }
    }
}
