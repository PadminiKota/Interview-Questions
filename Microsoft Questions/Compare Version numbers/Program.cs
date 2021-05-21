using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare_Version_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution S = new Solution();
            S.CompareVersion("7.5.2.4", "7.5.3");
            string s = "abcd";
            
        }
        public class Solution
        {
            public int CompareVersion(string version1, string version2)
            {
                int i = 0, j = 0, retval = 0, version1_int = 0, version2_int = 0;
                 while(i<version1.Length || j<version2.Length)
                {
                    while(i<version1.Length && version1[i]!='.')
                    {
                        version1_int = 10 * version1_int + version1[i] - '0';
                        i++;
                    }
                    while(j<version2.Length && version2[j]!='.')
                    {
                        version2_int = 10 * version2_int + version2[j] - '0';
                        j++;
                    }
                    retval = Compare(version1_int,version2_int);
                    if (retval == -1 || retval==1)
                        return retval;
                    version1_int = 0;version2_int = 0;
                    i++;
                    j++;

                }


                return retval; 
            }
            private int Compare(int i, int j)
            {
                if (i < j)
                    return -1;
                else if (i > j)
                    return 1;

                return 0;
            }
        }
    }
}
