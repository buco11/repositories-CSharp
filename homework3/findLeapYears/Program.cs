using System;

namespace findLeapYears
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 6
            //* Find the leap years between 2008 and 2020.
            //* Expected output: *2008 is a leap year.
            //* 2012 is a leap year. * 2016 is a leap year. * 2020 is a leap year.
            //* Hint - make some researches of DateTime methods, you will find interesting ones that might help you;)

            int[] years = new int[] { 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020 };
            for (int i = 0; i < years.Length; i++)
            {
                if (((years[i] % 4 == 0) && (years[i] % 100 != 0)) || (years[i] % 400 == 0))
                {
                    Console.WriteLine(years[i] + " is leap year");
                }
            }

            Console.WriteLine("there is another way");

            for (int year = 2008; year <= 2020; year++)
            {
                if (DateTime.IsLeapYear(year))
                {
                    Console.WriteLine("{0} is a leap year.", year);

                }
            }
        }
    }
}
