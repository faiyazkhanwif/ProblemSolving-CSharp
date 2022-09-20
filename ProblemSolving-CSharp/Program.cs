
int count = 0;
int fibonacciDP(int n)
{
    Dictionary<int, int> dpCache = new Dictionary<int, int>();
    return fib(n);
    //Creating a local function "fib" so that we don't need to create "dpCache" as a global variable.
    int fib(int n)
    {
        count++;
        if (dpCache.ContainsKey(n))
        {
            return dpCache[n];
        }
        else
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                dpCache.TryAdd(n - 1, fib(n - 1));
                dpCache.TryAdd(n - 2, fib(n - 2));
                return dpCache[n - 1] + dpCache[n - 2];
            }
        }
    } 

} 
 
Console.WriteLine(fibonacciDP(10));
Console.WriteLine("Count: "+count);
//Console.WriteLine(string.Compare("YMQDBkOWy", "ubIEXAO"));

