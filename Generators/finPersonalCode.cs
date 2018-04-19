using System;

namespace Generators
{
    public class FinPersonalCode
    {
        private static string separator;
        private const string checkStr = "0123456789ABCDEFHJKLMNPRSTUVWXY";
        public static string Generate()
        {
            var date = RandomDate.GetDate();
            var dateStr = date.ToString("ddMMyy");
            var randomStr = RandomNumber.GetNumber(3, 1, 9);
            var checksum = int.Parse(dateStr + randomStr) % 31;
            return dateStr + GetSeparator(date) + randomStr + checkStr[checksum];
        }

        private static string GetSeparator(DateTime date)
        {
            if (date.Year < 1900)
            {
                return "+";
            }
            if (date.Year >= 1900 && date.Year < 2000)
            {
                return "-";
            }
            return "A";
        }
    }
}