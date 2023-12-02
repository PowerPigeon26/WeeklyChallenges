using System;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum = (number % 2 == 0) ? sum + number : sum - number;
            }
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int newStr = str1.Length;
            newStr = (newStr <= str2.Length) ? newStr : str2.Length;
            newStr = (newStr <= str3.Length) ? newStr : str3.Length;
            return (newStr <= str4.Length) ? newStr : str4.Length;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int smallestNum = number1;
            smallestNum = (smallestNum <= number2) ? smallestNum : number2;
            smallestNum = (smallestNum <= number3) ? smallestNum : number3;
            return (smallestNum <= number4) ? smallestNum : number4;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sL1, int sL2, int sL3)
        {
            return (sL1 + sL2 > sL3 && sL1 + sL3 > sL2 && sL2 + sL3 > sL1);
        }

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out var number);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            return (objs.Where(x => x == null).Count() > objs.Where(x => x != null).Count());
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Where(x => x % 2 == 0).Count() == 0)
            {
                return 0;
            }
            return numbers.Where(x => x % 2 == 0).Average();
        }

        public int Factorial(int number)
        {
            int sum = 1;
            foreach (int num in Enumerable.Range(1, number))
            {
                sum *= num;
            }
            return sum;
        }
    }
}
