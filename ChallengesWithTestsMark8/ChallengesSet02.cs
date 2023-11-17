﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return (vals.Length % 2 == 0);
        }

        public bool IsNumberEven(int number)
        {
            return (number % 2 == 0);
        }

        public bool IsNumberOdd(int num)
        {
            return (num % 2 != 0);
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            return (numbers == null || numbers.Count() == 0) ? 0 : numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return (str1.Length > str2.Length) ? str2.Length : str1.Length;
        }

        public int Sum(int[] numbers)
        {
            int sum = 0;
            if (numbers == null) { return 0; }

            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null) { return 0; }
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += (number % 2 == 0) ? number : 0;
            }
            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null) { return false; }
            return (numbers.ToArray().Sum() % 2 == 0) ? false : true;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number < 0) { return 0; }
            return (number % 2 == 0) ? number / 2 : number / 2;
        }
    }
}
