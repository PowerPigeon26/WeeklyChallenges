using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            return startNumber + n - (startNumber % n);
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            businesses.Where(x => x.TotalRevenue <= 0).ToList().ForEach(x => x.Name = "CLOSED");
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            return (numbers == null || numbers.Length == 0) ? false :
                Enumerable.SequenceEqual(numbers, numbers.OrderBy(x => x));
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int sum = 0;
            bool afterEven = false;

            if (numbers == null) { return 0; }
            foreach (int number in numbers)
            {
                if (afterEven == true)
                {
                    sum += number;
                    afterEven = false;
                }
                if ( number % 2 == 0 )
                {
                    afterEven = true;
                }
            }
            return sum;

        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null) { return ""; }
            string newStr = "";
            foreach (string word in words)
            {
                if (word.Replace(" ", "") != "")
                {
                    newStr = $"{newStr} {word.Replace(" ", "")}";
                }
            }
            if (newStr == "") { return ""; }
            return $"{newStr.Remove(0,1)}.";
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null) { return new double[0]; }
            List<double> fourthElements = new List<double>();
            for (int i = 3; i < elements.Count; i += 4)
            {
                fourthElements.Add(elements[i]);
            }
            return fourthElements.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i != j && nums[i] + nums[j] == targetNumber)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
