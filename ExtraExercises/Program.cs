using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {


            //1.Write a C# Sharp program to find the sum of first 10 natural numbers
            //*Hint: The first 10 natural number are: 1 2 3 4 5 6 7 8 9 10

            int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }

            Console.WriteLine(sum);
        }
    }
}
