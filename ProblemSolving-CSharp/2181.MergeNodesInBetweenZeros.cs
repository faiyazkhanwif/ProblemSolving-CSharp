using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
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

    public class _2181
    {
        public ListNode MergeNodes(ListNode head)
        {
            ListNode res = new ListNode();
            ListNode reshead = res;

            bool first = true;

            bool startAdding = false;
            int temp = 0;
            while (head != null)
            {
                if (head.val == 0 && startAdding == false)
                {
                    startAdding = true;

                }
                else if (head.val != 0 && startAdding == true)
                {
                    temp += head.val;
                    //Console.WriteLine(temp);

                }
                else if (head.val == 0 && startAdding == true)
                {   //Console.WriteLine(temp+"-------------");
                    if (first == true)
                    {
                        res.val = temp;
                        first = false;
                        //res = res.next;

                    }
                    else
                    {
                        res.next = new ListNode();
                        res.next.val = temp;
                        res = res.next;

                    }
                    temp = 0;
                }
                head = head.next;
            }
            return reshead;
        }
    }
}
