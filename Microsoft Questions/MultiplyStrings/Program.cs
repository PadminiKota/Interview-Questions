using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution S = new Solution();
            S.Multiply("123", "456");
        }
        public class Solution
        {
            public string Multiply(string num1, string num2)
            {
                int n = num1.Length, m = num2.Length;
                int[] sum_array = new int[n + m];

                for (int i = n - 1; i >= 0; i--)
                {
                    int mul = num1[i] - '0';
                    for (int j = m-1; j >= 0; j--)
                    {
                        int index = i + j + 1;
                        sum_array[index] = (mul * (num2[j] - '0')) + sum_array[index];
                    }
                }
                int carry_over = 0;
                for (int k = sum_array.Length - 1; k >= 0; k--)
                {
                    int temp = sum_array[k]+ carry_over;
                    sum_array[k] = temp % 10;
                    carry_over = temp / 10;
                    
                }

                return sum_array.ToString();

            }
        }
    }
}
