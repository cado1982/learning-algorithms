using LearningAlgorithms.Core.DataStructures;
using System;
using Xunit;

namespace LearningAlgorithms.Tests.BinarySearchTree
{
    public partial class BinarySearchTreeTests
    {
        private BinarySearchTree<int> SUT;

        private void PopulateExampleSUT()
        {
            SUT.Root = new BinaryTreeNode<int>(90);
            SUT.Root.Left = new BinaryTreeNode<int>(50);
            SUT.Root.Right = new BinaryTreeNode<int>(150);

            SUT.Root.Left.Left = new BinaryTreeNode<int>(20);
            SUT.Root.Left.Right = new BinaryTreeNode<int>(75);

            SUT.Root.Left.Left.Left = new BinaryTreeNode<int>(5);
            SUT.Root.Left.Left.Right = new BinaryTreeNode<int>(25);

            SUT.Root.Left.Right.Left = new BinaryTreeNode<int>(66);
            SUT.Root.Left.Right.Right = new BinaryTreeNode<int>(80);

            SUT.Root.Right.Left = new BinaryTreeNode<int>(95);
            SUT.Root.Right.Right = new BinaryTreeNode<int>(175);
                     
            SUT.Root.Right.Left.Left = new BinaryTreeNode<int>(92);
            SUT.Root.Right.Left.Right = new BinaryTreeNode<int>(111);
                     
            SUT.Root.Right.Right.Left = new BinaryTreeNode<int>(166);
            SUT.Root.Right.Right.Right = new BinaryTreeNode<int>(200);


            /*
                                     90
                       50                           150
                20            75            95              175          
             5      25     66     80     92     111     166     200

             */
        }

        private void CreateSUT(BinaryTreeNode<int> root)
        {
            SUT = new BinarySearchTree<int>();
            SUT.Root = root;
        }

        private void CreateSUT()
        {
            SUT = new BinarySearchTree<int>();
        }
    }
}
