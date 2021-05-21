using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxsumsubarray
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[] input = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            s.MaxSubArray(input);
        }
        public class Solution
        {
            public int MaxSubArray(int[] nums)
            {
                int maxsum = nums[0];

                for (int i = 1; i < nums.Length; i++)
                {
                    if (nums[i - 1] > 0)
                    {
                        nums[i] = nums[i - 1] + nums[i];

                    }
                    maxsum = Math.Max(nums[i], maxsum);
                }
                return maxsum;
            }

        }
    }
}
