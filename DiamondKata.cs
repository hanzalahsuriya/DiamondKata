using System.Collections.Generic;
using System.Linq;

namespace DiamondKata
{
    public class DiamondKata : IDiamondkata
    {
        private const int A = 65;
        private const int Z = 90;

        public string CreateDiamondKata(char inputChar)
        {
            var input = (int)inputChar;
            if (input is < A or > Z)
            {
                return "";
            }

            var topDiamond = new Stack<string>();
            var numberOfChars = ((input - A) * 2) + 1;
            var current = input;
            var start = 0;
            var end = numberOfChars - 1;
            var newLine = Enumerable.Repeat(' ', numberOfChars).ToArray();
            while (current >= A)
            {
                var line = (char[])newLine.Clone();
                line[start++] = (char)current;
                line[end--] = (char)current;
                topDiamond.Push(new string(line));
                current--;
            }

            var outputList = new string[numberOfChars];
            var i = 0;
            var j = numberOfChars - 1;
            while (topDiamond.Count > 0)
            {
                var item = topDiamond.Pop();
                outputList[i++] = item;
                outputList[j--] = item;
            }

            return string.Join('\n', outputList);
        }
    }
}
