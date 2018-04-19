namespace Generators
{
    public class FinPersonalCode
    {
        private static int checksum;
        private static string separator;
        public static string Generate()
        {
            var date = RandomDate.GetDate();
            if (date.Year < 1900)
            {
                separator = "+";
            }
            else if (date.Year >= 1900 && date.Year < 2000)
            {
                separator = "-";
            }
            else if (date.Year >= 2000)
            {
                separator = "A";
            }
            var number = date.ToString("ddMMyy") + separator + RandomNumber.GetNumber(3, 1, 9);
            var arr = number.ToCharArray();
            checksum = (int)char.GetNumericValue(arr[0]) +
                        (int)char.GetNumericValue(arr[1]) +
                        (int)char.GetNumericValue(arr[2]) +
                        (int)char.GetNumericValue(arr[3]) +
                        (int)char.GetNumericValue(arr[4]) +
                        (int)char.GetNumericValue(arr[5]) +
                        (int)char.GetNumericValue(arr[7]) +
                        (int)char.GetNumericValue(arr[8]) +
                        (int)char.GetNumericValue(arr[9]) ;
            checksum = checksum % 31;
            return number+NumeralSystem.DecimalToArbitrarySystem(checksum, 31);
        }
    }
}