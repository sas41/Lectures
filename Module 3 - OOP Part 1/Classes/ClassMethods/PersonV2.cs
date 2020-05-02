using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethods
{
    class PersonV2
    {
        public string firstName;
        public string lastName;

        public int age;
        public int height;

        public string ssn;

        public void PrintInfo()
        {
            Console.WriteLine($"Hello, my name is {this.firstName} {this.lastName}");
            Console.WriteLine($"I am {this.height}cm tall and I am {this.age} years old.");
            Console.WriteLine($"My SSN is {this.ssn}");
        }
    }
}
