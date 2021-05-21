using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[] {3,1,3,2,2};
            Solution S = new Solution();
            int output = S.MaxArea_Array(input);
        }
        public class Solution
        {
            Stack<int> stack = new Stack<int>();
            int[] smallest;
            public int MaximalRectangle(char[][] matrix)
            {
                int output = 0;
                if (matrix.GetLength(0) == 0)
                    return 0;
                int[] input = new int[matrix[0].Length];
                for (int m = 0; m < matrix.GetLength(0); m++)
                {
                    for (int n = 0; n < matrix[0].Length; n++)
                    {
                        if (int.Parse(matrix[m][n].ToString()) != 0)
                            input[n] = input[n] + int.Parse(matrix[m][n].ToString());
                        else
                            input[n] = 0;
                    }

                    output = Math.Max(output, MaxArea_Array(input));

                }
                return output;

            }
            public int MaxArea_Array(int[] input)
            {
                int[] NSL_Index = NSL(input);
                stack.Clear();
                int[] NSR_Index = NSR(input);
                int Length = 0, Max_Array_area = 0;
                for (int k = 0; k < NSL_Index.Length; k++)
                {
                    Length = NSR_Index[k] - NSL_Index[k] - 1;
                    Max_Array_area = Math.Max(Max_Array_area, Length * input[k]);
                }
                return Max_Array_area;
            }
            public int[] NSL(int[] input)
            {

                smallest = new int[input.Length];
                for (int j = 0; j <= input.Length - 1; j++)
                {
                    if (j == 0)
                    {
                        stack.Push(j);
                        smallest[j] = -1;
                    }
                    else if (input[stack.Peek()] >= input[j])
                    {
                        while (stack.Count > 0 && input[stack.Peek()] >= input[j])
                        {
                            stack.Pop();
                        }
                        if (stack.Count == 0)
                            smallest[j] = -1;
                        else
                            smallest[j] = stack.Peek();
                        stack.Push(j);
                    }
                    else
                    {
                        smallest[j] = stack.Peek();
                        stack.Push(j);
                    }

                }
                return smallest;
            }
            public int[] NSR(int[] input)
            {

                smallest = new int[input.Length];
                for (int j = input.Length - 1; j >= 0; j--)
                {
                    if (j == input.Length - 1)
                    {
                        stack.Push(j);
                        smallest[j] = input.Length;
                    }
                    else if (input[stack.Peek()] >= input[j])
                    {
                        while (stack.Count > 0 && input[stack.Peek()] >= input[j])
                        {
                            stack.Pop();
                        }
                        if (stack.Count == 0)
                            smallest[j] = input.Length;
                        else
                            smallest[j] = stack.Peek();
                        stack.Push(j);
                    }
                    else
                    {
                        smallest[j] = stack.Peek();
                        stack.Push(j);
                    }

                }
                return smallest;
            }
        }
    }
}
