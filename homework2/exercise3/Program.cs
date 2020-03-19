using System;

namespace exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            //            EXERCISE 03:
            //            Create an array with names
            //            Give an option to the user to enter a name from the keyboard
            //            After entering the name put it in the array
            //            Ask the user if they want to enter another name(Y / N)
            //            Do the same process over and over until the user enters N
            //            Print all the names after user enters N
            //            Hint: we need to use endless loop until user enter N, then we want to "break" the loop

            string[] names = new string[] { };
            int i = 0;
            string answer = "y";
            string name;
            Console.WriteLine("Enter any name");
            while (answer == "y")
            {
                Array.Resize(ref names, names.Length + 1);
                name = Console.ReadLine();
                names[i] = name;
                i++;
                Console.WriteLine("Do you want to enter another name y/n");
                answer = Console.ReadLine();
            }
            foreach (string n in names)
            {
                Console.WriteLine(n);
            }
            Console.ReadLine();
        }
    }
}
