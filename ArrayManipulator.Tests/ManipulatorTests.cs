using System;
using System.Collections.Generic;
using Xunit;

namespace ArrayManipulator.Tests
{
    public class ManipulatorTests
    {
        [Fact]
        public void DividesEquallyTest()
        {
            var expected = new List<int[]> { new int[] { 1, 2 },
                                             new int[] { 3, 4 },
                                             new int[] { 5, 6 }};
            var actual = Manipulator.Split(new int[] { 1, 2, 3, 4, 5, 6 }, 3);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DividesEquallyWithRemainderTest()
        {
            var expected = new List<int[]> { new int[] { 1, 2 },
                                             new int[] { 3, 4 },
                                             new int[] { 5 }};
            var actual = Manipulator.Split(new int[] { 1, 2, 3, 4, 5 }, 3);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void HandleDivisorLargerThanArrayLengthTest()
        {
            Assert.Throws<ArgumentException>(
                () => Manipulator.Split(new int[] { 1, 2, 3, 4, 5, 6 }, 100));
        }

        [Fact]
        public void AvoidsBadInputArrayTest()
        {
            Assert.Throws<ArgumentException>(
                () => Manipulator.Split(new int[] { }, 3));
        }

        [Fact]
        public void AvoidsBadDivisorTest()
        {
            Assert.Throws<ArgumentException>(
                () => Manipulator.Split(new int[] { 1, 2, 3 }, -4));
        }
    }
}
