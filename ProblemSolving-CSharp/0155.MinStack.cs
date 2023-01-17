using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _0155
    {
        //O(1)
        class Node
        {
            public int _val;
            public int _minValueTillNow;
        }
        public class MinStack
        {
            List<Node> stack; 
            public MinStack()
            {
                stack = new List<Node>(); 
            }

            public void Push(int val)
            {
                Node node = new Node
                {
                    _val = val
                };
                if (stack.Count==0)
                {
                    node._minValueTillNow = val;
                }
                else
                {
                    int prevMinVal = stack[stack.Count-1]._minValueTillNow;
                    if (val<prevMinVal)
                    {
                        node._minValueTillNow = val;
                    }
                    else
                    {
                        node._minValueTillNow = prevMinVal;
                    }
                }
                stack.Add(node);
            }

            public void Pop()
            {
                stack.RemoveAt(stack.Count - 1);
            }

            public int Top()
            {
                return stack[stack.Count - 1]._val;
            }

            public int GetMin()
            {
                return stack[stack.Count - 1]._minValueTillNow;
            }
        }

        /**
         * Your MinStack object will be instantiated and called as such:
         * MinStack obj = new MinStack();
         * obj.Push(val);
         * obj.Pop();
         * int param_3 = obj.Top();
         * int param_4 = obj.GetMin();
         */
    }
}
