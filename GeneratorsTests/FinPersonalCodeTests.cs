using System;
using System.Globalization;
using System.Linq;
using FluentAssertions;
using Generators;
using Xunit;

namespace GeneratorsTests
{
    public class FinPersonalCodeTests
    {
        [Fact]
        public void should_contain_date_before_separator()
        {
            var code = FinPersonalCode.Generate();
            var datePart = code.Substring(0, 6);
            var parsingResult = DateTime.TryParseExact(datePart, "ddMMyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _);
            parsingResult.Should().BeTrue();
        }

        [Fact]
        public void should_contain_separator()
        {
            var code = FinPersonalCode.Generate();
            var separators = new[] {'-', '+', 'A'};
            separators.Should().Contain(code[6]);
        }

        [Fact]
        public void should_contain_correct_random_part()
        {
            var code = FinPersonalCode.Generate();
            var randomPart = code.Substring(7);
            randomPart.Length.Should().Be(4);
        }

        [Fact]
        public void should_calculate_correct_check_sum()
        {
            var code = FinPersonalCode.Generate();
            var checkSum = code.ToCharArray().Take(code.Length - 1)
                .Where(char.IsDigit).ToList();
            var mod = int.Parse(string.Join("", checkSum)) % 31;
            const string str = "0123456789ABCDEFHJKLMNPRSTUVWXY";
            str[mod].Should().Be(code[code.Length - 1]);
        }
    }
}
