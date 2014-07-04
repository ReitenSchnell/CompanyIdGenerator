namespace FieldsGenerator.Logic
{
    public static class SweTaxCode
    {
        public static string Generate()
        {
            return "SE" + RandomNumber.GetNumber(10, 1, 9) + "01";
        }
    }
}