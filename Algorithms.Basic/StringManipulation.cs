using System;
using System.Linq;
using System.Text;

namespace Algorithms.Basic
{
    public class StringManipulation
    {
        // ******************* Reverse ************************
        public string ReverseString(string str)
        {
            var reversed = "";

            foreach (var character in str) reversed = character + reversed;

            return reversed;
        }

        public string ReverseString2(string str)
        {
            var charArray = str.ToCharArray();

            var reversedCharArray = charArray.Reverse();

            var reversedString = string.Concat(reversedCharArray);

            return reversedString;
        }

        public string ReverseString3(string str)
        {
            return string.Concat(str.ToCharArray().Reverse());
        }

        public string ReverseString4(string str)
        {
            return new string(str.ToCharArray().Reverse().ToArray());
        }

        // ******************* End of Reverse ************************

        // ******************* Anagram ************************

        public bool Anagram(string strA, string strB)
        {
            var sortedCleanStrA = CleanUpString(strA);
            var sortedCleanStrB = CleanUpString(strB);
            return sortedCleanStrA.Equals(sortedCleanStrB, StringComparison.CurrentCultureIgnoreCase);
        }

        private string CleanUpString(string str)
        {
            var sb = new StringBuilder();

            foreach (var character in str)
                if (character >= 'A' && character <= 'Z' || character >= 'A' && character <= 'Z' ||
                    character >= 0 && character <= 9)
                    sb.Append(character);

            return string.Concat(sb.ToString().OrderBy(c => c));
        }

        // ******************* End of Anagram ************************
    }
}