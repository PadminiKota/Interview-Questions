using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildCard
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution S = new Solution();
            S.IsMatch("adceb", "*a*b");

        }
        public class Solution
        {
            public bool IsMatch(string s, string p)
            {
                bool[,] dp = new bool[p.Length + 1, s.Length + 1];
                dp[p.Length, s.Length] = true;
                for(int k=p.Length-1;k>=0;k--)
                {
                    if (p[k] != '*')
                        break;
                    else
                        dp[k, s.Length] = true;
                }
                 for (int i = dp.GetLength(0)-2; i >= 0; i--)
                {
                    for (int j = dp.GetLength(1)-2; j >= 0; j--)
                    {
                            if (p[i] == '*')
                            {
                                dp[i, j] = dp[i, j + 1] || dp[i + 1, j];
                            }
                            else if (p[i] == s[i] || p[i] == '?')
                            {
                                dp[i, j] = dp[i + 1, j + 1];
                            }
                            else if (p[i] != s[i])
                            {
                                dp[i, j] = false;
                            }
                        }
                    
                    }

                return dp[0, 0];
            }
        }
    }
}
