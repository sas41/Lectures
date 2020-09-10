using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class PersonV4
    {
        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (value.Length >= 2)
                {
                    firstName = value;
                }
                else
                {
                    throw new ArgumentException("First Name is not Long Enough!");
                }
            }
        }


        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (value.Length >= 2)
                {
                    lastName = value;
                }
                else
                {
                    throw new ArgumentException("Last Name is not Long Enough!");
                }
            }
        }


        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0)
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Age cannot be less than Zero.");
                }
            }
        }


        private int height;
        public int Height
        {
            get { return height; }
            set
            {
                if (value >= 30)
                {
                    height = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Height cannot be less than 30.");
                }
            }
        }


        private string ssn;
        public string SSN
        {
            get { return ssn; }
            set
            {
                if (value.Length == 10)
                {
                    ssn = value;
                }
                else
                {
                    throw new ArgumentException("SSN must be 10 characters long.");
                }
            }
        }


        public List<PersonV4> Friends { get; set; }


        public PersonV4()
        {
            Friends = new List<PersonV4>();
        }

        public PersonV4(string firstName, string lastName, int age, int height, string ssn) : this()
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Height = height;
            SSN = ssn;
        }

        public PersonV4(string firstName, string lastName, int age, int height, string ssn, List<PersonV4> friends) : this(firstName, lastName, age, height, ssn)
        {
            Friends = friends;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Hello, my name is {this.FirstName} {this.LastName}");
            Console.WriteLine($"I am {this.Height}cm tall and I am {this.Age} years old.");
            Console.WriteLine($"My SSN is {this.SSN}");
        }
    }
}
