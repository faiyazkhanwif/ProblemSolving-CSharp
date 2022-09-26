using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _0066
    {
        //O(n) - Smart way.
        public int[] PlusOne(int[] digits)
        {
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] == 9)
                {
                    digits[i] = 0;
                }
                else
                {
                    digits[i] = digits[i] + 1;
                    return digits;
                }
            }

            //The last part of code is only for the case that the whole input array is 9s.
            //For example : 99999-----> 100000
            //Any other case would return in the loop.
            var resized = new int[digits.Length + 1];
            resized[0] = 1;
            return resized;
        }

        //O(n) - Dumb way.
        public int[] PlusOneDumb(int[] digits)
        {
            string ansStr = "";

            int onHand = 0;
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    int tempRes = digits[i] + onHand;
                    if (i == digits.Length - 1)
                    {
                        tempRes += 1;
                    }
                    ansStr = tempRes.ToString() + ansStr;
                }

                else if (i == digits.Length - 1)
                {
                    int tempRes = digits[i] + 1;
                    if (tempRes > 9)
                    {
                        string tempstr = tempRes.ToString();
                        string tobeadded = tempstr[tempstr.Length - 1].ToString();
                        ansStr = tobeadded + ansStr;

                        onHand = int.Parse(tempstr[0].ToString());
                    }
                    else
                    {
                        ansStr = tempRes.ToString() + ansStr;
                        onHand = 0;
                    }
                }
                else
                {
                    int tempRes = digits[i] + onHand;
                    if (tempRes > 9)
                    {
                        string tempstr = tempRes.ToString();
                        string tobeadded = tempstr[tempstr.Length - 1].ToString();
                        ansStr = tobeadded + ansStr;

                        onHand = int.Parse(tempstr[0].ToString());
                    }
                    else
                    {
                        ansStr = tempRes.ToString() + ansStr;
                        onHand = 0;
                    }
                }

            }

            int[] resarr = new int[ansStr.Length];

            for (int i = 0; i < ansStr.Length; i++)
            {
                resarr[i] = int.Parse(ansStr[i].ToString());
            }

            return resarr;
        }
    }
}
