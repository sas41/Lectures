using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTree
{
    class GenericTree<T>
    {
        public GenericNode<T> Root { get; set; }

        public GenericTree(T rootVal)
        {
            Root = new GenericNode<T>(rootVal);
        }
    }
}
