using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationDemonstration
{
    class Person
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length > 2 && value == value.ToUpper())
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentException("Name must be 3 characters or more, all UPPERCASE!");
                }
            }
        }
    }
}
