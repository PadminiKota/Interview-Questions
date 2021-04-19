using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulb_switcher
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { 2, 1, 3, 5, 4 };
            Solution S = new Solution();
            S.NumTimesAllBlue(input);
        }
        public class Solution
        {
            public int NumTimesAllBlue(int[] light)
            {

                char[] switch_bulb = new char[light.Length];
                //switch_bulb[0] = 'b';
                int j = 0, output = 0, oncount = 0, res = 0;
                for (int i = 0; i < light.Length; i++)
                {
                    j = light[i] - 1;
                    switch_bulb[j] = 'O';
                    // j = i;
                    oncount++;
                    if (j == 0 ||switch_bulb[j - 1] == 'b')
                    {
                        while (j <light.Length && switch_bulb[j] == 'O')
                        {
                            switch_bulb[j] = 'b';
                            output++;
                            j++;
                        }
                    }
                    if (output == oncount)
                        res++;
                }
              
                return res;
            }
                

            }
    }
    }


