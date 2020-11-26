using System;
using System.Collections.Generic;
using System.Text;

namespace CAB301_Ass1
{
    public class Member
    {

        private string firstName;
        public string FirstName //members first name
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        private string lastName;
        public string LastName //members last name
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        private string fullName;
        public string FullName //members fullname (derived field)
        {
            get
            {
                return fullName;
            }
            set
            {
                fullName = value;
            }
        }

        private string address;
        public string Address // Member address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        private string phone;
        public string Phone // Member phone number
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
            }
        }

        private int pin;
        public int Pin // Member pin
        {
            get
            {
                return pin;
            }
            set
            {
                pin = value;
            }
        }

        private List<Movie> rented;
        public List<Movie> Rented // Member rented movies
        {
            get
            {
                return rented;
            }
            set
            {
                rented = value;
            }
        }

        public Member(string firstName, string lastName, string address, string phone, int pin) //constructor used when creating a new member from CMD
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Phone = phone;
            Pin = pin;
            Rented = new List<Movie>(); //gonna store rented movies as a list to reduce jank later, didn't see anything in the spec saying i couldn't use a list for a member attribute.
            FullName = firstName + lastName; //derived attribute
        }

        public Member(string firstName, string lastName, string address, string phone, int pin, List<Movie> rented) //constructor used to create test members 
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Phone = phone;
            Pin = pin;
            Rented = rented; //gonna store rented movies as a list to reduce jank later, didn't see anything in the spec saying i couldn't use a list for a member attribute.
            FullName = firstName + lastName; //derived attribute
        }

        public Member() //constructor used to create null members, used to fill out remaining half of member collection so when new members are added by staff the null ones get overwritten first
        {
            FirstName = null;
            LastName = null;
            Address = null;
            Phone = null;
            Pin = 0;
            Rented = new List<Movie>(); //gonna store rented movies as a list to reduce jank later, didn't see anything in the spec saying i couldn't use a list for a member attribute.
            FullName = null;
        }

        public override string ToString()
        {
            return string.Format("Added Member:\n\t Name: {0} {1} \n\t Address: {2}\n\t Phone: {3}\n\nPress ENTER to continue", FirstName, LastName, Address, Phone);
        }
    }
}
