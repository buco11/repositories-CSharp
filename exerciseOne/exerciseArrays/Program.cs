using System;

namespace exerciseArrays
{
    class Program
    {
        static void Main(string[] args)
        {

            //declare a new array of integers with 5 elements
            int[] numbers = new int[5];
            //initialize the araay with elements from input

            int numberOfElements = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                numberOfElements = i + 1;
                Console.WriteLine("Enter the" + numberOfElements + "number:");
                numbers[i] = int.Parse(Console.ReadLine());
                
            }

            //summ all the values and print the result in console
            int sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }

            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
