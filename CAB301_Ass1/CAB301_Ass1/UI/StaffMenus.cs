using System;
using System.Collections.Generic;
using System.Text;

namespace CAB301_Ass1
{
    class StaffMenus
    {

        public static Genre numToGenre(int gennum) //takes number representing Genre as input,  returns corrisponding Genre
        {
            if (gennum == 1) 
            {
                return Genre.Drama;
            } 
            else if (gennum == 2) 
            {
                return Genre.Adventure;
            }
            else if (gennum ==3)
            {
                return Genre.Family;
            }
            else if (gennum == 4)
            {
                return Genre.Action;
            }
            else if (gennum == 5)
            {
                return Genre.SciFi;
            }
            else if (gennum == 6)
            {
                return Genre.Comedy;
            }
            else if (gennum == 7)
            {
                return Genre.Animated;
            }
            else if (gennum == 8)
            {
                return Genre.Thriller;
            }
            else
            {
                return Genre.Other;
            }
        }

        public static Classification numToClass(int clasnum) //Same as genre
        {
            if (clasnum == 1)
            {
                return Classification.General;
            }
            else if (clasnum == 2)
            {
                return Classification.ParentalGuidance;
            }
            else if (clasnum == 3)
            {
                return Classification.Mature;
            }
            else
            {
                return Classification.MatureAccompanied;
            }
        }

        public static void AddMovie() //Contains code for adding a new movie
        {
            Console.WriteLine("Enter movie title"); //prompt input
            string title = Console.ReadLine();
            int stock; //Initialise outside IF to keep variable refrencable in both the IF and ELSE

           if (Store.movies.Find(title)) //check if movie already exists, if already in collection add stock
           {
                Console.WriteLine("Movie Already in collection. How much more stock to add?");
                stock = Int32.Parse(Console.ReadLine()); //prompt input
                Store.movies.ReplaceInv(title, stock); //Call collection replace inventory function
           }
           else //Add movie normal way
           {
                Console.WriteLine("Enter starring actors (comma seperated)");
                string[] starring = Console.ReadLine().Split(","); //prompt input and convert to array for constructor

                Console.WriteLine("Enter director(s) (comma seperated)");
                string[] directors = Console.ReadLine().Split(",");//prompt input and convert to array for constructor

                Console.WriteLine("Select Genre");
                Console.WriteLine("1.  Drama");
                Console.WriteLine("2.  Adventure");
                Console.WriteLine("3.  Family");
                Console.WriteLine("4.  Action");
                Console.WriteLine("5.  Sci-Fi");
                Console.WriteLine("6.  Comedy");
                Console.WriteLine("7.  Animated");
                Console.WriteLine("8.  Thriller");
                Console.WriteLine("9.  Other");
                int gennum = Int32.Parse(Console.ReadLine()); //Prompt genre input
                Genre gen = numToGenre(gennum); //convert int input to genre for constructor

                Console.WriteLine("Select Classification");
                Console.WriteLine("1.  General (G)");
                Console.WriteLine("2.  PArental Guideance (PG)");
                Console.WriteLine("3.  Mature (M)");
                Console.WriteLine("4.  MAture Accompanied (MA15+)");
                int clasnum = Int32.Parse(Console.ReadLine());
                Classification clas = numToClass(gennum); //Same as genre

                Console.WriteLine("Enter Duration (minutes)");
                int duration = Int32.Parse(Console.ReadLine()); //more input and conversion

                Console.WriteLine("Enter release date (year)");
                int year = Int32.Parse(Console.ReadLine()); //more input and conversion

                Console.WriteLine("Enter available");
                stock = Int32.Parse(Console.ReadLine()); //more input and conversion

                Movie movie = new Movie(title, starring, directors, duration, gen, clas, year, stock); //constructs new member object with given properties
                Store.movies.Insert(movie); //inserts movie into BST
           }


            Console.WriteLine("");
            Console.WriteLine("Press enter to return to Staff Menu");
            Console.ReadLine();
            Console.Clear();
            MainPage.StaffMenu();
        }

        public static void RemoveMovie()
        {
            Console.WriteLine("I never got this working :( Press enter to return to Staff Menu");
            Console.ReadLine();
            MainPage.StaffMenu();

        }

        public static void RegisterMember()
        {
            Console.WriteLine("Enter First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            string lastName = Console.ReadLine(); //Input prompting
            Console.WriteLine("Enter Address");
            string Address = Console.ReadLine();
            Console.WriteLine("Enter Phone");
            string num = Console.ReadLine();
            Console.WriteLine("Enter Pin (4 digits)");
            int pin = Int32.Parse(Console.ReadLine());
            Member member = new Member(firstName, lastName, Address,num,pin); //constructs new member

            if ((MemberCollection.GetMember(member.FullName) == null && MemberCollection.Add(member))) //check member doesn't already exist and check sucess of adding a new member
            {
                Console.WriteLine("Sucessfully added " + member.FullName); //Print confirmation
            }
            else
            {
                Console.WriteLine(member.FullName + " Already registered"); //Member must already be registered
            }

            Console.WriteLine("");
            Console.WriteLine("Press Enter to return to menu");
            Console.ReadLine();
            MainPage.StaffMenu();
        }

        public static void MemberPh() //prints member phonenumber when given fullname
        {
            Console.WriteLine("Enter Username (Fullname) to query phone number");
            string name = Console.ReadLine(); //prompt input
            Console.WriteLine(MemberCollection.GetPhone(name)); //call and print GetPhone, func returns a sentance string of outcome

            Console.WriteLine("");
            Console.WriteLine("Press Enter to return to menu"); //uses .ToString override in member class
            Console.ReadLine();
            MainPage.StaffMenu();
        }

        public static void MainMenu()
        {
            MainPage.StaffMenu();
        }
    }
}
