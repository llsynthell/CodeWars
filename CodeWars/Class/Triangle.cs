public class Triangle
{
    // Checks to see if 3 sides' lengths could create a triangle
    // Assume that the customer input cannot be negatives
    public static bool IsTriangleWithPositiveSides(int a, int b, int c) => 
        a > 0 && b > 0 && c > 0 && a + b > c && b + c > a && c + a > b;
}