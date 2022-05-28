using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_CSharp
{
    public class _6084
    {
        public string LargestWordCount(string[] messages, string[] senders)
        {
            Dictionary<string, int> wordcount = new Dictionary<string, int>();

            string maxOwner = "";
            int maxCount = int.MinValue;

            for (int i = 0; i < messages.Length; i++)
            {
                int words = messages[i].Split(' ').Length;

                if (wordcount.ContainsKey(senders[i]))
                {
                    wordcount[senders[i]] += words;
                }
                else
                {
                    wordcount.Add(senders[i], words);
                }
            }
            var list = new List<string>();
            for (int i = 0; i < senders.Length; i++)
            {
                int count = wordcount[senders[i]];
                // Console.WriteLine(senders[i] + "----------" + count);
                if (count > maxCount)
                {
                    list = new List<string>();
                    list.Add(senders[i]);
                    maxCount = count;
                }
                else if (count == maxCount)
                {
                    list.Add(senders[i]);
                }
            }
            list.Sort((x, y) => string.CompareOrdinal(x, y));
            return list.Last();

        }
    }
}
