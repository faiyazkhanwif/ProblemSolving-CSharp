using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    public class _0341
    {

    }

    // This is the interface that allows for creating nested lists.
    // You should not implement it, or speculate about its implementation
    public interface NestedInteger
    {

        // @return true if this NestedInteger holds a single integer, rather than a nested list.
        bool IsInteger();

        // @return the single integer that this NestedInteger holds, if it holds a single integer
        // Return null if this NestedInteger holds a nested list
        int GetInteger();

        // @return the nested list that this NestedInteger holds, if it holds a nested list
        // Return null if this NestedInteger holds a single integer
        IList<NestedInteger> GetList();
    }

    public class NestedIterator
    {

        IList<NestedInteger> _nestedList = new List<NestedInteger>();
        List<int> _flattenedList = new List<int>();
        int ind = 0;

        public NestedIterator(IList<NestedInteger> nestedList)
        {
            _nestedList = nestedList;
            flatten(_nestedList);
        }

        public void flatten(IList<NestedInteger> nestedList)
        {
            int i = 0;
            int len = nestedList.Count;

            //Console.WriteLine("length: "+len);
            while (i < len)
            {
                //Console.WriteLine("i: "+i);
                if (nestedList[i].IsInteger())
                {
                    _flattenedList.Add(nestedList[i].GetInteger());
                    //fi++;
                }
                else
                {
                    flatten(nestedList[i].GetList());

                }

                i++;
            }

            //for (int p = 0; p < _flattenedList.Count; p++)
            //{
            //    Console.Write(_flattenedList[p] + " ");
            //}
            //Console.WriteLine("Ok");

        }


        public bool HasNext()
        {
            //Console.WriteLine("HasNext Ok");
            return ind < _flattenedList.Count;
        }

        public int Next()
        {

            ind = ind + 1;
            //Console.WriteLine("ind: "+(ind-1));
            //Console.WriteLine("Next Ok "+ _flattenedList[ind-1]);
            return _flattenedList[ind - 1];
        }
    }

    /**
     * Your NestedIterator will be called like this:
     * NestedIterator i = new NestedIterator(nestedList);
     * while (i.HasNext()) v[f()] = i.Next();
     */
}
