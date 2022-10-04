using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _0067
    {
        //Brute force
        public string AddBinary(string a, string b)
        {
            if (a.Length < b.Length)
            {
                string temp = a;
                a = b;
                b = temp;
            }


            int aInd = a.Length - 1;
            int bInd = b.Length - 1;

            string carry = "0";

            string ans = "0";

            while (aInd >= 0 && bInd >= 0)
            {
                if (aInd == a.Length - 1 && bInd == b.Length - 1)
                {
                    string[] sumAndCarry = add(a[aInd].ToString(), b[bInd].ToString());
                    carry = sumAndCarry[1];
                    ans = sumAndCarry[0];
                }
                else
                {
                    if (carry == "0")
                    {
                        string[] sumAndCarry = add(a[aInd].ToString(), b[bInd].ToString());
                        carry = sumAndCarry[1];
                        ans = sumAndCarry[0] + ans;

                    }
                    else
                    {
                        string[] sumAndCarry = add(a[aInd].ToString(), carry.ToString());
                        if (sumAndCarry[1] == "1")
                        {
                            carry = "1";
                        }
                        else
                        {
                            carry = "0";
                        }

                        sumAndCarry = add(sumAndCarry[0], b[bInd].ToString());

                        if (carry == "0")
                        {
                            carry = sumAndCarry[1];
                        }

                        ans = sumAndCarry[0] + ans;
                    }

                }


                aInd--;
                bInd--;

            }

            while (aInd >= 0 || bInd >= 0)
            {
                if (aInd >= 0 && bInd < 0)
                {
                    if (carry == "0")
                    {
                        ans = a[aInd].ToString() + ans;

                    }
                    else
                    {
                        string[] sumAndCarry = add(a[aInd].ToString(), carry.ToString());
                        if (sumAndCarry[1] == "1")
                        {
                            carry = "1";
                        }
                        else
                        {
                            carry = "0";
                        }

                        ans = sumAndCarry[0] + ans;
                    }

                    aInd--;
                }
                if (bInd >= 0 && aInd < 0)
                {
                    if (carry == "0")
                    {
                        ans = carry + b[bInd].ToString();

                    }
                    else
                    {
                        string[] sumAndCarry = add(b[bInd].ToString(), carry.ToString());
                        if (sumAndCarry[1] == "1")
                        {
                            carry = "1";
                        }
                        else
                        {
                            carry = "0";
                        }

                        ans = sumAndCarry[0] + ans;
                    }
                    bInd--;
                }
            }

            if (carry == "1")
            {
                ans = carry + ans;
            }
            return ans;
        }

        public string[] add(string p, string q)
        {
            string[] sumAndCarry = new string[2];
            if ((p == "1" && q == "0") || (p == "0" && q == "1"))
            {
                sumAndCarry[0] = "1";
                sumAndCarry[1] = "0";
            }
            if ((p == "1" && q == "1"))
            {
                sumAndCarry[0] = "0";
                sumAndCarry[1] = "1";
            }
            if ((p == "0" && q == "0"))
            {
                sumAndCarry[0] = "0";
                sumAndCarry[1] = "0";
            }
            return sumAndCarry;
        }
    }
}

