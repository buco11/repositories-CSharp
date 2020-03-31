using System;

namespace wordCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 2
            //* Count the total number of words in a string entered by the user.
            //* Example: user enters "I love C#" * Expected output: "I love c#" contains 3 words.

            Console.WriteLine("Enter some string!");
            string userInput = Console.ReadLine();
            
            string[] words = userInput.Split(" ");
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine("The number of words in the string you have entered is: " + words.Length);
               Console.ReadLine();
        }
    }
}
