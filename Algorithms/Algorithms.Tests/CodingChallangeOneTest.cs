using System;
using Xunit;

namespace Algorithms.Tests
{
    public class CodingChallangeOneTest
    {
        private readonly CodingChallangeOne _codingChallangeOne;

        public CodingChallangeOneTest()
        {
            _codingChallangeOne = new CodingChallangeOne();
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 2, 8)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 3, 12)]
        public void Should_Returns_Valid_Result(int[] data, int k, int expected)
        {
            int result = _codingChallangeOne.Solution(data, k);
            Assert.Equal(expected, result);
        }
    }
}