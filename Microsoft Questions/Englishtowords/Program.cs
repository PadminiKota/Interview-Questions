using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Englishtowords
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution S = new Solution();
            S.NumberToWords(45);
        }
        public class Solution
        {
            static Dictionary<int, string> dict = new Dictionary<int, string> {
       {1000000000, "Billion"},
           {1000000, "Million"},
           {1000, "Thousand"},
           {100, "Hundred"},
           {90, "Ninety"},
            {80, "Eighty"},
            {70, "Seventy"},
            {60, "Sixty"},
            {50, "Fifty"},
            {40, "Forty"},
            {30, "Thirty"},
            {20, "Twenty"},
           {19, "Nineteen"},
           {18, "Eighteen"},
           {17, "Seventeen"},
           {16, "Sixteen"},
           {15, "Fifteen"},
           {14, "Fourteen"},
           {13, "Thirteen"},
           {12, "Twelve"},
           {11, "Eleven"},
           {10, "Ten"},
            {9, "Nine"},
            {8, "Eight"},
            {7, "Seven"},
           {6, "Six"},
           {5, "Five"},
            {4, "Four"},
            {3, "Three"},
            {2, "Two"},
           {1, "One"},
           {0, "Zero"},
};
            public string NumberToWords(int num)
            {
                if (num == 0)
                    return "Zero";
                Stack<int> stack = new Stack<int>();
                List<string> output = new List<string>();
                int k = 0;
                while (num > 0)
                {
                    int temp = num % 1000;
                    stack.Push(temp);
                    num = num / 1000;
                    k++;
                }

                while (stack.Count != 0)
                {
                    int temp_val = stack.Pop();
                    if (temp_val != 0)
                        output.Add(Convertinttostring(temp_val, k));
                    k--;
                }
                return String.Join("", output.ToList()).Trim();

            }
            private string Convertinttostring(int n, int k)
            {
                if (k == 4)
                {
                    if (n < 99)
                        return TwoDigit(n) + " " + "Billion ";
                    else
                        return ThreeDigit(n) + " " + "Billion ";
                }
                if (k == 3)
                {
                    if (n < 99)
                        return TwoDigit(n) + " " + "Million ";
                    else
                        return ThreeDigit(n) + " " + "Million ";
                }
                if (k == 2)
                {
                    if (n < 99)
                        return TwoDigit(n) + " " + "Thousand ";
                    else
                        return ThreeDigit(n) + " " + "Thousand ";
                }
                return ThreeDigit(n);
            }
            private string ThreeDigit(int num)
            {
                int hundreds = num / 100;
                int reminder = num % 100;
                if (hundreds == 0)
                    return TwoDigit(reminder);
                if (reminder == 0)
                    return dict[hundreds] + " " + "Hundred";
                return dict[hundreds] + " " + "Hundred" + " " + TwoDigit(reminder);
            }
            private string TwoDigit(int num)
            {
                if (num < 20)
                    return dict[num];
                int tens = num / 10 * 10;
                int units = num % 10;
                if (units == 0)
                    return dict[tens];
                return dict[tens] + " " + dict[units];

            }


        }
    }
}
