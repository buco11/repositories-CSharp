using System;

namespace classDog
{
    public class dog
    {
        public string Name;
        public string Race;
        public string Color;

        public void Eat()
        {
            Console.WriteLine("the dog is now eating");
        }

        public void Play()
        {
            Console.WriteLine("the dog is now playing");
        }

        public void ChaseTail()
        {
            Console.WriteLine("the dog is now chasing its tail");
        }

        public void dogInterduction()
        {
            Console.WriteLine($"dog name is: {Name} have: {Race} races and my dog is: {Color} color");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //Task 7
            //Create a class Dog
            //Add properties: Name, race, color
            //The dog needs to have:
            //Eat method that returns message: The dog is now eating
            //Play method returning a message : The dog is now playing
            //ChaseTail method that returns a message: Dog is now chasing its tail.
            //The user needs to create the dog object by inputs and then given an option to choose one of the actions mentioned above.

            Console.WriteLine("Enter the name of the dog");
            string dogName = Console.ReadLine();
            Console.WriteLine("How many races your dog have");
            string dogRaces = Console.ReadLine();
            Console.WriteLine("What color is your dog");
            string dogColor = Console.ReadLine();

            dog userInput = new dog();

            userInput.Name = dogName;
            userInput.Race = dogRaces;
            userInput.Color = dogColor;

            
            userInput.dogInterduction();

            Console.WriteLine("What is the dog doing now\n1. eating? \n2. playing? \n3. chasing tail?");
            var userAnswer = Console.ReadLine();
            int answer;
            bool res = int.TryParse(userAnswer, out answer);
            switch (answer)
            {
                case 1:
                    userInput.Eat();
                    break;
                case 2:
                    userInput.Play();
                    break;
                case 3:
                    userInput.ChaseTail();
                    break;
                default:
                    Console.WriteLine("enter the correct number");
                    break;
            }
            Console.WriteLine("Hello World!");

        }


    }
}
