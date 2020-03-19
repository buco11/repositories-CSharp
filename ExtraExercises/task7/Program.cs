using System;

namespace task7
{
    class Program
    {
        static void Main(string[] args)
        {
            //userNames = ["user1", "user2", "user3"]
            //passwords = ["first", "second", "third"]
            //Write a program in C# Sharp to ask the user to enter a username. After that user should provide a password.
            //Create a logic when user enters specific username to provide a correct password for that user, and when that
            //happens you should print on the screen "You are logged in successfully".
            //If username or password are invalid or don't correspond  should be print on the screen and 
            //repeat the proccess from begining while he / she doesn't input correct username and password.


            //Note: Every element in userNames corresponds with the element in passwords at same index.
            //Example: password for "user1" is "first", password for "user2" is "second", password for "user3" is "third".

            string[] userNames = new string[] { "user1", "user2", "user3" };
            string[] passwords = new string[] { "first", "second", "third" };
            bool register = false;
            

            while (true)
            {
                Console.WriteLine("Enter username");
                var userName = Console.ReadLine();
                Console.WriteLine("Enter password");
                var password = Console.ReadLine();

                for (int i = 0; i < userNames.Length; i++)
                {
                    if (password == passwords[i] && userName == userNames[i])
                    {
                        register = true;
                        
                    }

                }
                if (register == true)
                {
                    Console.WriteLine("You are logged in successfully");
                    break;
                }
                else

                {
                    Console.WriteLine("Incorrect username or password");
                }
            }
            Console.ReadLine();
        }
        
    }
}
