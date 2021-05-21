using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplify_Path
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution S = new Solution();
            S.SimplifyPath("/home/");
        }
        public class Solution
        {
            public string SimplifyPath(string path)
            {

                string[] path_arry = path.Split('/');
                Stack<string> stack = new Stack<string>();

                for (int i = 0; i < path_arry.Length; i++)
                {
                    if (path_arry[i] == ".." || path_arry[i] == ".")
                    {
                        while (stack.Count > 0)
                            stack.Pop();
                    }
                    else if (path_arry[i] == "")
                        continue;
                    else
                        stack.Push(path_arry[i]);
                }

                StringBuilder sb = new StringBuilder();
                while (stack.Count > 0)
                {
                    sb.Insert(0, "/" + stack.Pop());
                }

                return sb.Length == 0 ? "/" : sb.ToString();
            }
        }
    }
}
