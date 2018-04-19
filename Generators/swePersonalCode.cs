using System;
using System.Globalization;
using System.Linq;

namespace Generators
{
    public class SwePersonalCode
    {
        public static string Generate()
        {
            var date = RandomDate.GetDate();
            var number = date.ToString("yyyyMMdd") + "-" + RandomNumber.GetNumber(3, 1, 9);
            var arr = number.ToCharArray().Skip(2).ToList();
            var currentChecksum = Multiplicate.Exec(arr[0], 2) +
                           Multiplicate.Exec(arr[1], 1) +
                           Multiplicate.Exec(arr[2], 2) +
                           Multiplicate.Exec(arr[3], 1) +
                           Multiplicate.Exec(arr[4], 2) +
                           Multiplicate.Exec(arr[5], 1) +
                           Multiplicate.Exec(arr[7], 2) +
                           Multiplicate.Exec(arr[8], 1) +
                           Multiplicate.Exec(arr[9], 2);
            var s = currentChecksum.ToString().ToCharArray();
            var sum = 10 - (int)char.GetNumericValue(s[1]);
            var checksumStr = sum == 10 ? 0.ToString() : sum.ToString();
            return number + checksumStr;
        }
    }
}