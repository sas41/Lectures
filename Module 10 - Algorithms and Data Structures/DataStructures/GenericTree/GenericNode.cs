using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTree
{
    public class GenericNode<T>
    {
        T Value { get; set; }
        List<GenericNode<T>> connections;

        public GenericNode(T val)
        {
            Value = val;
            connections = new List<GenericNode<T>>();
        }

        public GenericNode(T val, List<GenericNode<T>> subs)
        {
            Value = val;
            connections = subs;
        }

        public GenericNode<T> AddOneWay(GenericNode<T> newNode)
        {
            connections.Add(newNode);
            return newNode;
        }

        public GenericNode<T> AddOneWay(T newNodeVal)
        {
            GenericNode<T> newNode = new GenericNode<T>(newNodeVal);
            connections.Add(newNode);
            return newNode;
        }

        public GenericNode<T> AddTwoWay(GenericNode<T> newNode)
        {
            connections.Add(newNode);
            newNode.connections.Add(this);
            return newNode;
        }

        public GenericNode<T> AddTwoWay(T newNodeVal)
        {
            GenericNode<T> newNode = new GenericNode<T>(newNodeVal);
            connections.Add(newNode);
            newNode.connections.Add(this);
            return newNode;
        }
    }
}
