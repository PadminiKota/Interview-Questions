using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semi_Alternating
{
    class Program
    {
        /**********************
         * Given a string S containing only characters a and b. A substring 
         * (contiguous fragment) of S is called a semi-alternating substring
         *  if it does not contain three identical consecutive characters. 
         *  In other words, it does not contain either 'aaa' or 'bbb' substrings.
         *   Note that the whole S is its own substring.

Example 1:
Input: baaabbabbb
Output: 7
Explanation:
the longest semi-alternating substring is aabbabb

Example 2:
Input: babba
Output: 5
Explanation:
Whole S is semi-alternating.

Example 3:
Input: abaaaa
Output: 4
Explanation:
The first four letters of S create a semi-alternating substring.
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * ***************************/
        static void Main(string[] args)
        {
            semiSubstring("baaabbabbb");
        }
        public static int semiSubstring(String s)
        {
            int max_count = 3;
            if (s.Length < max_count)
                return s.Length;
            int count = 1, result = 1;
            for(int i=1;i<s.Length-1;i++)
            {
                if((s[i-1]==s[i])&&(s[i]==s[i+1]))
                {
                    result = Math.Max(result, count);
                    count = 1;
                }
                else
                {
                    count++;
                }
            }

            return Math.Max(result, count + 1); ;
     
        }
        //public static int semiSubstring(String s)
        //{
        //   //baaabbabbb
        //    int i = 0, j = 0, max_len = int.MinValue, a_count = 0, b_count = 0;
        //    char[] array = s.ToCharArray();
        //    while(i<s.Length)
        //    {
        //        //char c = array[i];
        //        j = i + 1;
        //        while(j<array.Length && a_count<1 && b_count<1)
        //        {
        //            if(j<array.Length-1 && array[j]=='a')
        //            {
        //                if ((array[j - 1] == array[j]) && (array[j] == array[j + 1]))
        //                    a_count++;
        //            }
        //            else if(j<array.Length-1 && array[j]=='b')
        //            {
        //                if ((array[j - 1] == array[j]) && (array[j] == array[j + 1]))
        //                    b_count++;
        //            }
        //            j++;
        //        }
        //        max_len = Math.Max(max_len,(j-i));
        //        i = j - 1;
        //        a_count = 0;
        //        b_count = 0;
        //    }
        //    return max_len;
        //}
    }
}
