using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reomove_Duplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { 1, 1, 1, 2, 2, 3 };
            Solution S = new Solution();
            S.RemoveDuplicates(input);
        }
        public class Solution
        {
            public int RemoveDuplicates(int[] nums)
            {
                int j = 0, cnt = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] != nums[j] || cnt == 2)
                    {
                        j++;
                        nums[j] = nums[i];
                        cnt = 1;

                    }
                    else if (nums[i] == nums[j])
                        cnt++;
                }

                return j + 1;
            }
        }
    }
}
