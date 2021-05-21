using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCranes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] {2,1};
            int[] P = new int[] { 5, 1 };
            int B =2;
            int E =6;
            Solution S = new Solution();
            S.Cranes(A, P, B, E);
        }
        class Solution
        {
            public bool Cranes(int[] A, int[] P, int B, int E)
            {
                var Cranes_range = new List<int[]>();
                var merged_intervals = new List<int[]>();
                for (int i=0;i<P.Length;i++)
                {
                    var tem = new int[2];
                    tem[0] = P[i]-A[i];
                    tem[1] = A[i]+P[i];
                    Cranes_range.Add(tem);
                }
                var sorted_range=Cranes_range.OrderBy(x => x[0]).ToArray();
                int[] current_merged = sorted_range[0];
                foreach(var range in sorted_range)
                {
                    int start_range = range[0];
                    int end_range = range[1];
                    int curret_merged_end = current_merged[1];
                    if (curret_merged_end >= start_range)
                        current_merged[1] = Math.Max(curret_merged_end, end_range);
                    else
                    {
                        current_merged = range;
                        merged_intervals.Add(current_merged);
                    }
                }
                foreach(var range in merged_intervals)
                {
                    if (B >= range[0] && E <= range[1])
                        return true;
                }
                 return false;
            }
        }
    }
}
