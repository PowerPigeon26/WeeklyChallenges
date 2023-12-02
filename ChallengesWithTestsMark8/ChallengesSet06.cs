using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null) { return false; }
            List<string> newList = new List<string>(words);
            if (ignoreCase)
            {
                for (int i = 0; i < newList.Count(); i++)
                {
                    if (newList[i] != null)
                    {
                        newList[i] = newList[i].ToLower();
                    }
                }
                return newList.Contains(word.ToLower());
            }
            else
            {
                return words.Contains(word);
            }
        }

        public bool IsPrimeNumber(int num)
        {
            if (num <= 1) { return false; }
            var numberList = Enumerable.Range(2, (num/2)).ToList();
            foreach (var number in numberList)
            {
                if (num % number == 0 && num != number)
                {
                    return false;
                }
            }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int indexToRemember = -1;
            for (int i = 0; i < str.Length; i++)
            {
                if (1 == str.Count(x => x == str[i]))
                {
                    indexToRemember = i;
                }
            }
            return indexToRemember;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int totalCount = 1;
            int currentCount = 1;
            int lastNumber = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == lastNumber)
                {
                    currentCount++;
                }
                else
                {
                    currentCount = 1;
                    lastNumber = numbers[i];
                }
                if (currentCount > totalCount)
                {
                    totalCount = currentCount;
                }
            }
            return totalCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null || n <= 0) { return new double[0]; }
            List<double> result = new List<double>();
            for (int i = n - 1; i < elements.Count; i += n)
            {
                result.Add(elements[i]);
            }
            return result.ToArray();
        }
    }
}
