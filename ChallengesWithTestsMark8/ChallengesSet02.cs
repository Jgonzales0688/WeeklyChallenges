using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if (c == char.MinValue) return false; return true;
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if(vals.Length % 2 == 0) return true; return false;
        }

        public bool IsNumberEven(int number)
        {
            if(number % 2 == 0) return true; return false;
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0) return true; return false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            double MaxValue = numbers.Max();
            double MinValue = numbers.Min();
            return MaxValue + MinValue;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if(str1.Length <str2.Length) return str1.Length; return str2.Length;
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            else
            {
                int total = numbers.Sum(x => Convert.ToInt32(x));
                return total;
            }
           
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
                    { return 0; }
            else
            {
                var total = numbers.Where(i => i % 2 == 0).Sum();
                return total;
            }
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int total = numbers.Sum(x => Convert.ToInt32(x));
            if (numbers == null)
            { 
                return false; 
            }
            else
            {
              int total = numbers.Sum(x => Convert.ToInt32(x));
                    return true;
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            throw new NotImplementedException();
        }
    }
}
