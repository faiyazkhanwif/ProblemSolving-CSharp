using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
	public class _0009
	{
		public bool IsPalindrome(int x)
		{
			string strX = x.ToString();

			return strX.Equals(new String(strX.Reverse().ToArray()));
		}
	}
}
