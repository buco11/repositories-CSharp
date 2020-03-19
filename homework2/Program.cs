using System;

namespace homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            //EXERCISE 01:
            //Get an input number from the console
            //Print all numbers from 1 to that number
            //Get another input number from the console
            //Print all numbers from that number to 1

            Console.WriteLine("Enter a number!");
            var input = Console.ReadLine();
            int userInput;
            bool res = int.TryParse(input, out userInput);

            if (res)
            {
                for (int i = 1; i <= userInput; i++)
                {
                    Console.WriteLine(i);
                }

            }
            else
            {
                Console.WriteLine("Wrong input");
            }

            Console.WriteLine("Enter a number!");
            var inputTwo = Console.ReadLine();
            int userInputTwo;
            bool resTwo = int.TryParse(input, out userInputTwo);

            if (res)
            {
                for (int i = userInputTwo; i >= 1; i--)
                {
                    Console.WriteLine(i);
                }

            }
            else
            {
                Console.WriteLine("Wrong input");
            }
        }
    }
}
