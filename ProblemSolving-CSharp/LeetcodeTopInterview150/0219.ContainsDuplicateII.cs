using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp.LeetcodeTopInterview150
{
	class _0219
	{
		public bool ContainsNearbyDuplicate(int[] nums, int k)
		{
			Dictionary<int, List<int>> numberIndexDictionary = new Dictionary<int, List<int>>();

			for (int i = 0; i < nums.Length; i++)
			{
				if (numberIndexDictionary.ContainsKey(nums[i]))
				{
					foreach (int j in numberIndexDictionary[nums[i]])
					{
						if (i != j && Math.Abs(i - j) <= k)
						{
							Console.WriteLine(Math.Abs(i - j));
							return true;
						}
					}

					numberIndexDictionary[nums[i]].Add(i);
				}
				else
				{
					List<int> listOfIndexesForTheValue = new List<int>();

					listOfIndexesForTheValue.Add(i);

					numberIndexDictionary.Add(nums[i], listOfIndexesForTheValue);
				}
			}

			return false;
		}
	}
}
