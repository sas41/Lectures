using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticFieldsPropertiesAndMethods
{
    class PersonV5
    {        
        ///////////////////////////////
        ///   STATIC STUFF BELOW    ///
        ///////////////////////////////
        static public int TotalCount { get; private set; }

        static private List<PersonV5> people;

        static public List<PersonV5> People
        {
            get { return people; }
            set { people = value; }
        }

        static PersonV5()
        {
            People = new List<PersonV5>();
        }

        static public void ChangeAllHeights(int newHeight)
        {
            foreach (var person in People)
            {
                person.Height = newHeight;
            }
        }

        static public string GetInfo(PersonV5 person)
        {
            return $"Name: {person.FirstName} {person.LastName}\nHeight: {person.Height}\nAge: {person.Age}\nSSN: {person.SSN}";
        }

        ///////////////////////////////
        /// NON STATIC STUFF BELOW  ///
        ///////////////////////////////

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


        public List<PersonV5> Friends { get; set; }


        public PersonV5()
        {
            Friends = new List<PersonV5>();
            TotalCount++;
            People.Add(this);
        }

        public PersonV5(string firstName, string lastName, int age, int height, string ssn) : this()
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Height = height;
            SSN = ssn;
        }

        public PersonV5(string firstName, string lastName, int age, int height, string ssn, List<PersonV5> friends) : this(firstName, lastName, age, height, ssn)
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
