using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearningAlgorithms.Core.DataStructures
{
    public class BinarySearchTree<T> : IEnumerable<T>, ICollection<T> where T : struct
    {
        public BinaryTreeNode<T> Root { get; internal set; }
        private IComparer<T> _comparer;

        public bool IsReadOnly => false;

        public BinarySearchTree()
        {
            _comparer = Comparer<T>.Default;
        }

        public BinarySearchTree(IComparer<T> comparer)
        {
            _comparer = comparer;
        }

        public void Clear()
        {
            Root = null;
        }

        public IEnumerator<T> GetEnumerator()
        {
            if (Root == null) yield break;

            foreach (var value in Root.Preorder())
            {
                yield return value;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public void Add(T value)
        {
            var newNode = new BinaryTreeNode<T>(value);
            var currentNode = Root;
            BinaryTreeNode<T> currentParent = null;
            int comparisonResult;

            while (currentNode != null)
            {
                comparisonResult = _comparer.Compare(newNode.Value, currentNode.Value);

                if (comparisonResult == 0)
                {
                    // Value already exists, do nothing
                    return;
                }
                else if (comparisonResult < 0)
                {
                    currentParent = currentNode;
                    currentNode = currentNode.Left;
                }
                else if (comparisonResult > 0)
                {
                    currentParent = currentNode;
                    currentNode = currentNode.Right;
                }
            }

            if (currentParent == null)
            {
                Root = newNode;
            }
            else
            {
                comparisonResult = _comparer.Compare(newNode.Value, currentParent.Value);

                if (comparisonResult < 0)
                {
                    currentParent.Left = newNode;
                }
                else if (comparisonResult > 0)
                {
                    currentParent.Right = newNode;
                }
            }
        }

        public bool Contains(T value)
        {
            if (Root == null) return false;

            var enumerable = Root.Preorder();

            foreach (var node in enumerable)
            {
                if (_comparer.Compare(value, node) == 0) return true;
            }

            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            if (Root == null) return false;

            var currentNode = Root;
            BinaryTreeNode<T> parentNode = null;

            var comparisonResult = _comparer.Compare(currentNode.Value, item);

            while (comparisonResult != 0)
            {
                if (comparisonResult > 0)
                {
                    parentNode = currentNode;
                    currentNode = currentNode.Left;
                }
                else if (comparisonResult < 0)
                {
                    parentNode = currentNode;
                    currentNode = currentNode.Right;
                }

                if (currentNode == null)
                {
                    return false;
                }
                else
                {
                    comparisonResult = _comparer.Compare(currentNode.Value, item);
                }
            }

            if (currentNode.Right == null)
            {
                if (parentNode == null)
                {
                    Root = currentNode.Left;
                }
                else
                {
                    comparisonResult = _comparer.Compare(parentNode.Value, currentNode.Value);
                    if (comparisonResult > 0)
                    {
                        parentNode.Left = currentNode.Left;
                    }
                    else if (comparisonResult < 0)
                    {
                        parentNode.Right = currentNode.Left;
                    }
                }
            }
            else if (currentNode.Right.Left == null)
            {
                currentNode.Right.Left = currentNode.Left;

                if (parentNode == null)
                    Root = currentNode.Right;
                else
                {
                    comparisonResult = _comparer.Compare(parentNode.Value, currentNode.Value);
                    if (comparisonResult > 0)
                        parentNode.Left = currentNode.Right;
                    else if (comparisonResult < 0)
                        parentNode.Right = currentNode.Right;
                }
            }
            else
            {
                BinaryTreeNode<T> leftmost = currentNode.Right.Left, lmParent = currentNode.Right;
                while (leftmost.Left != null)
                {
                    lmParent = leftmost;
                    leftmost = leftmost.Left;
                }

                lmParent.Left = leftmost.Right;

                leftmost.Left = currentNode.Left;
                leftmost.Right = currentNode.Right;

                if (parentNode == null)
                    Root = leftmost;
                else
                {
                    comparisonResult = _comparer.Compare(parentNode.Value, currentNode.Value);
                    if (comparisonResult > 0)
                        parentNode.Left = leftmost;
                    else if (comparisonResult < 0)
                        parentNode.Right = leftmost;
                }
            }

            return true;

        }

        public int Count
        {
            get { return Preorder.ToList().Count(); }
        }

        public IEnumerable<T> Preorder
        {
            get
            {
                if (Root == null)
                {
                    return Enumerable.Empty<T>();
                }

                return Root.Preorder();
            }
        }

        public IEnumerable<T> Inorder
        {
            get
            {
                if (Root == null)
                {
                    return Enumerable.Empty<T>();
                }

                return Root.Inorder();
            }
        }

        public IEnumerable<T> Postorder
        {
            get
            {
                if (Root == null)
                {
                    return Enumerable.Empty<T>();
                }

                return Root.Postorder();
            }
        }

        
    }
}
