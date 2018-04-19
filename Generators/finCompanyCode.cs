namespace Generators
{
    public static class FinCompanyCode
    {
        private static int checksum;
        public static string Generate()
        {
            var code = RandomNumber.GetNumber(7, 1, 9);
            var arr = code.ToCharArray();

            checksum = (int) char.GetNumericValue(arr[0])*7 +
                        (int) char.GetNumericValue(arr[1])*9 +
                        (int) char.GetNumericValue(arr[2])*10 +
                        (int) char.GetNumericValue(arr[3])*5 +
                        (int) char.GetNumericValue(arr[4])*8 +
                        (int) char.GetNumericValue(arr[5])*4 +
                        (int) char.GetNumericValue(arr[6])*2;
            checksum = checksum%11;
            switch (checksum)
            {
                case 0:
                    return code + "-" + checksum;
                case 1:
                    checksum = 0;
                    return code + "-" + checksum;
                default:
                    return code + "-" + (11-checksum);
            }
        }
    }
}