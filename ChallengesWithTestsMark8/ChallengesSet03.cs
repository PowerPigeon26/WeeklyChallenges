using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals == null || vals.Length == 0) return false;
            foreach(bool val in vals)
            {
                if (val == false) return true;
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            int sumOfOdds = 0;
            if (numbers == null) { return false; }
            foreach(int number in numbers)
            {
                sumOfOdds += (number % 2 == 0) ? 0 : number;
            }
            return (sumOfOdds % 2 == 0) ? false : true;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsNumber))
            { return true; }
            else { return false; }
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0) { return 0; }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            return Enumerable.Range(1,100).Where(i => i % 2 != 0).ToArray();
        }

        public string[] ChangeAllElementsToUppercase(string[] words)
        {
            List<string> newList = new List<string>();
            words.ToList().ForEach(word => newList.Add(word.ToUpper()));
            return newList.ToArray();
        }
    }
}
