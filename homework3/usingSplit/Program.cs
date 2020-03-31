using System;

namespace usingSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 4
            //"The whole group of G1 loves C#, we are sure that with their deducation and passion " +
            //"they will be successfull programers soon!"

            //* Print the whole text after "," in the console.
            //*Bonus - Try to do that without counting the characters till "," by yourself :)

            string str = "The whole group of G1 loves C#, we are sure that with their deducation and passion they will be successfull programers soon!";
            string[] str1 = str.Split(", ");


            Console.WriteLine(str1[1]);
        }
    }
}
