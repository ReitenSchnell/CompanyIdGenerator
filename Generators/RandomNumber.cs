using System;
using System.Globalization;

namespace Generators
{
    public static class RandomNumber
    {
        private static readonly Random randNum = new Random();
        private static string number;

        public static string GetNumber(int lenth, int lower, int upper)
        {
            number = string.Empty;
            for (var i = 0; i < lenth; i++)
            {
                number = number + GenNumber(lower, upper);
            }
            return number;
        }
        private static string GenNumber(int lower, int upper)
        {
            return randNum.Next(lower, upper).ToString(CultureInfo.InvariantCulture);
        }

    }
}