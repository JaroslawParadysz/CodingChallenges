using Algorithms.CodingChallangeOne;
using Xunit;

namespace Algorithms.Tests
{
    public class CodingChallangeOneTest
    {
        private readonly RecursionAlgorithm _codingChallangeOne;

        public CodingChallangeOneTest()
        {
            _codingChallangeOne = new RecursionAlgorithm();
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 2, 8)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 3, 12)]
        public void Should_Returns_Valid_Result(int[] data, int k, int expectedResult)
        {
            int result = _codingChallangeOne.Solution(data, k);
            Assert.Equal(expectedResult, result);
        }
    }
}
