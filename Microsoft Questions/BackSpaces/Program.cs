using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackSpaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution S = new Solution();
            S.BackSpaces("xy#z", "xzz#");
        }
        class Solution
        {
            public bool BackSpaces(string str1, string str2)
            {
                int x = str1.Length-1, y = str2.Length-1;
                while(x>=0 || y>=0)
                {
                    if(str1[x]=='#')
                    {
                        if (x != 0)
                            str1 = str1.Remove(x - 1, 2);
                        else
                            str1 = str1.Remove(x, 1);
                    }
                    if(str2[y]=='#')
                    {
                        if (y != 0)
                            str2 = str2.Remove(y-1,2);
                        else
                            str2 = str2.Remove(x, 1);
                    }
                }

                if (str1 == str2)
                    return true;
                return false; 
            }
        }
    }
}
