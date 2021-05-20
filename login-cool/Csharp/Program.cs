using System;
using System.Threading;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {



            int times = 0;
            int nothing = 0;

            bool password_true = false;

            while (!password_true) {
                Console.Write("Password: ");

                string password = Console.ReadLine();

                if (password == "easyToCrack") {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You are in.");
                    password_true = true;

                    Thread.Sleep(2000);
                }
                else if (String.IsNullOrEmpty(password))
                {
                    nothing = nothing + 1;
                    Console.WriteLine("You must enter something.");
                }
                else
                {
                    int left = 2 - times;
                    if (left == 0)
                    {
                        Console.WriteLine("Wrong 3 times.\a");
                        System.Environment.Exit(1);
                    }
                    Console.WriteLine("Wrong");


                    times = times + 1;
                    if (left == 1)
                    {
                        Console.WriteLine("You have one try left");
                    }
                    else
                    {
                        Console.WriteLine("You have " + left + " tries left");
                    }
                    nothing = 0;

                }



                if (times == 3)
                {
                    Thread.Sleep(2000);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong 3 times.\a");
                    System.Environment.Exit(1);
                    
                }

                if (nothing == 3)
                {
                    Thread.Sleep(2000);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Didn't type anything 3 times in a row. \a ");
                    
                    System.Environment.Exit(1);
                    
                }
                


            }
            // while end.
            Console.Clear();



        }
    }
}
