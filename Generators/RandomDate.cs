using System;

namespace Generators
{
    public static class RandomDate
    {
        private static readonly DateTime Start = new DateTime(1890, 1, 1);
        private static readonly Random Gen = new Random();
        public static DateTime GetDate()
        {
            var range = (DateTime.Today - Start).Days;
            return Start.AddDays(Gen.Next(range));
        }
    }
}