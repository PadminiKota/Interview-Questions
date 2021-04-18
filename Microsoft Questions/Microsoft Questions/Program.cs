using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft_Questions
{
    class Program
    {
        /***************************
         * Given a string with only characters X and Y. Find the minimum number of characters to remove from 
         * the string such that there is no interleaving of character X and Y and all the Xs appear before any Y.

Example 1:
Input:YXXXYXY
Output: 2
Explanation:
We can obtain XXXYY by:

            YXXXYXY
            XXXYY
Delete first Y -> XXXYXY
Delete last occurrence pf X -> XXXYY
Example 2:
Input:YYXYXX
Output: 3
Explanation:
We can remove all occurrence of X or Y:

Example 3:
Input:XXYYYY
Output: 0
Explanation:
String matches the format required.
         * 
         * 
         * 
         * ****************************/
        static void Main(string[] args)
        {
        }
    }
}
