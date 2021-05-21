using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxGames
{
    class Program
    {
        static void Main(string[] args)
        {
            string A = "00:00";
            string B = "23:59";
            Solution S = new Solution();
            S.MaxGames(A, B);

        }
        class Solution
        {
          public int MaxGames(string A, string B)
          {
                int retval = 0, i = 0, j = 0, hours_A = 0,hours_B=0;
                while(i<A.Length && j<B.Length && A[i]!=':')
                {
                    hours_A = hours_A * 10 + A[i] - '0';
                    hours_B = hours_B * 10 + B[j] - '0';
                    i++;j++;
                }
                if (hours_B < hours_A)
                {
                    retval += ((24 - hours_A) + hours_B) * 4;
                }
                else if (hours_B > hours_A)
                {
                    retval += (hours_B - hours_A) * 4;
                }
                retval += MinGames(A, B, i+1);

                return retval;
          } 
          private int MinGames(string A,string B,int index)
          {
                int Mins_A = 0, Mins_B = 0, cnt = 0;
                var range = new List<int[]>();
                range.Add(new int[] {0,15});
                range.Add(new int[] {15,30});
                range.Add(new int[] {30,45});
                range.Add(new int[] {45,60});

                while(index<A.Length)
                {
                    Mins_A = Mins_A * 10 + A[index]-'0';
                    Mins_B = Mins_B * 10 + B[index]-'0';
                    index++;
                }
                foreach(var interval in range)
                {
                    if (Mins_A <= interval[0] && Mins_B >= interval[1])
                        cnt++;
                }

                return cnt;
          }
             

        }
    }
}
