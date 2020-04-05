using System;
namespace CodeOrginizer.Helpers
{
    public class PersonHelper
    {
        public static long GenerateSSN()
        {
            Random rand = new Random();
            return rand.Next(1000000, 9999999);
        }
    }
}
