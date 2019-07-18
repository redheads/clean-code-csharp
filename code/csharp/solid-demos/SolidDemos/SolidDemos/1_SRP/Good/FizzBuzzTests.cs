using FluentAssertions;
using Xunit;

namespace SolidDemos._1_SRP.Good
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

}