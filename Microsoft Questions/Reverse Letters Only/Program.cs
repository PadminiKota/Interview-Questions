using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Letters_Only
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution S = new Solution();
            S.ReverseOnlyLetters("a-bC-dEf-ghIj");
        }
        public class Solution
        {
            public string ReverseOnlyLetters(string S)
            {
                int i = 0, j = S.Length - 1;
                char[] array = S.ToCharArray();
                while (i < j)
                {
                    char char_i = array[i];
                    char char_j = array[j];
                    if (char.IsLetter(char_i) && char.IsLetter(char_j))
                    {
                        array[i] = char_j;
                        array[j] = char_i;
                        i++;
                        j--;
                    }
                    else
                    {
                        if (!char.IsLetter(char_i))
                            j--;
                        if (!char.IsLetter(char_j))
                            i++;
                    }
               
                }
                return new string(array);
            }

        }
    }
}
