using LearningAlgorithms.Core.DataStructures;
using System;
using Xunit;

namespace LearningAlgorithms.Tests.BinarySearchTree
{
    public partial class BinarySearchTreeTests
    {
        [Fact]
        public void Add()
        {
            CreateSUT();
            PopulateExampleSUT();

            SUT.Add(62);

            Assert.Equal(62, SUT.Root.Left.Right.Left.Left.Value);
        }

        [Fact]
        public void Add_WhenDuplicateValue_DoNothing()
        {
            CreateSUT();
            PopulateExampleSUT();

            SUT.Add(75);

            Assert.Equal(15, SUT.Count);
        }

    }
}
