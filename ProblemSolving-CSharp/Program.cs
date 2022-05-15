int MaxConsecutive(int bottom, int top, int[] special)
{
    int maxflCnt = 0;
    Array.Sort(special);

    for (int i = 0; i < special.Length; i++)
    {
        int temp = (special[i] - bottom);
        if (temp > maxflCnt)
        {
            maxflCnt = temp;
        }
        bottom = special[i] + 1;
    }
    int cornercase = top - special[special.Length - 1];
    if (cornercase > maxflCnt)
    {
        maxflCnt = cornercase;
    }
    return maxflCnt;

}
    
/*
 [3,5,0,3,4]
 */
string[] arr = { "abba", "baba", "bbaa", "cd", "cd" };

