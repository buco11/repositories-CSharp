using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {

            //2.Write a program in C# Sharp to read 10 numbers from keyboard and find their sum and average.
            Console.WriteLine("Enter numbers");
            int[] nums = new int[10];
            var sum = 0;
            int i = 0;
            while (true && i<10)
            {
                var num = int.Parse(Console.ReadLine());
                nums[i] = num;
                sum += nums[i];
                i++;
                
            }
            Console.WriteLine("The sum of the array you have entered is:" + sum);
            Console.WriteLine("The average value of the array that you have entered is:" + sum/nums.Length);
        }
    }
}
