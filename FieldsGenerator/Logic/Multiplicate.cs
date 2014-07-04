using System;
using System.Globalization;

namespace FieldsGenerator.Logic
{
    public static class Multiplicate
    {
        public static int Exec(char a, int b)
        {
            var result = (int)Char.GetNumericValue(a) * b;
            if (result <= 9)
            {
                return result;
            }
            var arr = result.ToString(CultureInfo.InvariantCulture).ToCharArray();
            result = (int) Char.GetNumericValue(arr[0]) +
                     (int) Char.GetNumericValue(arr[1]); 
            return result;
        }
    }
}