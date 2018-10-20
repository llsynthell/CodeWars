using System.Linq;

namespace CodeWars.Class
{
    /// <summary>
    ///  Take 2 strings s1 and s2 including only letters from a to z. Return a new sorted string, the longest possible, containing distinct letters,
    ///  each taken only once - coming from s1 or s2.
    ///  #Examples:
    ///  Argument 1 = abcde
    ///  Argument 2 = abcde
    ///  Expected Value = abcde
    /// </summary>
    public class TwoToOne
    {
        public static string Solution(string s1, string s2)
        {
             return new string((s1 + s2).OrderBy(c => c).Distinct().ToArray());
        }
    }
}
