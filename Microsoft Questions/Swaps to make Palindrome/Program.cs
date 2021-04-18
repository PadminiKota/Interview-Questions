using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swaps_to_make_Palindrome
{
    class Program
    {
        /****************************
         * Given a string, what is the minimum number of adjacent swaps required to convert a string into a palindrome. If not possible, return -1.

Example 1:
Input: mamad
Output: 3
Explanation:
swap m with a => maamd

swap m with d => maadm

swap a with d => madam

Example 2:
Input: asflkj
Output: -1
Example 3:
Input: mideld
Output: 3
Explanation:
swap e with l => midled

swap e with d => midlde

swap l with d => middle
         * 
         * 
         * 
         * 
         * m(s)amad(e)(j)
         * maamd(1 swap)
         * m(s)aad(e)(j)m(2 swap)
         * madam(3rd swap)
         * if(s==e)
         *   s++,e++
         *   else{
         *   while(s[s]!=s[j++])
         *            {
         *               s==j(need to consider this as middle index)
         *            }
         *            esle
         *            {
         *              swap(adj nodes until e pointer
         *               s++,e++,j=e
         *            }
         * 1-- check if string is palindrome (2 pointers)
         * 2--if chars r not equal start moving j pointer until s[s]=s[j]
         * 3-- if s==j its middle char
         * 4-- else swap
         * 
         * (s)asflkj(j,e)
         *  if len is odd middle char
         *   return -1;
         *   
         *   (s)mideld(j,e)
         * 
         * ****************************************/
        static void Main(string[] args)
        {
           int cnt= minSwap("abaeacabdcccd");
        }
        public static int minSwap(String str)
        {
            int start = 0, end = str.Length - 1, rptr = str.Length - 1;
            bool centerletterfound = false;int count = 0;
            char[] array = str.ToCharArray();
            while (start < end)
            {
                if (array[start] != array[end])
                {
                    while (array[start] != array[--rptr]) ;
                    if (start == rptr)
                    {
                        if (!centerletterfound)
                        {
                            int mid = str.Length / 2;
                            Swap(ref array, start, mid, ref count);
                                centerletterfound = true;
                            rptr = end;
                            continue;
                        }
                        else
                            return -1;
                    }
                    else
                    {
                        Swap(ref array, rptr, end,ref count);
                                             
                    }
                 
                }
                start++;
                end--;
                rptr = end;
            }
            return count;

        }
         private static void Swap(ref char[] str, int i, int j, ref int cnt)
        {
            for(int k=i+1;k<=j;k++)
            {
                char temp = str[k-1];
                str[k-1] = str[k];
                str[k] = temp;
                cnt++;
            }
        }

    }
}