using LearningAlgorithms.Core.DataStructures;
using System;
using Xunit;

namespace LearningAlgorithms.Tests.BinarySearchTree
{
    public partial class BinarySearchTreeTests
    {
        [Fact]
        public void Contains_DoesContainValue_ReturnsTrue()
        {
            CreateSUT();
            PopulateExampleSUT();

            var result = SUT.Contains(5);

            Assert.True(result);
        }

        [Fact]
        public void Contains_DoesntContainValue_ReturnsFalse()
        {
            CreateSUT();
            PopulateExampleSUT();

            var result = SUT.Contains(6);

            Assert.False(result);
        }

        [Fact]
        public void Contains_WhenNoRoot_ReturnsFalse()
        {
            CreateSUT();

            var result = SUT.Contains(6);

            Assert.False(result);
        }
    }
}
