using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contiguous_Occurrences
{
    class Program
    {
        /************************
         * 
         * Given a string str containing only a and b, find the longest
         *  substring of str such that str does not contain more than two contiguous occurrences of a and b.

Example 1:
Input: aabbaaaaabb
Output: aabbaa
Example 2:
Input: aabbaabbaabbaaa
Output: aabbaabbaabbaa
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * *******************************/
        static void Main(string[] args)
        {
            longestValidString("aabbaabbaabbaaa");
        }
        public static String longestValidString(String str)
        {
            char[] array = str.ToCharArray();
            int i = 0, j = 0, cnt = 1;
            while(i<str.Length)
            {
                char c = array[i];cnt = 1;
                while (array[j++] == c && cnt <2)
                    cnt++;
                if(array[j]==c && cnt==2)
                {
                    i = j;
                    while (j < array.Length && array[j] == c) j++;

                        str = str.Remove(i, j - i);
                }
                i = j;

            }
            return str;
        }
    }
}
