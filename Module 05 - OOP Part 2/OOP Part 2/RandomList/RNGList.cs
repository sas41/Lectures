using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomList
{
    class RNGList : ArrayList
    {
        public string RandomString()
        {
            Random rng = new Random();
            int index = rng.Next(this.Count);
            string result = this[index].ToString();
            this.RemoveAt(index);
            return result;
        }
    }
}
