using System;

namespace Generators
{
    public static class RandomDate
    {
        private static readonly DateTime start = new DateTime(1890, 1, 1);
        private static readonly Random gen = new Random();
        public static DateTime GetDate()
        {
            var range = (DateTime.Today - start).Days;
            return start.AddDays(gen.Next(range));
        }
    }
}