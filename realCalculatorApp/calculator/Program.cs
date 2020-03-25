using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            float result;
            while (true)
            {
                Console.WriteLine("Enter the action to be preformed: -, +, /, *");
                var operationInput = Console.ReadLine();
                Console.WriteLine("Enter the first number");
                var firstNum = Console.ReadLine();
                float num1;
                bool res = float.TryParse(firstNum, out num1);
                Console.WriteLine("Enter the second number");
                var secondNum = Console.ReadLine();
                float num2;
                bool res2 = float.TryParse(secondNum, out num2);

                switch (operationInput)
                {
                    case "-":
                        result = decrement(num1, num2);
                        break;
                    case "+":
                        result = increment(num1, num2);
                        break;
                    case "/":
                        if (num2 != 0)
                        {
                            result = divide(num1, num2);
                        }
                        else
                        {
                            result = 0;
                            Console.WriteLine("You can not divide with 0");
                        }
                        break;

                    case "*":
                        result = multiply(num1, num2);
                        break;
                    default:
                        result = 0;
                        Console.WriteLine("That action can not be performed");
                        break;
                }
                Console.WriteLine(num1 + " " + operationInput + " " + num2 + " " + "=" + " " + result);
            }



        }
        static public float decrement(float first, float second)
        {
            return  first - second;

        }
        static public float increment(float first, float second)
        {
            return first + second;

        }
        static public float divide(float first, float second)
        {
            return first / second;

        }
        static public float multiply(float first, float second)
        {
            return first * second;

        }
    }
}
