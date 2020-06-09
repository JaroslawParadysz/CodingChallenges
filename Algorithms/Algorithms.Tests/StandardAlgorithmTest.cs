using Algorithms.CodingChallangeOne;
using Xunit;

namespace Algorithms.Tests
{
    public class StandardAlgorithmTest
    {
        private readonly StandardAlgorithm _standardAlgorithm;

        public StandardAlgorithmTest()
        {
            _standardAlgorithm = new StandardAlgorithm();
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 2, 8)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 3, 12)]
        [InlineData(new int[] { 2, 2, 1, 1, 1 }, 3, 4)]
        public void Standard_Algorithm_Should_Returns_Valid_Result(int[] data, int k, int expectedResult)
        {
            int result = _standardAlgorithm.Solution(data, k);
            Assert.Equal(expectedResult, result);
        }
    }
}
