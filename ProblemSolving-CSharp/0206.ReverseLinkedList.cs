using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _0206
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

        public class Solution
        {
            //Iterative
            public ListNode ReverseList(ListNode head)
            {
                if (head == null)
                {
                    return null;
                }
                if (head.next == null)
                {
                    return head;
                }

                ListNode prev = null;
                ListNode curr = head;

                while (curr != null)
                {
                    ListNode nextNode = curr.next;
                    curr.next = prev;
                    prev = curr;
                    curr = nextNode;
                }

                return prev;

            }

            //Recursive
            public ListNode ReverseListRec(ListNode head)
            {
                if (head == null || head.next ==null)
                {
                    return head;
                }

                ListNode reversedListHead = ReverseListRec(head.next);

                head.next.next = head;
                head.next = null;
                return reversedListHead;

            }
        }
    }
}
