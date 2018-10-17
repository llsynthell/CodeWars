using System;
using System.Collections.Generic;
using Xunit;

namespace CodeWars_XUnitTest
{
    public class TriangleTest
    {
        // Checking for valid positive numbers
        [Theory]
        [InlineData(10,10,10)]
        [InlineData(4,5,6)]
        [InlineData(5,6,4)]
        [InlineData(6,5,4)]
        public void IsTriangle_ValidPostiveNumbers_ReturnsTrue(int x, int y, int z)
        {
            Assert.True(Triangle.IsTriangleWithPositiveSides(x, y, z));
        }

        // Checking for invalid positive numbers
        [Theory]
        [InlineData(7,2,4)]
        [InlineData(2,4,7)]
        [InlineData(4,7,2)]
        [InlineData(int.MaxValue, int.MaxValue, int.MaxValue)]
        public void IsTriangle_NotValidPositiveNumbers_ReturnsFalse(int x, int y, int z)
        {
            Assert.False(Triangle.IsTriangleWithPositiveSides(x, y, z));
        }

        // Checking if there are negative numbers
        [Theory]
        [InlineData(-7, 2, 4)]
        [InlineData(7, -2, 4)]
        [InlineData(7, 2, -4)]
        [InlineData(-7, -2, 4)]
        [InlineData(-7, 2, -4)]
        [InlineData(7, -2, -4)]
        [InlineData(-7, -2, -4)]
        [InlineData(int.MinValue, int.MinValue, int.MinValue)]
        public void IsTriangle_InvalidNegativeNumbers_ReturnsFalse(int x, int y, int z)
        {
            Assert.False(Triangle.IsTriangleWithPositiveSides(x, y, z));
        }

        // Checking if any side contains zero
        [Theory]
        [InlineData(0,2,33)]
        [InlineData(2,33,0)]
        [InlineData(33,0,2)]
        [InlineData(0,0,33)]
        [InlineData(0,33,0)]
        [InlineData(33,0,0)]
        [InlineData(0,0,0)]
        public void IsTriangle_ContainsZero_ReturnsFalse(int x, int y, int z)
        {
            Assert.False(Triangle.IsTriangleWithPositiveSides(x, y, z));
        }

        // Checking the triangle inequality theorem
        [Theory]
        [InlineData(2,4,7)]
        [InlineData(4,7,2)]
        [InlineData(7,2,4)]
        public void IsTriangle_InequalityTheorem_ReturnsFalse(int x, int y, int z)
        {
            Assert.False(Triangle.IsTriangleWithPositiveSides(x, y, z));
        }
    }
}
