using System;

namespace FieldsGenerator.Logic
{
    public static class NumeralSystem
    {
        public static string DecimalToArbitrarySystem(long decimalNumber, int radix)
        {
            const int bitsInLong = 64;
            const string digits = "0123456789ABCDEFHJKLMNPRSTUVWXY";

            if (radix < 2 || radix > digits.Length)
                throw new ArgumentException("The radix must be >= 2 and <= " + digits.Length.ToString());

            if (decimalNumber == 0)
                return "0";

            var index = bitsInLong - 1;
            var currentNumber = Math.Abs(decimalNumber);
            var charArray = new char[bitsInLong];

            while (currentNumber != 0)
            {
                var remainder = (int)(currentNumber % radix);
                charArray[index--] = digits[remainder];
                currentNumber = currentNumber / radix;
            }

            var result = new String(charArray, index + 1, bitsInLong - index - 1);
            if (decimalNumber < 0)
            {
                result = "-" + result;
            }

            return result;
        }
    }
}