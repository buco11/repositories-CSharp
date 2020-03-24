using System;

namespace login_register_app
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = new string[] { };
            string[] passwords = new string[] { };
            int i = 0;
            
            while (true)
            {
                Console.WriteLine("what would you like to do: " +
                    "1. Register" + "  /  " +
                    "2. Login");
                var userChoices = Console.ReadLine();
                int userChoice;
                bool res = int.TryParse(userChoices, out userChoice);

                switch (userChoice)
                {
                    case 1:
                        

                        Console.WriteLine("Enter username in the following format: username@domain.com");
                        Console.WriteLine("Username must be up to 30 characters");
                        string usernameInput = Console.ReadLine();
                        string substr = usernameInput.Substring(usernameInput.Length - 4);
                        if (usernameInput.ToLower().Contains("@") && usernameInput.ToLower().Contains(".")
                            && substr.ToLower() == ".com" && usernameInput.Length < 30)
                        {
                            Array.Resize(ref usernames, usernames.Length + 1);
                            usernames[i] = usernameInput;
                            
                            Console.WriteLine("Enter password");
                            Console.WriteLine("Password must contain at least 10 characters including: small letter, big letter, number and special character");
                            string password = Console.ReadLine();
                            var sampleRegex = new System.Text.RegularExpressions.Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{10,15}$");
                            bool isStrongPassword = sampleRegex.IsMatch(password);
                            if (isStrongPassword)
                            {
                                
                                Array.Resize(ref passwords, password.Length + 1);
                                passwords[i] = password;
                                
                                Console.WriteLine("You have registered successfully");
                                i++;
                                //foreach (var el in usernames)
                                //{
                                //    Console.WriteLine(el);
                                //}
                                //foreach (var it in passwords)
                                //{
                                //    Console.WriteLine(it);
                                //}
                                break;
                            }
                            else
                            {
                                Console.WriteLine("You have entered bad password");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Bad format");
                        }
                        
                        break;

                    case 2:
                        
                        while (true)
                        {
                            Console.WriteLine("Enter username");
                            var username = Console.ReadLine();
                            Console.WriteLine("Enter password");
                            var password = Console.ReadLine();
                            bool reg = false;

                            for (int k = 0; k < usernames.Length; k++)
                            {
                                if (password == passwords[k] && username == usernames[k])
                                {
                                    reg = true;

                                }

                            }
                            if (reg == true)
                            {
                                Console.WriteLine("You are logged in successfully");
                                break;
                            }
                            else

                            {
                                Console.WriteLine("Incorrect username or password");
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("bad input");
                        break;


                   
                }
                
            }
        }
    }
}
