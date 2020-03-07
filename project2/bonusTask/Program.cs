using System;

namespace bonusTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            int result;
            bool res = int.TryParse(input, out result);

            //Console.WriteLine(res);
            //Console.WriteLine(result);
            //Console.ReadLine();
            if (res)
            {
                if (result % 2 == 0)
                {
                    Console.WriteLine("the number is even");
                }
                else
				{
					Console.WriteLine("the number is odd");
				}
			}
			else
			{
				Console.WriteLine("enter a number");
			}
        }
    }
}
