using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.Declare and init array of 10 integers by your choise. 
            //Find maximum and minimum element in that array and their indexes.

            int[] nums = new int[10];


            Console.WriteLine("Enter numbers in the array");
            for (int i = 0; i < nums.Length; i++)
            {
                var num = int.Parse(Console.ReadLine());
                nums[i] = num;
            }
            foreach (var el in nums)
            {
                Console.WriteLine("You have entered:" + el);
            }

            int min = nums[0];
            int max = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < min)
                {

                    min = nums[i];
                }
                if (nums[i] > max)
                {

                    max = nums[i];
                }
            }
            Console.WriteLine("The minimum number in the array is: " + min + " and its index is: " + Array.IndexOf(nums, min));
            Console.WriteLine("The maximum number in the array is: " + max + " and its index is: " + Array.IndexOf(nums, max));
        }
    }
}
