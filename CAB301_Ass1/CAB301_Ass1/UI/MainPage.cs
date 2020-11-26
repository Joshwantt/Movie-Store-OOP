using System;
using System.Collections.Generic;
using System.Text;

namespace CAB301_Ass1
{
    static class Store //class to allow access to movie collection from other classes
    {
        public static MovieCollection movies = new MovieCollection(); //initialise Moviecollection class
    }

    public class glob //class containing global variables
    {
        public static string fname; //glob used for storing logged in users full name
        public static Movie[] TopArray = new Movie[50]; //Array used to calculate top movies, assumes 40 or less movies in BST

        static int loc = 0; //variable used to properly manipulate variable order in top array

        public static void Add(Movie mov) //function for adding movie to correct position
        {
            if (loc < TopArray.Length) //checks its not trying to index out of array length
            {
                TopArray[loc] = mov; //set current index to inpout movie
                loc++; //iterate
            }
        }
    }

    class MainPage
    {
        public static void MainMenu()
        {
            Console.WriteLine("Welcome to the Community Library");
            Console.WriteLine("=========== Main Menu ============");
            Console.WriteLine("1. Staff Login");
            Console.WriteLine("2. Member Login ");
            Console.WriteLine("0. Exit");
            Console.WriteLine("===================================");
            Console.WriteLine("");
            Console.WriteLine(" Please make a selection (1-2, or 0 to exit)");

            int input = Int32.Parse(Console.ReadLine());

            if (input == 0)
            {
                Console.WriteLine("Press Enter to exit");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else if (input == 1)
            {
                Console.Clear();
                StaffLogin();
            }
            else if (input == 2)
            {
                Console.Clear();
                MemberLogin();
            }
            else
            {
                Console.WriteLine("Invalid selection. Input valid selection (0,1,2)");
            }
        }
        public static void StaffLogin()
        {
            Console.WriteLine("Enter Username");
            if (Console.ReadLine() == "staff")
            {
                Console.WriteLine("Enter Password");
                if (Console.ReadLine() == "today123")
                {
                    Console.Clear();
                    StaffMenu();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Incorrect Password, returning to main menu");
                    MainMenu();
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Incorrect Username, returning to main menu");
                MainMenu();
            }
        }

        public static void MemberLogin()
        {
            Console.WriteLine("Enter MemberID (FirstnameLastname)");
            string username = Console.ReadLine();
            Console.WriteLine("Enter Member PIN");
            int pass = Int32.Parse(Console.ReadLine());
            if (MemberCollection.GetMember(username) != null && MemberCollection.GetPass(username, pass))
            {
                Console.Clear();
                glob.fname = username;
                MemberMenu();
            }
            else
            {
                Console.WriteLine("Invalid Username or PIN, Press any key to return to main menu");
                Console.ReadLine();
                Console.Clear();
                MainMenu();
            }
        }

        public static void StaffMenu()
        {
            Console.WriteLine("=========== Staff Menu ============");
            Console.WriteLine("1. Add a new movie DVD");
            Console.WriteLine("2. Remove a Movie DVD");
            Console.WriteLine("3. Register a new Member");
            Console.WriteLine("4. Find a registered member's phone number");
            Console.WriteLine("0. Return to Main Menu ");
            Console.WriteLine("===================================");
            Console.WriteLine(" Please make a selection (1-4, or 0 to exit)");

            int input = Int32.Parse(Console.ReadLine());

            if (input == 0)
            {
                Console.Clear();
                MainPage.MainMenu();
            }
            else if (input == 1)
            {
                Console.Clear();
                StaffMenus.AddMovie();
            }
            else if (input == 2)
            {
                Console.Clear();
                StaffMenus.RemoveMovie();
            }
            else if (input == 3)
            {
                Console.Clear();
                StaffMenus.RegisterMember();
            }
            else if (input == 4)
            {
                Console.Clear();
                StaffMenus.MemberPh();
            }
            else
            {
                Console.WriteLine("Invalid selection. Please input valid option (1-4 or 0)");
            }

        }



        public static void MemberMenu()
        {
            Console.WriteLine("=========== Member Menu ============");
            Console.WriteLine("1. Display all movies");
            Console.WriteLine("2. Borrow a Movie DVD");
            Console.WriteLine("3. Return a movie DVD");
            Console.WriteLine("4. List current borrowed movie DVDs");
            Console.WriteLine("5. Display top 10 most popular movies ");
            Console.WriteLine("0. Return to main menu");
            Console.WriteLine("===================================");
            Console.WriteLine(" Please make a selection (1-5, or 0 to exit)");

            int input = Int32.Parse(Console.ReadLine());

            if (input == 0)
            {
                Console.Clear();
                MainPage.MainMenu();
            }
            else if (input == 1)
            {
                Console.Clear();
                MemberMenus.DisplayMovies();
            }
            else if (input == 2)
            {
                Console.Clear();
                MemberMenus.BorrowMovie();
            }
            else if (input == 3)
            {
                Console.Clear();
                MemberMenus.ReturnMovie();
            }
            else if (input == 4)
            {
                Console.Clear();
                MemberMenus.ListBorrowed();
            }
            else if (input == 5)
            {
                Console.Clear();
                MemberMenus.Top10();
            }
            else
            {
                Console.WriteLine("Invalid selection. Please make valid selection (1-5, or 0)");
            }
        }
    }
}


