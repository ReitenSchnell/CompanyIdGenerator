using System;
using System.Globalization;
using System.Linq;
using FluentAssertions;
using Generators;
using Xunit;

namespace GeneratorsTests
{
    public class SwePersonalCodeTests
    {
        [Fact]
        public void should_contain_date_before_separator()
        {
            var code = SwePersonalCode.Generate();
            var datePart = code.Substring(0, 8);
            var parsingResult = DateTime.TryParseExact(datePart, "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None, out _);
            parsingResult.Should().BeTrue();
        }

        [Fact]
        public void should_contain_separator()
        {
            var code = SwePersonalCode.Generate();
            code[8].Should().Be('-');
        }

        [Fact]
        public void should_contain_correct_random_part()
        {
            var code = SwePersonalCode.Generate();
            var randomPart = code.Substring(9);
            randomPart.Length.Should().Be(4);
        }

        [Fact]
        public void should_calculate_correct_check_sum()
        {
            var code = SwePersonalCode.Generate();
            var arr = code.ToCharArray().Take(code.Length - 1).Skip(2).Where(c => c != '-').ToList();
            var sum = 0;
            var ind = 0;
            arr.ForEach(c =>
            {
                var multiplier = ind % 2 == 0 ? 2 : 1;
                var multiplied = int.Parse(c.ToString()) * multiplier;
                var value = multiplied > 9 ? multiplied.ToString().Sum(c1 => int.Parse(c1.ToString())) : multiplied;
                sum += value;
                ind++;
            });

            var secondDigit = int.Parse(sum.ToString()[1].ToString());
            var diff = 10 - secondDigit;
            var checkSum = diff == 10 ? 0 : diff;
            int.Parse(code[code.Length - 1].ToString()).Should().Be(checkSum);
        }
    }
}
