using System;

namespace CodeWars.Class
{
    /// <summary>
    /// Welcome.In this kata, you are asked to square every digit of a number.
    /// For example, if we run 9119 through the function, 811181 will come out, because 92 is 81 and 12 is 1.
    /// Note: The function accepts an integer and returns an integer
    /// </summary>
    public class SquareDigits
    {
        public static int Solution(int numbers)
        {
            string nums = numbers.ToString();
            string returnNumbers = "";
            foreach (char num in nums)
            {
                if (Char.IsLetter(num))
                    returnNumbers += "-";
                else if (Char.IsNumber(num))
                    returnNumbers += (Convert.ToInt32(num.ToString()) * Convert.ToInt32(num.ToString())).ToString();
            }

            return Convert.ToInt32(returnNumbers);
        }
    }
}






