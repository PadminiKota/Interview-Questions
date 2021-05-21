using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_Serach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[][]
            {
                new int[] {1,4,7,11,15},
                new int[] {2,5,8,12,19},
                new int[] {3,6,9,16,22},
                new int[] {10,13,14,17,24},
                new int[] {18,21,23,26,30},
            };
            Solution S = new Solution();
            S.SearchMatrix(matrix,20);
        }
        public class Solution
        {
            public bool SearchMatrix(int[][] matrix, int target)
            {
                int row = 0;
                int col = matrix[0].Length-1;
                while (row < matrix.Length && col >= 0)
                {
                    if (matrix[row][col] > target)
                    {
                        col--;
                    }
                    else if (matrix[row][col] < target)
                    {
                        row--;
                    }
                    else if(matrix[row][col]==target)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
    }
}
