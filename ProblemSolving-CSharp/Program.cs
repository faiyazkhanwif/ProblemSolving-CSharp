int ClimbStairs(int n)
{
    return climb(n);

    int climb(int stepsLeft)
    {
        if (stepsLeft < 0)
        {
            return 0;
        }

        if (stepsLeft == 0)
        {
            return 1;
        }

        return climb(stepsLeft - 1) + climb(stepsLeft - 2);

    }
}

//O(n) Top down DP with Memoization
int ClimbStairsDP(int n)
{
    Dictionary<int, int> dpCache = new Dictionary<int, int>();
    return climb(n);

    int climb(int stepsLeft)
    {
        if (dpCache.ContainsKey(stepsLeft))
        {
            return dpCache[stepsLeft];
        }
        else
        {
            if (stepsLeft < 0)
            {
                return 0;
            }

            if (stepsLeft == 0)
            {
                return 1;
            }

            dpCache[stepsLeft] = climb(stepsLeft - 1) + climb(stepsLeft - 2);

            return dpCache[stepsLeft];

        }
    }
}

Console.WriteLine(ClimbStairsDP(3)); 
//Console.WriteLine(string.Compare("YMQDBkOWy", "ubIEXAO"));

