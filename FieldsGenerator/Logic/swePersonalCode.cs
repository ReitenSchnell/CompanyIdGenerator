using System;
using System.Globalization;

namespace FieldsGenerator.Logic
{
    public class SwePersonalCode
    {
        private static string _checksum;
        private static string _separator;
        public static string Generate()
        {
            var date = RandomDate.GetDate();
            var age = DateTime.Today.Year - date.Year;
            _separator = age < 100 ? "-" : "+";
            var number = date.ToString("yyMMdd") + _separator + RandomNumber.GetNumber(3, 1, 9);
            var arr = number.ToCharArray();
            var checksum = Multiplicate.Exec(arr[0], 2) +
                           Multiplicate.Exec(arr[1], 1) +
                           Multiplicate.Exec(arr[2], 2) +
                           Multiplicate.Exec(arr[3], 1) +
                           Multiplicate.Exec(arr[4], 2) +
                           Multiplicate.Exec(arr[5], 1) +
                           Multiplicate.Exec(arr[7], 2) +
                           Multiplicate.Exec(arr[8], 1) +
                           Multiplicate.Exec(arr[9], 2);
            var s = checksum.ToString(CultureInfo.InvariantCulture).ToCharArray();
            var sum = 10 - (int)Char.GetNumericValue(s[1]);
            switch (sum)
            {
                case 10:
                    _checksum = 0.ToString(CultureInfo.InvariantCulture);
                    break;
                default:
                    _checksum = sum.ToString(CultureInfo.InvariantCulture);
                    break;
            }
            return number + _checksum;
        }
    }
}