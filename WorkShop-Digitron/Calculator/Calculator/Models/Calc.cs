using Calculator.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Models
{
    public static class Calc
    {
        public static decimal Avg (List<int> numbers)
        {
            return HelpersMethods.CalculateAverage(numbers);
        }
        public static int Max (List<int> numbers)
        {
            return HelpersMethods.FindMaxNumber(numbers);
        }

        public static int Min(List<int> numbers)
        {
            return HelpersMethods.FindMinNumber(numbers);
        }

        public static int Sum(List<int> numbers)
        {
            return HelpersMethods.CalculateSum(numbers);
        }

        public static int MinEven(List<int> numbers)
        {
            return HelpersMethods.FindMinEvenNumber(numbers);
        }

        public static int MaxEven(List<int> numbers)
        {
            return HelpersMethods.FindMaxEvenNumber(numbers);
        }
    }
}
