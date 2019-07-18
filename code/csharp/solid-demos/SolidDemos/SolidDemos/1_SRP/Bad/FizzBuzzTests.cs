using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;
using static System.Linq.Enumerable;

namespace SolidDemos._1_SRP.Bad
{
    public class FizzBuzzTests
    {
        [Fact]
        public void Generate_output()
        {
            var sut = new FizzBuzz();
            sut.Execute()
                .Should()
                .Be("1,2,Fizz,4,Buzz,Fizz,7,8,Fizz,Buzz,11,Fizz,13,14,FizzBuzz");
        }
    }

    public class FizzBuzz
    {
        public string Execute()
        {
            var numbers = Range(1, 15).ToList();
            var strings = new List<string>();

            foreach (var number in numbers)
            {
                if (number % 3 == 0 && number % 5 == 0)
                {
                    strings.Add("FizzBuzz");
                }    
                else if (number % 3 == 0)
                {
                    strings.Add("Fizz");
                }    
                else if (number % 5 == 0)
                {
                    strings.Add("Buzz");
                }
                else
                {
                    strings.Add(number.ToString());
                }
            }

            var result = string.Join(",", strings);
            return result;
        }
    }
}