using System;
using System.Collections.Generic;
using System.Text;

namespace CAB301_Ass1
{
    class MemberMenus
    {
        public static void DisplayMovies() //prints movies
        {
            Store.movies.PrintMovies(); //calls BST print function which writes movies using ToString override in movie class
            MainPage.MemberMenu();
        }
        public static void BorrowMovie() //Borrow movie controlling function, calls collection functions and makes decisions
        {
            Console.Clear();
            Console.WriteLine("Enter Movie Title"); //prompt input
            string title = Console.ReadLine();

            if (Store.movies.Find(title)) //checks the movie enteres exists
            {
                if (MemberCollection.RentMovie(glob.fname, Store.movies.FindMovie(title)) && Store.movies.BorrowMovie(title)) //calls movie and member collection functions to add movie to rented movies in Member and modify inventory/borrowed values in BST
                { //Both functions return bools so both must return true for the movie to be rented
                    Console.WriteLine(title + " sucessfully borrowed");
                    Console.WriteLine("Press enter to return to member page"); //yay
                    Console.ReadLine();
                    MainPage.MemberMenu();
                } else //if false means movie has no stock
                {
                    Console.WriteLine(title + " has no stock left :(");
                    Console.WriteLine("Press enter to return to member page"); //awww
                    Console.ReadLine();
                    MainPage.MemberMenu();
                }
            }
            else //movie does not exist
            {
                Console.WriteLine(title + " does not exist");
                Console.WriteLine("Press enter to return to member page"); //awww
                Console.ReadLine();
                MainPage.MemberMenu();
            }
        }

        public static void ReturnMovie() //works the same as Borrow movie
        {
            Console.Clear();
            Console.WriteLine("Enter Movie Title");
            string title = Console.ReadLine();

            if (Store.movies.Find(title))
            {
                if (MemberCollection.ReturnMovie(glob.fname, Store.movies.FindMovie(title)) && Store.movies.ReturnMovie(title))
                {
                    Console.WriteLine(title + " sucessfully returned");
                    Console.WriteLine("Press enter to return to member page");
                    Console.ReadLine();
                    MainPage.MemberMenu();
                }
                else
                {
                    Console.WriteLine("Unable to return " + title);
                    Console.WriteLine("Press enter to return to member page");
                    Console.ReadLine();
                    MainPage.MemberMenu();
                }
            }
            else
            {
                Console.WriteLine(title + " does not exist");
                Console.WriteLine("Press enter to return to member page");
                Console.ReadLine();
                MainPage.MemberMenu();
            }
        }

        public static void ListBorrowed() //lists borrowed movies to console
        {
            Member mem = MemberCollection.GetMember(glob.fname);
            foreach (Movie mov in mem.Rented) //i made rented a list so used a foreach, could easly be done with a for that iterates until array length though
            {
                Console.WriteLine(mov.title);//write using tostring override
            }

            MainPage.MemberMenu();

        }


        public static void Top10()
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();

            for (int i = 0; i < glob.TopArray.Length; i++) //this loop isn't necessary, it just clears all entries in the global array when top10 is called
            {                                              //Allows for the top 10 function to be run back to back to compare effects of borrowing a movie on the top 10
                glob.TopArray[i] = null;
            }


            Movie[] tops = Store.movies.ArrayMovies(); //calls ArrayMovies, which returns all nodes from BST in an array of movies

            for (int i = 0; i < tops.Length -1; i++) //bubble sort on array
            {
                for (int j = i+1; j < tops.Length; j++)
                {
                    if (tops[i] != null && tops[j] != null) //doesn't sort null values, Null represents the extra spaces in the array (has enough length to sort 40 movies by default this can be yeeted).
                    {
                        if (tops[i].timesBorrowed < tops[j].timesBorrowed) //compare
                        {
                            Movie tempMov = tops[i]; //swap the values and then iterate
                            tops[i] = tops[j];
                            tops[j] = tempMov;
                        }
                    }
                }
            }

            int k = 0; //k represents the number of movies written to console. Used to make sure only 10 are printed (no point in iterating through rest of array if 10 already printed)
            for (int i = 0; i < tops.Length && k < 10; i++) //iterates through tops which has been sorted with bubblesort. terminates if K will exceed array length or k is greater than 9 (ie 10 things have been printed).
            {
                if (tops[i] != null) //checks that movie isn't null, this would mean its one of the unsorted blank spots reserved if the BST gets larger
                {
                    Console.WriteLine((k+1)+".\t"+tops[i].title + " has been borrowed " + tops[i].timesBorrowed); //write movie to console
                    k++; //something was printed so iterate k
                }
            }

            Console.WriteLine("");
            //Console.WriteLine($"Execution Time: {watch.ElapsedTicks} ticks");
            MainPage.MemberMenu();
        }

        public static void MainMenu()
        {
            MainPage.MemberMenu();
        }
    }
}
