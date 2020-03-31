using System;

namespace reverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            //*Print individual characters of the string in reverse order.
            //*Example: we love c# *Expected Output : #c evol ew

            Console.WriteLine("Enter some string!");
            string userInput = Console.ReadLine();

            
            char[] userInputChars = userInput.ToCharArray();

            Array.Reverse(userInputChars);
            var result = new string(userInputChars);
            
            Console.WriteLine($"Reversed String: {result}");
        }
    }
}
