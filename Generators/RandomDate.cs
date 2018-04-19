using System;

namespace Generators
{
    public static class RandomDate
    {
        private static readonly Random gen = new Random();
        public static DateTime GetDate()
        {
            var start = new DateTime(1940, 1, 1);
            var end = DateTime.Today.AddYears(-16);
            var range = (end - start).Days;
            return start.AddDays(gen.Next(range));
        }
    }
}