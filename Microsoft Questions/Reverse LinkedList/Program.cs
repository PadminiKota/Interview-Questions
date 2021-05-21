using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_LinkedList
{
    class Program
    {

        public class ListNode
      { 
         public int val;
         public ListNode next;
          public ListNode(int val = 0, ListNode next = null)
                {
                    this.val = val;
                    this.next = next;
                 }
       }

        static void Main(string[] args)
        {
            var node1 = new ListNode(1);
            var node2 = new ListNode(2);
            var node3 = new ListNode(3);
            var node4 = new ListNode(4);
            var node5 = new ListNode(5);
            node1.next = node2;
            node2.next = node3;
            node3.next = node4;
            node4.next = node5;
            Solution S = new Solution();
            var result = S.ReverseBetween(node1, 2, 4);
        }
        public class Solution
        {
            public ListNode ReverseBetween(ListNode head, int left, int right)
            {

                ListNode current = head;
                int count = 1;

                while (count<left-1)
                {
                    current = current.next;
                    count++;
                }
                var curr = current.next;
                var prev = current;
                while(count<right)
                {
                    var temp = curr.next;
                    curr.next = prev;
                     prev = curr;
                    curr = temp;
                    count++;
                }
                 if(left==1)
                {
                    current.next = curr;
                    return prev;
                }
                else
                {
                    current.next.next = curr;
                    current.next = prev;
                }

                return current;
            }
        }
    }
}
