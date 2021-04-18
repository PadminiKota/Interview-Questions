using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_Moves_to_Obtain
{
    class Program
    {
        /*****************************
         * Given a string S consisting of N letters a and b. In one move you can replace one letter by the other (a by b or b by a).

Write a function solution that given such a string S, returns the minimum number of moves required to obtain a string containing no instances of three identical consecutive letters.

Example 1
Input: baaaaa

Output: 1

Explanation: The string without three identical consecutive letters which can be obtained is one move is "baabaa".

Example 2
Input: baaabbaabbba

Output: 1

Explanation: The string without three identical consecutive letters which can be obtained is one move is "baabaa"

Example 3
Input: baabab

Output: 0

Assumptions:
N is an integer within the range [0, ..200,000];
String S consists of only characteres a and b.
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * ******************************************/
        static void Main(string[] args)
        {
            minMoves("baabab");
        }
        public static int minMoves(String s)
        {
            char[] array = s.ToCharArray();
            int i = 0, j = 0, cnt = 0;
            while(i<array.Length)
            {
                j = i + 1;
                while (j < array.Length && array[j] == array[i]) {
                    j++;
                 }
                cnt += (j - i) / 3;
                i = j;

            }
            return cnt;
        }
    }
}
