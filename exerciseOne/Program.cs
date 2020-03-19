using System;

namespace exerciseOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number from 1-3!");
            var userInput = Console.ReadLine();
            int input;
            bool res = int.TryParse(userInput, out input);
            //switch (input)
            //{
            //    case 1:
            //        Console.WriteLine("You got a new car");
            //        break;
            //    case 2:
            //        Console.WriteLine("You got a new plane");
            //        break;
            //    case 3:
            //        Console.WriteLine("You got a new bike");
            //        break;
            //    default:
            //        Console.WriteLine("Wrong input");
            //        break;


            if (input == 1)
            {
                Console.WriteLine("You got a new car");
            }
            else if (input == 2)
            {
                Console.WriteLine("You got a new plane");
            }
            else if (input == 3)
            {
                Console.WriteLine("You got a new bike");
            }
            else
            {
                Console.WriteLine("Wrong input");

            }


        }
    }
    
}
