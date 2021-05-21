using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_comments
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution S = new Solution();
            string[] s = new string[] { "/*Test program */", "int main()", "{ ", "  // variable declaration ", "int a, b, c;", "/* This is a test", "   multiline  ", "   comment for ", "   testing */", "a = b + c;", "}"};
            S.RemoveComments(s);
        }
        public class Solution
        {
            public IList<string> RemoveComments(string[] source)
            {
                int i = 0;
                var output = new List<string>();
                StringBuilder sb = new StringBuilder();
                bool blockcomments = false;
                while (i < source.Length)
                {
                    // string str=source[i];
                    for (int j = 0; j < source[i].Length; j++)
                    {
                        string str = source[i];
                        if (!blockcomments)
                        {
                            if (str[j] == '/' && j + 1 < str.Length && str[j + 1] == '/')
                            {
                                //j++;
                                break;
                            }
                            else if (str[j] == '/' && j + 1 < str.Length && str[j + 1] == '*')
                            {
                                blockcomments = true;
                                j++;

                            }
                            else
                            {
                                sb.Append(str[j]);
                            }
                        }
                        else
                        {
                            if (str[j] == '*' && j + 1 < str.Length && str[j + 1] == '/')
                            {
                                blockcomments = false;
                                j++;
                            }
                        }

                    }
                    if (!blockcomments && sb.ToString().Length > 0)
                    {
                        output.Add(sb.ToString());
                        sb.Clear();
                    }
                    i++;
                }
                return output;

            }
        }
    }
}
