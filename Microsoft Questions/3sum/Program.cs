using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { 0, 0, 0 };
            Solution S = new Solution();
            S.ThreeSum(input);

        }
        public class Solution
        {
            public IList<IList<int>> output = new List<IList<int>>();
            public IList<IList<int>> ThreeSum(int[] nums)
            {
                Array.Sort(nums);
                for (int i = 0; i < nums.Length; i++)
                {
                    if (i > 0 && (nums[i - 1] != nums[i]))
                        Sum(nums[i], i + 1, nums);
                }
                return output;
            }
            private void Sum(int target, int index, int[] nums)
            {
                int left = index, right = nums.Length - 1;
                while (left < right)
                {
                    int sum = target + nums[left] + nums[right];
                    if (sum == 0)
                    {
                        output.Add(new List<int>() { target, nums[left], nums[right] });
                        while (left < right && nums[left] == nums[left + 1]) left++;
                        while (left < right && nums[right] == nums[right - 1]) right--;
                        left++; right--;
                    }
                    else if (sum < 0)
                        left++;
                    else
                        right--;
                }

            }
        }
    }
}
