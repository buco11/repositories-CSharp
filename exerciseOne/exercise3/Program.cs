using System;

namespace exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            var input = Console.ReadLine();
            int userInput;
            bool res = int.TryParse(input, out userInput);

            if (res)
            {
                for (int i = 1; i < userInput; i++)
                {
                    if (i % 3 == 0 || i % 7 == 0) continue;
                    if (i == 100)
                    {
                        Console.WriteLine("Limit is reached!");
                        break;

                   }
                    Console.WriteLine(i);
                }

                
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
            Console.ReadLine();
        }
        
    }
}
