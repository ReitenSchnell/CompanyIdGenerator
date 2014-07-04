namespace CompanyIdGenerator
{
    public static class FinTaxCode
    {
        public static string Generate()
        {
            return "FI" + RandomNumber.GetNumber(8, 1, 9); 
        }
    }
}