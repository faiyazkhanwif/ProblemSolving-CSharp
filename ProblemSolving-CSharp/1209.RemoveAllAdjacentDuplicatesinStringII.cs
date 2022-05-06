using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    public class _1209
    {

        //Unoptimized, works for 18/20.
        public string RemoveDuplicates(string s, int k)
        {
            string currchar = "";
            int i = 0;
            while (i < s.Length)
            {
                //Console.WriteLine("i ======== "+i);
                int adjOccCount = 1;
                currchar = s[i].ToString();
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (currchar.Equals(s[j].ToString()))
                    {
                        adjOccCount++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (adjOccCount == k)
                {
                    //Console.WriteLine("Current string: "+s);

                    s = s.Remove(i, k);
                    //Console.WriteLine("Updated: "+ s);
                    i = 0;
                }
                else
                {
                    i++;
                }
            }

            return s;
        }

        //Somewhat optimized, passes 19/20.
        public string RemoveDuplicateslittleopti(string s, int k)
        {
            Stack<string> stack = new Stack<string>();
            Stack<string> stack2 = new Stack<string>();
            string res = "";
            int adjCount = 0;
            for (int i = 0; i < s.Length; i++)
            {

                if (adjCount == 0)
                {
                    if (stack.Count != 0 && stack.Peek().Equals(s[i].ToString()))
                    {
                        while (stack.Peek().Equals(s[i].ToString()))
                        {
                            stack2.Push(stack.Pop());
                            adjCount++;
                            if (stack.Count == 0)
                            {
                                break;

                            }
                        }

                        stack2.Push(s[i].ToString());
                        adjCount++;
                    }
                    else
                    {

                        stack.Push(s[i].ToString());
                        adjCount = 1;
                    }
                }
                else
                {
                    if (stack2.Count == 0)
                    {
                        if (stack.Peek().Equals(s[i].ToString()))
                        {
                            stack2.Push(stack.Pop());
                            stack2.Push(s[i].ToString());
                        }
                        else
                        {
                            stack.Push(s[i].ToString());
                            adjCount = 0;
                        }
                    }
                    else
                    {
                        if (stack2.Peek().Equals(s[i].ToString()))
                        {
                            stack2.Push(s[i].ToString());
                        }
                        else
                        {

                            while (stack2.Count != 0)
                            {
                                stack.Push(stack2.Pop());
                                adjCount = 0;
                            }
                            stack.Push(s[i].ToString());
                        }
                    }
                    adjCount++;
                }

                if (adjCount == k)
                {
                    stack2.Clear();
                    adjCount = 0;
                }


            }

            while (stack2.Count != 0)
            {
                stack.Push(stack2.Pop());
                adjCount = 0;
            }

            while (stack.Count != 0)
            {
                res += stack.Pop();
            }
            string nres = "";
            for (int i = res.Length - 1; i >= 0; i--)
            {
                nres += res[i];
            }
            return nres;
        }

        //Optimized, passes 20/20
        public string RemoveDuplicatesOptimized(string s, int k)
        {
            var stack = new Stack<Pair>();

            foreach (var c in s)
            {
                if (stack.Count == 0)
                {
                    stack.Push(new Pair(c, 1));
                    continue;
                }

                var last = stack.Peek();
                if (last.Key == c)
                {
                    last.Count++;
                    if (last.Count == k)
                    {
                        stack.Pop();
                    }
                    continue;
                }

                stack.Push(new Pair(c, 1));
            }

            var ans = new StringBuilder();
            while (stack.Count > 0)
            {
                var last = stack.Pop();
                ans.Append(new string(last.Key, last.Count));
            }

            return new string(ans.ToString().Reverse().ToArray());
        }
    }


    class Pair
    {
        public Pair(char key, int count)
        {
            Key = key;
            Count = count;
        }

        public char Key;
        public int Count;
    }
}
