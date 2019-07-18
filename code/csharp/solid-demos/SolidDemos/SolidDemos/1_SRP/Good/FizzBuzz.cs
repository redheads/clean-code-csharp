using System.Collections.Generic;
using System.Linq;
using static System.Linq.Enumerable;

namespace SolidDemos._1_SRP.Good
{
    public class FizzBuzz
    {
        private class Rule
        {
            public int Denominator { get; }
            public string Result { get; }

            public Rule(int denominator, string result)
            {
                Denominator = denominator;
                Result = result;
            }
        }

        private static IEnumerable<Rule> ListOfRules(IEnumerable<Rule> rules) => rules;

        private static readonly IEnumerable<Rule> Rules = ListOfRules(
            new List<Rule>
            {
                new Rule(15, "FizzBuzz"),
                new Rule(3, "Fizz"),
                new Rule(5, "Buzz")
            });

        public string Execute()
        {
            var numbers = Range(1, 15);
            var strings = numbers.Select(ParseSingleNumber);
            var result = string.Join(",", strings);
            return result;
        }

        private static string ParseSingleNumber(int number)
        {
            var resultOfAppliedRules = Rules
                .Where(x => number.IsDivisibleBy(x.Denominator))
                .Select(x => x.Result)
                .ToList();
     
            return resultOfAppliedRules.Any()
                ? resultOfAppliedRules.First()
                : number.ToString();
        }
    }

    public static class FizzBuzzExtensions
    {
        public static bool IsDivisibleBy(this int dividend, int divisor) =>
            dividend % divisor == 0;
    }
}