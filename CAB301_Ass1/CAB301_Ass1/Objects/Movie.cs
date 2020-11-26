using System;
using System.Collections.Generic;
using System.Text;

namespace CAB301_Ass1
{
    public class Movie
    {
        //movie title
        private string Title;
        public string title
        {
            get
            {
                return Title;
            }
            set
            {
                Title = value;
            }
        }

        private string[] Starring; //string of actors
        public string[] starring
        {
            get
            {
                return Starring;
            }
            set
            {
                Starring = value;
            }
        }

        private string[] Director;//movie director
        public string[] director
        {
            get
            {
                return Director;
            }
            set
            {
                Director = value;
            }
        }

        private int Duration;//Length of movie in minutes
        public int duration
        {
            get
            {
                return Duration;
            }
            set
            {
                Duration = value;
            }
        }

        private Genre Genre; //Movie Genre, is ENUM
        public Genre genre
        {
            get
            {
                return Genre;
            }
            set
            {
                Genre = value;
            }
        }

        private Classification Classification;//Classification, Is also ENUM
        public Classification classification
        {
            get
            {
                return Classification;
            }
            set
            {
                Classification = value;
            }
        }

        private int ReleaseDate;//Movie release date
        public int releaseDate
        {
            get
            {
                return ReleaseDate;
            }
            set
            {
                ReleaseDate = value;
            }
        }

        private int TimesBorrowed;//Int representing amount of times movie has been borrowed
        public int timesBorrowed
        {
            get
            {
                return TimesBorrowed;
            }
            set
            {
                TimesBorrowed = value;
            }
        }

        private int Inventory;//Int representing number of movie left in store.
        public int inventory
        {
            get
            {
                return Inventory;
            }
            set
            {
                Inventory = value;
            }
        }

        public Movie(string title, string[] starring, string[] director, int runTime, Genre genre, Classification classificaction, int releaseDate, int stock) //constructor used to create movies from CMD
        {
            Title = title;
            Director = director;
            Starring = starring;
            Duration = runTime;
            Genre = genre;
            Classification = classificaction;
            ReleaseDate = releaseDate;
            Inventory = stock;
            TimesBorrowed = 0;
        }

        public Movie(string title, string[] starring, string[] director, int runTime, Genre genre, Classification classificaction, int releaseDate, int stock, int times) //constructor used to create movies for test data, has extra info
        {
            Title = title;
            Director = director;
            Starring = starring;
            Duration = runTime;
            Genre = genre;
            Classification = classificaction;
            ReleaseDate = releaseDate;
            Inventory = stock;
            TimesBorrowed = times;
        }

        public Movie()
        {
            Title = null;
        }


        public override string ToString() //to string override
        {
            string Dir = ""; //compile all directors into comma seperated string from array
            foreach (string str in Director) {
                Dir += str + ", ";
            }

            Dir = Dir.Remove(Dir.Length - 2); //remove last 2 chars as they are a space and ,

            string Star = ""; //repeate process for stars
            foreach (string str in Starring)
            {
                Star += str + ", ";
            }

            Star = Star.Remove(Star.Length - 2);

            //return formatted string to be written
            return string.Format("\n\t Title: {0}\n\t Starring: {1}\n\t Director: {2}\n\t Genre: {3}\n\t Classification: {4}\n\t Duration: {5}\n\t Release Date: {6}\n\t Copies Available: {7}\n\t Times Rented: {8}\n", Title, Star, Dir, Genre, Classification, Duration, ReleaseDate, Inventory, TimesBorrowed);
        }
    }
}
