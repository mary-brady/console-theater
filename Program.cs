using System;
using ConsoleTheater.Models;

namespace ConsoleTheater
{
    class Program
    {
        static void Main(string[] args)
        {
            Theater myTheater = new Theater("MOVIETOWN");
            Movie zoolander = new Movie("Zoolander");
            myTheater.AddRoom(zoolander, 100);
            myTheater.AddShowtime("6:00", 0);
            myTheater.AddShowtime("8:30", 0);
            Movie pf = new Movie("Pulp Fiction");
            myTheater.AddRoom(pf, 50);
            myTheater.AddShowtime("6:00", 1);
            myTheater.AddShowtime("9:00", 1);

            bool InTheTheater = true;
            while (InTheTheater)
            {
                myTheater.Initialize();
                System.Console.WriteLine($"Welcome to {myTheater.Name}!");
                System.Console.WriteLine("What would you like to do?");
                System.Console.WriteLine("1. See a movie");
                System.Console.WriteLine("2. Buy concessions");
                System.Console.WriteLine("3. Quit");

                var UserInput = Console.ReadLine();
                if (Int32.TryParse(UserInput, out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            myTheater.PrintMovies();
                            break;
                        case 2:
                            myTheater.PrintSnacks();
                            System.Console.WriteLine("WHAT SNACK SHALL IT BE ?");
                            UserInput = Console.ReadLine();
                            if (Int32.TryParse(UserInput, out choice))
                            {
                                myTheater.BuySnack(choice);
                            }
                            break;
                        case 3:
                            InTheTheater = false;
                            System.Console.WriteLine("Ok byeee");
                            break;
                        default:
                            Console.WriteLine("Invalid option, try again");
                            break;
                    }
                }

            }


        }
    }
}
