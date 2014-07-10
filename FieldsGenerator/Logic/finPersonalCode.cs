using System;

namespace FieldsGenerator.Logic
{
    public class FinPersonalCode
    {
        private static int _checksum;
        private static string _separator;
        public static string Generate()
        {
            var date = RandomDate.GetDate();
            if (date.Year < 1900)
            {
                _separator = "+";
            }
            else if (date.Year >= 1900 && date.Year < 2000)
            {
                _separator = "-";
            }
            else if (date.Year >= 2000)
            {
                _separator = "A";
            }
            var number = date.ToString("ddMMyy") + _separator + RandomNumber.GetNumber(3, 1, 9);
            var arr = number.ToCharArray();
            _checksum = (int)Char.GetNumericValue(arr[0]) +
                        (int)Char.GetNumericValue(arr[1]) +
                        (int)Char.GetNumericValue(arr[2]) +
                        (int)Char.GetNumericValue(arr[3]) +
                        (int)Char.GetNumericValue(arr[4]) +
                        (int)Char.GetNumericValue(arr[5]) +
                        (int)Char.GetNumericValue(arr[7]) +
                        (int)Char.GetNumericValue(arr[8]) +
                        (int)Char.GetNumericValue(arr[9]) ;
            _checksum = _checksum % 31;
            return number+NumeralSystem.DecimalToArbitrarySystem(_checksum, 31);
        }
    }
}