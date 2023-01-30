using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    class _0997
    {
		public int FindJudge(int N, int[][] trust)
		{
			if (trust.Length == 0)
			{
				if (N != 1)
				{
					return -1;
				}
				else
				{
					return N;
				}
			}
			Dictionary<int, int> trustCountpair = new Dictionary<int, int>();
			foreach (int[] trustpair in trust)
			{
				if (trustCountpair.ContainsKey(trustpair[0]))
				{
					trustCountpair[trustpair[0]]--;
				}
				else
				{
					trustCountpair.Add(trustpair[0], -1);
				}
				if (trustCountpair.ContainsKey(trustpair[1]))
				{
					trustCountpair[trustpair[1]]++;
				}
				else
				{
					trustCountpair.Add(trustpair[1], 1);
				}
			}

			for (int i = 1; i <= N; i++)
			{
				if (trustCountpair.ContainsKey(i) && trustCountpair[i] == N - 1)
				{
					return i;
				}
			}
			return -1;
		}
	}
}
