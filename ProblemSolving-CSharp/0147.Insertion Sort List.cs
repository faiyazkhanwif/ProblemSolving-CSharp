using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    public class _0147
    {
        public ListNode InsertionSortList(ListNode head)
        {
            int size = 0;
            ListNode curr = head;
            while (curr != null)
            {
                size++;
                curr = curr.next;
            }

            int[] arr = new int[size];

            curr = new ListNode();
            curr = head;

            int ind = 0;

            while (curr != null)
            {
                arr[ind] = curr.val;
                curr = curr.next;
                ind++;

            }

            for (int i = 1; i < arr.Length; i++)
            {   //Storing the element that we are comparing
                int elm = arr[i];
                //looping through previous elements to compare with our element
                int j = i - 1;

                while (j > -1 && elm < arr[j])
                {
                    //if our element is greater than previous elements we shift the previous elements to the right
                    arr[j + 1] = arr[j];
                    j--;
                }
                //inserting element after shifting
                arr[j + 1] = elm;
            }

            ind = 0;
            curr = new ListNode();
            curr = head;
            while (curr != null)
            {
                curr.val = arr[ind];
                ind++;
                curr = curr.next;
            }

            return head;
        }
    }
}
