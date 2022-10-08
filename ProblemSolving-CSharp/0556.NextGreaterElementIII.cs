using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _0556
    {
        public int NextGreaterElement(int n)
        {
            char[] digits = n.ToString().ToCharArray();

            int firstVioIndex = 0;
            int firstIndexLargerThanVioDigit = 0;
            for (int i = digits.Length - 2; i >= 0; i--)
            {
                if (digits[i] < digits[i + 1])
                {
                    firstVioIndex = i;
                    break;
                }
            }

            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] > digits[firstVioIndex])
                {
                    firstIndexLargerThanVioDigit = i;
                    break;
                }
            }

            this.Swap(digits, firstVioIndex, firstIndexLargerThanVioDigit);

            int start = firstVioIndex + 1;
            int end = digits.Length - 1;
            if (firstVioIndex == 0 && firstIndexLargerThanVioDigit == 0)
            {
                return -1;
            }

            this.Reverse(digits, start, end);

            string digitsStr = new string(digits);
            try
            {
                return Int32.Parse(digitsStr);
            }
            catch
            {
                return -1;
            }
        }

        private void Swap(char[] digits, int i, int j)
        {
            char temp = digits[i];
            digits[i] = digits[j];
            digits[j] = temp;
        }

        private void Reverse(char[] digits, int start, int end)
        {
            while (start < end)
            {
                this.Swap(digits, start++, end--);
            }
        }
    }
}
