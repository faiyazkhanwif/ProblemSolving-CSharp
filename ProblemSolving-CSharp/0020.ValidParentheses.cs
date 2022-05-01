using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    public class _0020
    {
        public static bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (
                    s[i] == '(' ||
                    s[i] == '{' ||
                    s[i] == '['
                    )
                {
                    //Console.WriteLine(s[i]+ "dhukse");
                    stack.Push(s[i]);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    else
                    {
                        if (GetOppositeParentheses(stack.Peek()) == s[i])
                        {
                            stack.Pop();
                        }
                        else
                        {
                            return false;
                        }
                    }

                }
            }
            return stack.Count == 0;
        }

        static char GetOppositeParentheses(char c)
        {
            if (c == '(')
            {
                return ')';
            }
            else if (c == '{')
            {
                return '}';
            }
            else if (c == '[')
            {
                return ']';
            }
            else
            {
                return '-';
            }
        }
    }
}
