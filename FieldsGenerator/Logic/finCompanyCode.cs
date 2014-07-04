using System;

namespace FieldsGenerator.Logic
{
    public static class FinCompanyCode
    {
        private static int _checksum;
        public static string Generate()
        {
            var code = RandomNumber.GetNumber(7, 1, 9);
            var arr = code.ToCharArray();
            //7   9   10   5    8     4    2
            _checksum = (int) Char.GetNumericValue(arr[0])*7 +
                        (int) Char.GetNumericValue(arr[1])*9 +
                        (int) Char.GetNumericValue(arr[2])*10 +
                        (int) Char.GetNumericValue(arr[3])*5 +
                        (int) Char.GetNumericValue(arr[4])*8 +
                        (int) Char.GetNumericValue(arr[5])*4 +
                        (int) Char.GetNumericValue(arr[6])*2;
            _checksum = _checksum%11;
            switch (_checksum)
            {
                case 0:
                    return code + "-" + _checksum;
                case 1:
                    _checksum = 0;
                    return code + "-" + _checksum;
                default:
                    return code + "-" + (11-_checksum);
            }
        }
    }
}