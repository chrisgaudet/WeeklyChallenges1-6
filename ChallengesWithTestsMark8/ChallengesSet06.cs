using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            bool containsWord = false;

            if (string.Equals(words, null) || words.Contains(null))
            {
                return false;
            }

            if (ignoreCase)
            {
                word = word.ToLower();

                List<string> lowerCase = words.Select(x => x.ToLower()).ToList();

                containsWord = lowerCase.Contains(word);
            }

            if (!ignoreCase)
            {
                containsWord = words.Contains(word);
            }

            return containsWord;
        }
        public bool IsPrimeNumber(int num)
        {
            bool primeNum = false;

            if (num >= 0)
            {
                if (num % 2 != 0 && num % 3 != 0)
                {
                    primeNum = true;
                }
            }

            if ((num == 2) || (num == 3))
            {
                primeNum = true;
            }

            if (num == 1)
            {
                primeNum = false;
            }

            return primeNum;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int index = -1;

            bool uniqueIndex;

            for (int i = 0; i < str.Length; i++)
            {
                uniqueIndex = true;

                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j] && i != j)
                    {
                        uniqueIndex = false;
                    }
                }

                if (uniqueIndex)
                {
                    index = i;
                }
            }

            return index;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 0;

            for (var i = 0; i < numbers.Length; i++)
            {
                int currentCount = 1;

                for (var j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] != numbers[j])
                    {
                        break;
                    }

                    currentCount++;
                }

                if (currentCount > count)
                {
                    count = currentCount;
                }
            }

            return count;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            List<double> nthElement = new List<double>();

            if (elements == null || n <= 0 || n > elements.Count)
            {
                return nthElement.ToArray();
            }

            for (var i = n - 1; i < elements.Count; i += n)
            {
                nthElement.Add(elements[i]);
            }

            return nthElement.ToArray();
        }
    }
}
