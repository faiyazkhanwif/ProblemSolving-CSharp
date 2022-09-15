using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _0739
    {

        //O(n^2)
        public int[] DailyTemperatures(int[] temperatures)
        {
            for (int i = 0; i < temperatures.Length; i++)
            {
                int days = 0;
                for (int j = i + 1; j < temperatures.Length; j++)
                {
                    if (temperatures[i] < temperatures[j])
                    {
                        days = j - i;
                        break;
                    }
                }

                temperatures[i] = days;

            }
            return temperatures;

        }

        //O(n)
        public int[] DailyTemperaturesOpti(int[] temperatures)
        {
            int[] res = new int[temperatures.Length];  

            Stack<int> tempIndex = new Stack<int>();

            tempIndex.Push(0);

            for (int i = 1; i < temperatures.Length; i++)
            {
                while (tempIndex.Count != 0)
                {
                    if (temperatures[tempIndex.Peek()] < temperatures[i])
                    {
                        res[tempIndex.Peek()] = i - tempIndex.Pop();
                    }
                    else
                    {
                        break;
                    }
                }
                tempIndex.Push(i);
            }


            return res;
        }
    }
}
