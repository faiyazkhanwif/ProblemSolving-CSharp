﻿ string SortSentence(string s)
{
    string[] words = s.Split(' ');
    string res = "";

    Dictionary<int, string> result = new Dictionary<int, string>();

    for (int i = 0; i < words.Length; i++)
    {
        string tempword = words[i];
        char ind = tempword[tempword.Length - 1];

        string word = words[i].Remove(words[i].Length - 1);

        Console.WriteLine(ind + "---" + word);

        int intind = ind - '0';
        result.Add(intind, word);
    }

    for (int i = 1; i <= words.Length; i++)
    {
        res += result[i];
        if (i != words.Length)
        {

            res += " ";
        }
    }

    return res;
}



Console.WriteLine(SortSentence("is2 sentence4 This1 a3"));
