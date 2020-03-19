using System;

namespace exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            //EXERCISE 02:
            //Get an input number from the console
            //Print all even numbers starting from 2
            //Get another input number from the console
            //Print all odd numbers starting from 1

            Console.WriteLine("Enter a number");
            var input = Console.ReadLine();
            int userInput;
            bool res = int.TryParse(input, out userInput);
            if (res)
            {
                for (int i = 1; i <= userInput; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("Wrong input");
            }

            Console.WriteLine("Enter a number");
            var inputTwo = Console.ReadLine();
            int userInputTwo;
            bool resTwo = int.TryParse(inputTwo, out userInputTwo);
            if (resTwo)
            {
                for (int j = 1; j <= userInputTwo; j++)
                {
                    if (j % 2 != 0)
                    {
                        Console.WriteLine(j);
                    }
                }
            }
            else
            {
                Console.WriteLine("Wrong input");
            }

        }
    }
}
