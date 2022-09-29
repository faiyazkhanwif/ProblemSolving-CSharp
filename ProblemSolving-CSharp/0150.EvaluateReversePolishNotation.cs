using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _0150
    {
        //O(n)
        public int EvalRPN(string[] tokens)
        {
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < tokens.Length; i++)
            {
                if (tokens[i] == "+" || tokens[i] == "-" || tokens[i] == "*" || tokens[i] == "/")
                {
                    int elementSecond = stack.Pop();
                    int elementFirst = stack.Pop();
                    if (tokens[i] == "+")
                    {
                        int res = elementFirst + elementSecond;
                        stack.Push(res);
                    }
                    else if (tokens[i] == "-")
                    {
                        int res = elementFirst - elementSecond;
                        stack.Push(res);
                    }
                    else if (tokens[i] == "*")
                    {
                        int res = elementFirst * elementSecond;
                        stack.Push(res);
                    }
                    else if (tokens[i] == "/")
                    {
                        int res = elementFirst / elementSecond;
                        stack.Push(res);
                    }
                }
                else
                {
                    stack.Push(int.Parse(tokens[i]));
                }
            }

            return stack.Pop();
        }
    }
}
