﻿using LearningAlgorithms.Core.DataStructures;
using System;
using Xunit;

namespace LearningAlgorithms.Tests.BinarySearchTree
{
    public partial class BinarySearchTreeTests
    {
        [Fact]
        public void Remove_NoRightChild()
        {
            CreateSUT();
            PopulateExampleSUT();

            SUT.Remove(20);

            var result = SUT.Preorder;

            Assert.Collection(
                result,
                x => Assert.Equal(90, x),
                x => Assert.Equal(50, x),
                x => Assert.Equal(25, x),
                x => Assert.Equal(5, x),
                x => Assert.Equal(75, x),
                x => Assert.Equal(66, x),
                x => Assert.Equal(80, x),
                x => Assert.Equal(150, x),
                x => Assert.Equal(95, x),
                x => Assert.Equal(92, x),
                x => Assert.Equal(111, x),
                x => Assert.Equal(175, x),
                x => Assert.Equal(166, x),
                x => Assert.Equal(200, x));
        }

        [Fact]
        public void Remove_RightChildHasNoLeftChild()
        {
            CreateSUT();
            PopulateExampleSUT();

            SUT.Remove(75);

            var result = SUT.Preorder;

            Assert.Collection(
                result,
                x => Assert.Equal(90, x),
                x => Assert.Equal(50, x),
                x => Assert.Equal(20, x),
                x => Assert.Equal(5, x),
                x => Assert.Equal(25, x),
                x => Assert.Equal(80, x),
                x => Assert.Equal(66, x),
                x => Assert.Equal(150, x),
                x => Assert.Equal(95, x),
                x => Assert.Equal(92, x),
                x => Assert.Equal(111, x),
                x => Assert.Equal(175, x),
                x => Assert.Equal(166, x),
                x => Assert.Equal(200, x));
        }

        [Fact]
        public void Remove_RightChildDoesHaveLeftChild()
        {
            CreateSUT();
            PopulateExampleSUT();

            SUT.Remove(50);

            var result = SUT.Preorder;

            Assert.Collection(
                result,
                x => Assert.Equal(90, x),
                x => Assert.Equal(66, x),
                x => Assert.Equal(20, x),
                x => Assert.Equal(5, x),
                x => Assert.Equal(25, x),
                x => Assert.Equal(75, x),
                x => Assert.Equal(80, x),
                x => Assert.Equal(150, x),
                x => Assert.Equal(95, x),
                x => Assert.Equal(92, x),
                x => Assert.Equal(111, x),
                x => Assert.Equal(175, x),
                x => Assert.Equal(166, x),
                x => Assert.Equal(200, x));
        }
    }
}
