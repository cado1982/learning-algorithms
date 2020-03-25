using System;
using System.Collections.Generic;
using System.Text;

namespace LearningAlgorithms.Core.DataStructures
{
    public class Node<T>
    {
        protected NodeList<T> Neighbors { get; set; }
        public T Value { get; set; }

        public Node() 
        {
        
        }
        
        public Node(T data) : this(data, null) 
        { 
        
        }

        public Node(T value, NodeList<T> neighbors)
        {
            Value = value;
            Neighbors = neighbors;
        }
    }
}
