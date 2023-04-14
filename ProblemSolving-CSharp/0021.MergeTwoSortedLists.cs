using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _0021
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

        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null)
            {
                return list2;
            }

            if (list2 == null)
            {
                return list1;
            }

            // Initialize a new node to represent the head of the merged list
            ListNode merged;

            // Determine which list has the smaller value at the head, and assign that list to the merged list
            if (list1.val <= list2.val)
            {
                merged = list1;
                list1 = list1.next;
            }
            else
            {
                merged = list2;
                list2 = list2.next;
            }

            // Create a pointer to traverse the merged list
            ListNode curr = merged;

            // Traverse both lists and add the smaller node to the merged list
            while (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {
                    curr.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    curr.next = list2;
                    list2 = list2.next;
                }
                curr = curr.next;
            }

            // Add any remaining nodes from the first list to the merged list
            if (list1 != null)
            {
                curr.next = list1;
            }

            // Add any remaining nodes from the second list to the merged list
            if (list2 != null)
            {
                curr.next = list2;
            }

            // Return the head of the merged list
            return merged;
        }

        public ListNode MergeTwoListsRec(ListNode list1, ListNode list2)
        {
            if (list1 == null)
            {
                return list2;
            }

            if (list2 == null)
            {
                return list1;
            }

            if (list1.val <= list2.val)
            {
                list1.next = MergeTwoLists(list1.next, list2);
                return list1;
            }
            else
            {
                list2.next = MergeTwoLists(list1, list2.next);
                return list2;
            }
        }
    }
}
