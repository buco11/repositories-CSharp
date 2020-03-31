using System;

namespace classHuman
{
    public class human
    {
        public string FirstName;
        public string LastName;
        public string Age;

        public void GetPersonStats()
        {
            Console.WriteLine($"Hello, my name is {FirstName} {LastName} and I am {Age} years old");
        }
    }
    class Program
    {
  
        static void Main(string[] args)
        {
            //Task 8
            //Create a class Human
            //Add properties: FirstName, LastName, Age
            //Create a method called GetPersonStats that returns the full name of the human as well as their age
            //Create an object human by asking the user to fill the required information
            //Call the GetPersonStats method and print the result in the console after the object is created
            Console.WriteLine("Enter first name");
            string frstName = Console.ReadLine();
            Console.WriteLine("Enter last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter age");
            string age = Console.ReadLine();

            human userInput = new human();

            userInput.FirstName = frstName;
            userInput.LastName = lastName;
            userInput.Age = age;

            userInput.GetPersonStats();

            Console.WriteLine("Hello World!");
        }
    }
}
