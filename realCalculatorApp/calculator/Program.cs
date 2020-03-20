using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            float res;
            while (true)
            {
                Console.WriteLine("Enter the action to be preformed: -, +, /, *");
                var operationInput = Console.ReadLine();
                Console.WriteLine("Enter the first number");
                float num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second number");
                float num2 = int.Parse(Console.ReadLine());

                switch (operationInput)
                {
                    case "-":
                        res = num1 - num2;
                        break;
                    case "+":
                        res = num1 + num2;
                        break;
                    case "/":
                        if (num2 != 0)
                        {
                            res = num1 / num2;
                        }
                        else
                        {
                            res = 0;
                            Console.WriteLine("You can not devide with 0");
                        }
                        break;

                    case "*":
                        res = num1 * num2;
                        break;
                    default:
                        res = 0;
                        Console.WriteLine("That action can not be performed");
                        break;
                }
                Console.WriteLine(num1 + " " + operationInput + " " + num2  + " " + "=" + " " + res);
            }



        }
    }
}
