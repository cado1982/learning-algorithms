using System;
using System.Collections.Generic;
using System.Text;

namespace LearningAlgorithms.Core.DataStructures
{
    public class BinaryTree<T>
    {
        public BinaryTreeNode<T> Root { get; set; }

        public BinaryTree()
        {
            Root = null;
        }

        public virtual void Clear()
        {
            Root = null;
        }
    }
}
