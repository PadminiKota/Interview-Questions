using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myatoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution S = new Solution();
           int resuly= S.MyAtoi("   -42");
        }
        public class Solution
        {
            public int MyAtoi(string s)
            {
                if (s == "" || (!char.IsDigit(s[0]) && s[0] != '-' && s[0] != '+'))
                    return 0;
                s = s.Trim();
                bool isnegative = s[0] == '-' ? true : false;
                int result = 0;
                int i = isnegative || s[0] == '+' ? 1 : 0;

                for (; i < s.Length; i++)
                {
                    if (!char.IsDigit(s[i]))
                        break;
                    try
                    {
                        checked
                        {
                            result = result * 10 + s[i] - '0';
                        }

                    }
                    catch
                    {
                        return isnegative ? int.MinValue : int.MaxValue;
                    }
                }

                return isnegative ? -1 * result : result;

            }
        }
    }
}
