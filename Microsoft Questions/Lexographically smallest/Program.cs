using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexographically_smallest
{
    class Program
    {
        /***********************
         * 
         * Given a string str, the task is to find the lexicographically smallest string that can be formed by removing at most one character from the given string.

Example 1:
Input: abczd
Output: abcd
Example 2:
Input: abcda
Output: abca
Explanation:
One can remove d to get abca which is the lexicographically smallest string possible.
         * 
         * 
         * 
         * 
         * 
         * ****************************/

        static void Main(string[] args)
        {
        }
        public static String smallestString(String str)
        {
            int i = 0;
            for(int j=0;j<str.Length;j++)
            {
                if(str[j]>str[i+1])
                {
                    i = j;
                    break;
                }
            }
            return str.Substring(0, i) + str.Substring(i + 1, str.Length);
        }
    }
}
