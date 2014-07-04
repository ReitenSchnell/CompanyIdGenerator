using System;
using System.Globalization;

namespace FieldsGenerator.Logic
{
    public static class RandomNumber
    {
        private static readonly Random RandNum = new Random();
        private static string _number;

        public static string GetNumber(int lenth, int lower, int upper)
        {
            _number = string.Empty;
            for (var i = 0; i < lenth; i++)
            {
                _number = _number + GenNumber(lower, upper);
            }
            return _number;
        }
        private static string GenNumber(int lower, int upper)
        {
            return RandNum.Next(lower, upper).ToString(CultureInfo.InvariantCulture);
        }

    }
}