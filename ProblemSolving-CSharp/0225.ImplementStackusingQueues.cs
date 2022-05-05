using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    public class _0225
    {

    }
    public class MyStack
    {
        public MyStack()
        {

        }

        Queue<int> q1 = new Queue<int>();
        Queue<int> q2 = new Queue<int>();

        public void Push(int x)
        {

            q1.Enqueue(x);

        }

        public int Pop()
        {
            int x = 0;
            while (q1.Count>1)
            {   
                q2.Enqueue(q1.Dequeue());
            }
            x = q1.Dequeue();
            while (q2.Count > 0)
            {
                int y = q2.Dequeue();
                q1.Enqueue(y);
            }
            return x;
        }

        public int Top()
        {
            int x = 0;

            while (q1.Count > 0)
            {
                x = q1.Dequeue();
                q2.Enqueue(x);

            }

            while (q2.Count > 0)
            {
                int y = q2.Dequeue();
                q1.Enqueue(y);
            }

            return x;
        }

        public bool Empty()
        {
            if (q1.Count>0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }

}
