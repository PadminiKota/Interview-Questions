using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotten
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public class Solution
        {
            public int OrangesRotting(int[][] grid)
            {
                int freshcount = 0, time = 0;
                var rotted = new Queue<(int, int) > ();
                for (int i = 0; i < grid[0].Length; i++)
                {
                    for (int j = 0; j < grid.Length; j++)
                    {
                        if (grid[i][j] == 2)
                        {
                            rotted.Enqueue((i, j));
                            grid[i][j] = 0;
                        }
                        else if (grid[i][j] == 1)
                            freshcount++;
                    }
                }
                var adj_lst = new (int, int)[]{ (0,1),(0,-1),(1,0),(-1,0)};
                while (freshcount > 0 && rotted.Count > 0)
                {
                    int count = rotted.Count;
                    while (count != 0)
                    {
                        var(row, col) = rotted.Dequeue();
                        foreach (var dir in adj_lst)
                        {
                            var next_row = row + dir.Item1;
                            var next_col = col + dir.Item2;
                            if (col < grid[0].Length &&
                               row < grid.Length && row >= 0 && col >= 0
                              && grid[row][col] == 1)
                            {
                                grid[row][col] = 0;
                                freshcount--;
                                rotted.Enqueue((row, row));
                            }
                        }
                        count--;
                    }

                    time++;

                }
                return freshcount > 0 ? -1 : time;

            }
        }
    }
}
