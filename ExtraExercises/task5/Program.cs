using System;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            //oddEvenArray = [10, 23, 44, 123, 55, 52, 98, 99, 102, 103, 152, 49]
            //Write a program in C# Sharp to separate odd and even integers from the oddEvenArray in separate arrays
            int[] oddEvenArray = new int[] { 10, 23, 44, 123, 55, 52, 98, 99, 102, 103, 152, 49 };
            int[] oddNums = new int[999];
            int[] evenNums = new int[999];
            int j = 0;
            int k = 0;
            for (int i = 0; i < oddEvenArray.Length; i++)
            {
                if (oddEvenArray[i] % 2 != 0)
                {
                    oddNums[j] = oddEvenArray[i];
                    j++;
                }
                else
                {
                    evenNums[k] = oddEvenArray[i];
                    k++;
                }
            }
            Console.WriteLine("the odd numbers are:");
            for (int i = 0; i < j; i++)
            {
                Console.WriteLine(oddNums[i]);
            }
            Console.WriteLine("the even numbers are:");
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine(evenNums[i]);
            }
            
        }
    }
}
