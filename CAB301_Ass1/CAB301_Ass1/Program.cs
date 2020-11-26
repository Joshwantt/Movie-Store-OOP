using System;

namespace CAB301_Ass1
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Begin Test Data
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string[] dir = { "Director", "Person", "Example" };
            string[] str = { "Generic", "Actor", "Example" };
            Movie movie = new Movie("Inception", dir, str, 125, Genre.Action, Classification.Mature, 2007, 67, 113);     //construct movie objects
            Movie movie2 = new Movie("Interstellar", dir, str, 134, Genre.SciFi, Classification.Mature, 2015, 44, 53);
            Movie movie3 = new Movie("Batman", dir, str, 126, Genre.Action, Classification.Mature, 2009, 8, 94);
            Movie movie4 = new Movie("Frozen", dir, str, 69, Genre.Animated, Classification.General, 2016, 85, 82);
            Movie movie5 = new Movie("Avengers", dir, str, 145, Genre.Action, Classification.ParentalGuidance, 2012, 8, 111);
            Movie movie6 = new Movie("Spiderman", dir, str, 113, Genre.Action, Classification.Mature, 2017, 21, 67);
            Movie movie7 = new Movie("Guardians of Galaxy", dir, str, 98, Genre.Action, Classification.Mature, 2014, 9, 78);
            Movie movie8 = new Movie("Waterboy", dir, str, 85, Genre.Comedy, Classification.ParentalGuidance, 2003, 23, 32);
            Movie movie9 = new Movie("50 shades", dir, str, 69, Genre.Action, Classification.MatureAccompanied, 2003, 69, 78); //;)
            Movie movie10 = new Movie("Bladerunner", dir, str, 185, Genre.SciFi, Classification.Mature, 2049, 32, 43);
            Movie movie11 = new Movie("Birdman", dir, str, 145, Genre.Drama, Classification.Mature, 2014, 6, 51);
            Movie movie15 = new Movie("Inside Out", dir, str, 96, Genre.Animated, Classification.General, 2014, 0, 73);
            Movie movie12 = new Movie("Deadpool", dir, str, 79, Genre.Action, Classification.Mature, 2016, 20, 8);
            Movie movie13 = new Movie("Matrix", dir, str, 89, Genre.Action, Classification.Mature, 2001, 36, 345);
            Movie movie14 = new Movie("Inglourious Bastards", dir, str, 110, Genre.Action, Classification.Mature, 2006, 29, 109);
            Movie movie16 = new Movie("Mission Impossible 1", dir, str, 125, Genre.Action, Classification.Mature, 2000, 17, 92);
            Movie movie17 = new Movie("Mission Impossible 2", dir, str, 125, Genre.Action, Classification.Mature, 2004, 32, 28);
            Movie movie18 = new Movie("Star Wars", dir, str, 130, Genre.SciFi, Classification.Mature, 1987, 9, 91);
            Movie movie19 = new Movie("Lord of the rings: Fellowship of the ring", dir, str, 213, Genre.Adventure, Classification.Mature, 2001, 4, 69);
            Movie movie20 = new Movie("Lord of the rings: The Two Towers", dir, str, 208, Genre.Adventure, Classification.Mature, 2003, 8, 74);
            Movie movie21 = new Movie("Lord of the rings: Return of the king", dir, str, 242, Genre.Adventure, Classification.Mature, 2005, 12, 23);


            Store.movies.Insert(movie); //insert objects into BST
            Store.movies.Insert(movie2);
            Store.movies.Insert(movie3);
            Store.movies.Insert(movie4);
            Store.movies.Insert(movie5);
            Store.movies.Insert(movie6);
            Store.movies.Insert(movie7);
            Store.movies.Insert(movie9);
            Store.movies.Insert(movie10);
            Store.movies.Insert(movie11);
            Store.movies.Insert(movie12);
            Store.movies.Insert(movie13);
            Store.movies.Insert(movie14);
            Store.movies.Insert(movie15);
            Store.movies.Insert(movie16);
            Store.movies.Insert(movie17);
            Store.movies.Insert(movie18);
            Store.movies.Insert(movie19);
            Store.movies.Insert(movie20);
            Store.movies.Insert(movie21);
            Store.movies.Insert(movie8);

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //End Test Data
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            MainPage.MainMenu();
        }
    }
}
