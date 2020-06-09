using Algorithms.CodingChallangeOne;
using Xunit;

namespace Algorithms.Tests
{
    public class RecursionAlgorithmTest
    {
        private readonly RecursionAlgorithm _standardAlgorithm;

        public RecursionAlgorithmTest()
        {
            _standardAlgorithm = new RecursionAlgorithm();
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 2, 8)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 3, 12)]
        public void Recursion_Algorithm_Should_Returns_Valid_Result(int[] data, int k, int expectedResult)
        {
            int result = _standardAlgorithm.Solution(data, k);
            Assert.Equal(expectedResult, result);
        }
    }
}
