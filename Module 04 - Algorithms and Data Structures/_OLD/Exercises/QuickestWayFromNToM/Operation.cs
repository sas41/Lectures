using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickestWayFromNToM
{
    class Operation
    {
        public Operation Previous { get; private set; }
        public string OpType { get; private set; }
        public int Result { get; private set; }

        public Operation(Operation prev, string op)
        {
            Previous = prev;
            OpType = op;

            if (OpType == "+1")
            {
                Result = Previous.Result + 1;
            }
            else if(OpType == "+2")
            {
                Result = Previous.Result + 2;
            }
            else
            {
                Result = Previous.Result * 2;
            }
        }
        public Operation(int start)
        {
            Result = start;

            Previous = null;
            OpType = "";
        }

        public override string ToString()
        {
            if (Previous != null)
            {
                return $"{Previous.ToString()} {OpType} => {Result}"; 
            }
            return $"{Result}";
        }
    }
}
