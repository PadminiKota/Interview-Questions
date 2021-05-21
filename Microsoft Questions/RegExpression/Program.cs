using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution S = new Solution();
            S.IsMatch("aaa", "ab*a*c*a");
        }
        public class Solution
        {
            public bool IsMatch(string s, string p)
            {
                bool[,] dp = new bool[p.Length + 1, s.Length + 1];
                dp[0, 0] = true;
                /*******if char/"." fill 1st col as false if * check 2 rows above and fill**************/
                for (int k = 1; k < dp.GetLength(0); k++)
                {
                    char temp = p[k - 1];
                    if (temp == '*')
                    {
                        dp[k, 0] = dp[k - 2, 0];
                    }

                }
                for (int i = 1; i < dp.GetLength(0); i++)
                {
                    for (int j = 1; j < dp.GetLength(1); j++)
                    {
                        if (p[i - 1] == '*')
                        {
                            if (p[i - 2] == s[j - 1] || p[i - 2] == '.')
                            {
                                dp[i, j] = dp[i, j] || dp[i, j - 1];
                            }
                            else
                            {
                                dp[i, j] = dp[i - 2, j];
                            }
                        }
                        else if (p[i - 1] == '.')
                        {
                            dp[i, j] = dp[i - 1, j - 1];
                        }
                        else
                        {
                            if (p[i - 1] != s[j - 1])
                            {
                                dp[i, j] = false;
                            }
                            else
                            {
                                dp[i, j] = dp[i - 1, j - 1];
                            }
                        }
                    }
                }

                return dp[p.Length, s.Length];

            }
        }
    }
}
