using System;

namespace CodeWars.Class
{
    public class SquareDigits
    {
        /// <summary>
        /// Takes in a number (example: 99)
        /// Squares each individual number (example: 81, 81)
        /// Puts the numbers together and returns the full int (example: 8181).
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns>int</returns>
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
