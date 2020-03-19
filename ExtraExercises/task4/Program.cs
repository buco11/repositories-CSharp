using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.arrayWithDuplicates = [1, 4, 6, 3, 4, 5, 9, 3, 2, 9]
            //Write a program in C# Sharp to count a total number of duplicate elements in arrayWithDuplicates
            int[] arr1 = new int[] { 1, 4, 6, 3, 4, 5, 9, 3, 2, 9 };
            int count = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = i+1; j < arr1.Length; j++)
                {
                    if (arr1[i] == arr1[j])
                    {
                        count++;
                        break;
                    }
                }
            }
            Console.WriteLine("The number of Duplicate Elements Present in Array is: " + count);
        }
    }
}
