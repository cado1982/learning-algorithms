using System;
using System.Collections.Generic;
using System.Text;

namespace LearningAlgorithms.Core.DataStructures
{
    /// <summary>
    /// A binary tree node differs from a regular node in that it can only have maximum of 2 children (left and right).
    /// </summary>
    /// <typeparam name="T">The type of value this node contains</typeparam>
    public class BinaryTreeNode<T> : Node<T>
    {
        public BinaryTreeNode() : base() 
        {

        }

        public BinaryTreeNode(T value) : base(value, null) 
        {
        
        }

        public BinaryTreeNode(T value, BinaryTreeNode<T> left, BinaryTreeNode<T> right)
        {
            Value = value;
            Neighbors = new NodeList<T>(2)
            {
                [0] = left,
                [1] = right
            };
        }

        public BinaryTreeNode<T> Left
        {
            get
            {
                if (Neighbors == null)
                {
                    return null;
                }
                else
                {
                    return (BinaryTreeNode<T>)Neighbors[0];
                }
            }
            set
            {
                if (Neighbors == null)
                {
                    Neighbors = new NodeList<T>(2);
                }

                Neighbors[0] = value;
            }
        }

        public BinaryTreeNode<T> Right
        {
            get
            {
                if (Neighbors == null)
                {
                    return null;
                }
                else
                {
                    return (BinaryTreeNode<T>)Neighbors[1];
                }
            }
            set
            {
                if (Neighbors == null)
                {
                    Neighbors = new NodeList<T>(2);
                }

                Neighbors[1] = value;
            }
        }

        public IEnumerable<T> Preorder()
        {
            yield return Value;

            if (Left != null)
            {
                foreach (var value in Left.Preorder())
                {
                    yield return value;
                }
            }

            if (Right != null)
            {
                foreach (var value in Right.Preorder())
                {
                    yield return value;
                }
            }
        }

        public IEnumerable<T> Inorder()
        {
            if (Left != null)
            {
                foreach (var value in Left.Inorder())
                {
                    yield return value;
                }
            }

            yield return Value;

            if (Right != null)
            {
                foreach (var value in Right.Inorder())
                {
                    yield return value;
                }
            }
        }

        public IEnumerable<T> Postorder()
        {
            if (Left != null)
            {
                foreach (var value in Left.Postorder())
                {
                    yield return value;
                }
            }
            if (Right != null)
            {
                foreach (var value in Right.Postorder())
                {
                    yield return value;
                }
            }

            yield return Value;
        }
    }
}
