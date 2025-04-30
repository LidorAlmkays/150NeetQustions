public class Solution
{
    //version one worked but i can do better
    // public int Trap(int[] height)
    // {
    //     int maxLeft = 0, maxRight = 0;
    //     (int left, int right)[] maxHights = new (int, int)[height.Length];
    //     for (int i = 0; i < height.Length; i++)
    //     {
    //         if (height[height.Length - 1 - i] > maxRight)
    //             maxRight = height[height.Length - 1 - i];
    //         if (height[i] > maxLeft)
    //             maxLeft = height[i];
    //         maxHights[i].left = maxLeft;
    //         maxHights[height.Length - 1 - i].right = maxRight;
    //     }
    //     int sum = 0;
    //     for (int i = 0; i < height.Length; i++)
    //     {
    //         int waterToAdd = Math.Min(maxHights[i].left, maxHights[i].right) - height[i];
    //         if (waterToAdd > 0)
    //         {
    //             sum = sum + waterToAdd;
    //         }
    //     }
    //     return sum;
    // }
    public int Trap(int[] height)
    {
        int maxLeft = height[0], maxRight = height[height.Length - 1], sum = 0;
        int leftPointer = 0;
        int rightPointer = height.Length - 1;
        while (leftPointer != rightPointer)
        {
            if (maxLeft <= maxRight)
            {
                leftPointer++;
                if (height[leftPointer] > maxLeft)
                    maxLeft = height[leftPointer];
                if (height[leftPointer] < Math.Min(maxLeft, maxRight))
                    sum = sum + Math.Min(maxLeft, maxRight) - height[leftPointer];
            }
            else
            {
                rightPointer--;
                if (height[rightPointer] > maxRight)
                    maxRight = height[rightPointer];
                if (height[rightPointer] < Math.Min(maxLeft, maxRight))
                    sum = sum + Math.Min(maxLeft, maxRight) - height[rightPointer];
            }
        }
        return sum;
    }
}
partial class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Testing");
        Test(new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 });
        Test([0, 2, 0, 3, 1, 0, 1, 3, 2, 1]);
        Test([1, 7, 2, 5, 4, 7, 3, 6]);
        Test([2, 2, 2]);
        Test([1, 7, 2, 5, 4, 7, 3, 4]);
        Test([1, 7, 2, 5, 4, 7, 3, 6, 5]);
        Test([1, 2, 3, 4, 5, 6, 7, 8, 9]);

        Test([1, 2, 3, 4, 5, 6, 7, 8, 9, 10]);
    }
    static int testcount = 1;
    static void Test(int[] heights)
    {
        var solution = new Solution();
        var result = solution.Trap(heights);
        Console.WriteLine($"{testcount}) Result: {result}");
        testcount++;
    }

}
