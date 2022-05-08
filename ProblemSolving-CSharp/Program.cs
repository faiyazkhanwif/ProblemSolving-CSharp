bool test(int[] nums)
{
    Stack<int> myStack = new Stack<int>();

    int len = nums.Length;

    if (len < 3)
    {
        return false;
    }

    int two = int.MinValue;
    for (int i = len - 1; i >= 0; i--)
    {
        //Console.WriteLine("Checking: "+nums[i]);
        if (myStack.Count == 0)
        {
            myStack.Push(nums[i]);
        }
        else
        {

            if (myStack.Peek() > nums[i])
            {
                if (nums[i] < two)
                {
                    return true;
                }
                myStack.Push(nums[i]);

            }
            else if (nums[i] > myStack.Peek())
            {
                while (myStack.Count!=0 && nums[i] > myStack.Peek())
                {
                    int temp = myStack.Pop();

                    if (temp > two)
                    {
                        two = temp;
                    }
                }

                myStack.Push(nums[i]);

            }
        }

    }
    return false;
}
/*
 [3,5,0,3,4]
 */
int[] arr = { 3,1,4,2 };

Console.WriteLine(test(arr));
