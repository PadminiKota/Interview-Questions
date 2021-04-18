using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Without_3_Identical
{
    class Program
    {
        /************************
         * Given a string S having lowercase English letters, returns a string with no
         *  instances of three identical consecutive letters, obtained from
         *   S by deleting the minimum possible number of letters.

Example 1:
Input: eedaaad
Output: eedaad
Explanation:
One occurrence of letter a is deleted.

Example 2:
Input: xxxtxxx
Output: xxtxx
Explanation:
Note that letter x can occur more than three times in the returned string if the occurrences are not consecutive.

Example 3:
Input: uuuuxaaaaxum
Output: uuxaaxum
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * *************************************/
        static void Main(string[] args)
        {
           string output= filterString("uuuuxaaaaxum");
        }
        //public static String filterString(String str)
        //{
        //    char[] array = str.ToCharArray();
        //    int i = 0, j = 0, cnt = 1;
        //    while (i < str.Length)
        //    {
        //        char c = array[i]; cnt = 0;
        //        while (array[j] == c && cnt < 3)
        //        {
        //            cnt++;
        //            j++;
        //        }
        //        if (array[j-1] == c && cnt == 3)
        //        {
        //            i = j;
        //            while (j < array.Length && array[j] == c) j++;

        //            str = str.Remove(i, j - i);
        //        }
        //        j++;
        //        i = j;

        //    }
        //    return str;
        //}

        public static String filterString(String str)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(str.Substring(0, 2));
            for(int i=2;i<str.Length;i++)
            {
                if((str[i]!=str[i-1])||(str[i]!=str[i-2]))
                {
                    sb.Append(str[i]);
                }
            }
            return sb.ToString();
        }
    }
}
