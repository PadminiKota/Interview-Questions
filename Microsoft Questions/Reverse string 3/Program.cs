using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_string_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution S = new Solution();
            S.ReverseWords("a good   example");
        }
        //public class Solution
        //{
        //    public string ReverseWords(string s)
        //    {
        //        string[] array = s.Split(" ",StringSplitOptions.R);
        //        int i = 0, j = array.Length - 1;
        //        while (i < j)
        //        {
        //            if (array[i] != "" && array[j] != "")
        //            {
        //                string temp = array[i];
        //                array[i] = array[j];
        //                array[j] = temp;
        //                i++; j--;
        //            }
        //            else if (array[i] == "")
        //                i++;
        //            else if (array[j] == "")
        //            {
        //                array.Re
        //            }
                        
        //        }

        //        return string.Join(" ", array);
        //    }
        //}
        //public class Solution
        //{
        //    public string ReverseWords(string s)
        //    {
        //        string[] str = s.Split(' ').ToArray();
        //        for (int i = 0; i < str.Length; i++)
        //        {
        //            string temp = str[i];
        //            str[i] = ReverseWord(temp);
        //        }

        //        return str.ToString();
        //    }
        //    private string ReverseWord(string strarray)
        //    {
        //        char[] array = strarray.ToCharArray();
        //        int i = 0, j = array.Length - 1;
        //        while (i < j)
        //        {
        //            char temp = array[i];
        //            array[i] = array[j];
        //            array[j] = temp;
        //            i++;
        //            j--;
        //        }
        //        return new string(array);
        //    }
        //}
    }
}
