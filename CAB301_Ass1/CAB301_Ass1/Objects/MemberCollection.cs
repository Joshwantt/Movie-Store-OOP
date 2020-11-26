using System;
using System.Collections.Generic;
using System.Text;

namespace CAB301_Ass1
{
    public class MemberCollection //i feel like this class is setup a little bit wrong
    {
        static string[] dir = { "Director", "Person", "Example" };
        static string[] str = { "Generic", "Actor", "Example" };

        static List<Movie> rented1 = new List<Movie>()  //don't panic, these lists only contain the movies rented by a member and could probably be put in another class, they're just for test data for a member :)
        {                                               //Just used so i didn't have to make another class to add to an array. I don't think the spec put limits on the datatypes for member attributes.
                                                        //MemberCollection is still an array of members, the list is an attribute of each member that contains what movies are rented.
                                                        //I could have made it a janky add like is already demonstrated at the bottom of this class but honestly running low on time
            new Movie("Inception", dir, str, 125, Genre.Action, Classification.Mature, 2007, 67, 33),
            new Movie("Lord of the rings: Fellowship of the ring", dir, str, 213, Genre.Adventure, Classification.Mature, 2001, 4, 69),
            new Movie("Lord of the rings: The Two Towers", dir, str, 208, Genre.Adventure, Classification.Mature, 2003, 8, 74),
            new Movie("Mission Impossible 1", dir, str, 125, Genre.Action, Classification.Mature, 2000, 17, 64),                            //Create dummy data of movies rented by member, for constructing members.
            new Movie("Waterboy", dir, str, 85, Genre.Comedy, Classification.ParentalGuidance, 2003, 23, 32),
            new Movie("Inside Out", dir, str, 96, Genre.Animated, Classification.General, 2014, 0, 21),
            new Movie("Avengers", dir, str, 145, Genre.Action, Classification.ParentalGuidance, 2012, 8, 111),
        };

        static List<Movie> Rented1()
        {
            return rented1;
        }

        static List<Movie> rented2 = new List<Movie>()
        {
            new Movie("Inception", dir, str, 125, Genre.Action, Classification.Mature, 2007, 67, 33),
            new Movie("Lord of the rings: Fellowship of the ring", dir, str, 213, Genre.Adventure, Classification.Mature, 2001, 4, 69),
            new Movie("Interstellar", dir, str, 134, Genre.SciFi, Classification.Mature, 2015, 44, 53),
            new Movie("Mission Impossible 1", dir, str, 125, Genre.Action, Classification.Mature, 2000, 17, 64),                            //more dummy data
            new Movie("Inglourious Bastards", dir, str, 110, Genre.Action, Classification.Mature, 2006, 29, 109),
            new Movie("Matrix", dir, str, 89, Genre.Action, Classification.Mature, 2001, 36, 345),
            new Movie("Spiderman", dir, str, 113, Genre.Action, Classification.Mature, 2017, 21, 67),
        };

        static List<Movie> Rented2()
        {
            return rented2;
        }

        static List<Movie> rented3 = new List<Movie>()
        {
            new Movie("Inception", dir, str, 125, Genre.Action, Classification.Mature, 2007, 67, 33),
            new Movie("Lord of the rings: Fellowship of the ring", dir, str, 213, Genre.Adventure, Classification.Mature, 2001, 4, 69),
            new Movie("Bladerunner", dir, str, 185, Genre.SciFi, Classification.Mature, 2049, 32, 43),
            new Movie("Mission Impossible 2", dir, str, 125, Genre.Action, Classification.Mature, 2004, 32, 28),                            //more dummy data
            new Movie("Inglourious Bastards", dir, str, 110, Genre.Action, Classification.Mature, 2006, 29, 109),
            new Movie("Star Wars", dir, str, 130, Genre.SciFi, Classification.Mature, 1987, 9, 92),
            new Movie("Spiderman", dir, str, 113, Genre.Action, Classification.Mature, 2017, 21, 67),
        };

        static List<Movie> Rented3()
        {
            return rented3;
        }

        static List<Movie> rented5 = new List<Movie>()
        {
            new Movie("Guardians of Galaxy", dir, str, 98, Genre.Action, Classification.Mature, 2014, 9, 78),
            new Movie("Lord of the rings: Fellowship of the ring", dir, str, 213, Genre.Adventure, Classification.Mature, 2001, 4, 69),
            new Movie("Lord of the rings: The Two Towers", dir, str, 208, Genre.Adventure, Classification.Mature, 2003, 8, 74),
            new Movie("Mission Impossible 1", dir, str, 125, Genre.Action, Classification.Mature, 2000, 17, 64),                            //more dummy data
            new Movie("Mission Impossible 2", dir, str, 125, Genre.Action, Classification.Mature, 2004, 32, 28),
            new Movie("Deadpool", dir, str, 79, Genre.Action, Classification.Mature, 2016, 20, 8),
            new Movie("Lord of the rings: Return of the king", dir, str, 242, Genre.Adventure, Classification.Mature, 2005, 12, 23),
        };

        static List<Movie> Rented5()
        {
            return rented5;
        }

        static public Member[] Members = new Member[10]     //declare array of members
        {
            new Member("Josh","Do","Address","Phone", 1111, Rented1()),     //construct prebaked members
            new Member("Josh","Dont","Address","Phone", 2222, Rented3()),   //uses those lists from above, the lists are just an attribute of movie.
            new Member("Josh","Could","Address","Phone", 3333, Rented2()),
            new Member("Josh","Wont","Address","Phone", 4444, Rented1()),
            new Member("Josh","Font","Address","Phone", 5555, Rented5()),
            new Member(), //if you add a new member from staff page it should populate these empty members first
            new Member(), //then it will override the first spot in the array forever :)
            new Member(), //these construct as a member will all fields null
            new Member(),
            new Member()
        };

        public static Member GetMember(string fullname) //returns member object when given member fullname
        {                                               //Can be used for determining if a member is valid and other things
            for (int i = 0; i < MemberCollection.Members.Length; i++) //iterate through member array
            {
                if (MemberCollection.Members[i].FullName == fullname)   //check if names match
                {
                    return MemberCollection.Members[i]; //if they match return the member
                }
            }
            return null; //if they don't return null
        }

        public static void PrintMembers() //debug code to check my add function
        {
            for (int i = 0; i < MemberCollection.Members.Length; i++)
            {
                Console.WriteLine(MemberCollection.Members[i]); //just prints out all members in the array to console.
            }
        }

        public static bool RentMovie(string fullname, Movie mov)    //returns bool about sucess of renting movie. takes fullname and movie object as input
        {
            for (int i = 0; i < MemberCollection.Members.Length; i++) //iterates through all members
            {
                if (MemberCollection.Members[i].FullName == fullname) //checks name compare
                {
                    MemberCollection.Members[i].Rented.Add(mov); //if true adds the movie to the members rented list
                    return true;                                 //this is the only reason why i used a list for movies rented by member, just to reduce jank here so the list didn't have the same size constraints as my array does
                }                                                
            }
            return false;
        }

        public static bool ReturnMovie(string fullname, Movie mov)  //returns bool for return passing/failing
        {
            for (int i = 0; i < MemberCollection.Members.Length; i++) //iterates through member array
            {
                if (MemberCollection.Members[i].FullName == fullname) //checks for name compare
                {
                    for (int j = 0; j < MemberCollection.Members[i].Rented.Count; j++) { //iterates through every movie rented by the member
                        if (MemberCollection.Members[i].Rented[j].title == mov.title) { //if movie title and input title match
                            MemberCollection.Members[i].Rented.RemoveAt(j);//remove the movie at index j
                            return true;
                        }
                    }
                }

            }
            return false;
        }



        public static bool GetPass(string fullname, int pin) //function tests if password is correct
        {
            for (int i = 0; i < MemberCollection.Members.Length; i++) //iterate through member array
            {
                if (MemberCollection.Members[i].FullName == fullname && MemberCollection.Members[i].Pin == pin) //check if member name and pin are equal
                {
                    return true; //if both are true correct creds supplied
                }
            }
            return false; //else bad login attempt
        }

        public static string GetPhone(string fullname)
        {
            for (int i = 0; i < MemberCollection.Members.Length; i++) //iterate through member array
            {
                if (MemberCollection.Members[i].FullName == fullname) //check for name compare
                {
                    return fullname+"'s phone number is "+MemberCollection.Members[i].Phone; //return string containing member phone number
                }
            }
            return "Member is not registered"; //if compare not met user is not registered
        }


        public static bool Add(Member member) //"adds" a member to the array,
        {                                     //Arrays are fixed length so this function makes some choices
            for (int i = 0; i < MemberCollection.Members.Length; i++)   //iterate through all members in array
            {
                if (MemberCollection.Members[i].FirstName == null) //check if their first name is not null. Half of the test members have all propities set to null
                {
                    MemberCollection.Members[i] = member; //if it is null set the current member to the member that wants to be added
                    return true;
                }
            }
            MemberCollection.Members[0] = member;   //if no null members its always going to override the first member
            return true;
        }
    }
}
