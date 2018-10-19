using CodeWars.Class;
using Xunit;

namespace CodeWars_XUnitTest
{
    public class SquareDigitsTest
    {
        [Theory]
        [InlineData(811181, 9119)]
        [InlineData(1616,44)]
        [InlineData(4,-2)]
        [InlineData(1616,-44)]
        public void IsSquareDigits_Equal_ReturnTrue(int equivilent, int digitsToSquare)
        {
            Assert.Equal(equivilent, SquareDigits.Solution(digitsToSquare));
        }

        [Theory]
        [InlineData(83156161,9119)]
        [InlineData(1936,44)]
        public void IsSquareDigits_NotEqual_ReturnTrue(int evaluate, int digitsToSquare)
        {
            Assert.NotEqual(evaluate, digitsToSquare);
        }
    }
}
