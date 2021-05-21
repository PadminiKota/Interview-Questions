using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Replacequestionmark
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution S = new Solution();
            S.ModifyString("b?a");

        }
        public class Solution
        {
            public string ModifyString(string s)
            {

                for (int i = 1; i < s.Length; i++)
                {
                    if (s[i] == '?')
                    {
                        int newchar = 97;
                        while ((i<s.Length) && (s[i - 1] == newchar || s[i+1]==newchar))
                        {
                            newchar++;
                        }
               
                        StringBuilder sb = new StringBuilder(s);
                        sb[i] = Convert.ToChar(newchar);
                        s = sb.ToString();
                    }

                }
                int j = 0,val=97;
                if(s[0]=='?')
                {
                    while (s[j + 1] != val) val++;
                    StringBuilder sb = new StringBuilder(s);
                    sb[j] = Convert.ToChar(val);
                    s = sb.ToString();
                }

                return s;

            }
        }
    }
}
