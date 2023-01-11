using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    internal class _0981
    {
        public class TimeMap
        {
            class ValueTime
            {
                public string _value = "";
                public int _timestamp;
            }
            Dictionary<string, List<ValueTime>> vtMap;

            public TimeMap()
            {
                vtMap = new Dictionary<string, List<ValueTime>>();
            }

            public void Set(string key, string value, int timestamp)
            {
                if (!vtMap.ContainsKey(key))
                {
                    vtMap.Add(key, new List<ValueTime>());
                }
                vtMap[key].Add(
                    new ValueTime
                    {
                        _value = value,
                        _timestamp = timestamp
                    }
                );
            }


            //O(n)
            public string Get(string key, int timestamp)
            {
                if (vtMap.ContainsKey(key))
                {
                    if (vtMap[key].Count == 1)
                    {
                        return vtMap[key][0]._value;
                    }
                    else
                    {
                        string closestTimeStampValue = "";
                        foreach (ValueTime vtObj in vtMap[key])
                        {
                            if (vtObj._timestamp == timestamp)
                            {
                                return vtObj._value;
                            }
                            if (vtObj._timestamp < timestamp)
                            {
                                closestTimeStampValue = vtObj._value;
                            }
                        }
                        return closestTimeStampValue;
                    }
                }

                return "";
            }

            //O(logn)
            public string GetBinary(string key, int timestamp)
            {
                if (vtMap.ContainsKey(key))
                {
                    if (vtMap[key].Count == 1)
                    {
                        return vtMap[key][0]._value;
                    }
                    else
                    {
                        string closestTimeStampValue = "";
                        int timeDiff = int.MaxValue;
                        int startInd = 0;
                        int endInd = vtMap[key].Count - 1;

                        while (startInd <= endInd)
                        {
                            int midInd = startInd + (endInd - startInd) / 2;
                            ValueTime vtObj = vtMap[key][midInd];
                            if (vtObj._timestamp == timestamp)
                            {
                                return vtObj._value;
                            }
                            if (vtObj._timestamp > timestamp)
                            {
                                endInd = midInd - 1;
                            }
                            else
                            {
                                if (vtObj._timestamp < timestamp && timestamp - vtObj._timestamp < timeDiff)
                                {
                                    closestTimeStampValue = vtObj._value;
                                }
                                startInd = midInd + 1;
                            }
                        }
                        return closestTimeStampValue;
                    }
                }

                return "";
            }
        }

    }
}
