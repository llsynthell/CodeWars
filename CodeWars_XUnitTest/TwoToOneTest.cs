using CodeWars.Class;
using Xunit;

namespace CodeWars_XUnitTest
{
    public class TwoToOneTest
    {
        [Theory]
        [InlineData("abcd", "aabc", "abdd")]
        [InlineData("abcd", "cbaa", "ddba")]
        public void IsTwoToOne_(string actual, string testA, string testB)
        {
            Assert.Equal(actual, TwoToOne.Solution(testA, testB));
        }

        [Theory]
        [InlineData("abcd", "aab", "eft")]
        [InlineData("4abcd", "4aaa", "3bbb")]
        public void IsTwoToOne_NotEqual_ReturnFalsee(string actual, string testA, string testB)
        {
            Assert.NotEqual(actual, TwoToOne.Solution(testA, testB));
        }
    }
}