using System.Collections.Generic;
using System.Linq;

namespace SolidDemos._1_SRP.Bad
{
    public class FizzBuzz
    {
        public string Execute()
        {
            var numbers = Enumerable.Range(1, 15).ToList();
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