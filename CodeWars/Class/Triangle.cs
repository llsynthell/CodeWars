public class Triangle
{
    // Checks to see if 3 sides' lengths could create a triangle
    public static bool IsTriangleWithPositiveSides(int a, int b, int c) => 
        a > 0 && b > 0 && c > 0 && a + b > c && b + c > a && c + a > b;
}