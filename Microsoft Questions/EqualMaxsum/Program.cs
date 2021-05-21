using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualMaxsum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { 51, 71, 17, 42 };
            Solution S = new Solution();
            S.Maxsum(input);
        }
        public class Solution
        {
            public int Maxsum(int[] input)
            {
                int maxsum = int.MinValue;
                var dict = new Dictionary<int, int>();

                for(int i=0;i<input.Length;i++)
                {
                    int curr_num = input[i];
                    int sum = 0;
                    while(curr_num>0)
                    {
                        sum += curr_num % 10;
                        curr_num = curr_num / 10;
                    }
                    if (!dict.ContainsKey(sum))
                        dict.Add(sum, input[i]);
                    else
                        maxsum = Math.Max(maxsum, (input[i] + dict[sum]));
                }

                return maxsum;
            }
        }
    }
}
