public class Solution
{
    public int MaxArea(int[] heights)
    {
        int currentMaxArea = 0;
        for (int i = 0; i < heights.Length; i++)
        {
            for (int j = i; j < heights.Length; j++)
            {
                int smallerHight = Math.Min(heights[i], heights[j]);
                int currentArea = smallerHight * (j - i);
                if (currentArea > currentMaxArea)
                {
                    currentMaxArea = currentArea;
                }
            }
        }
        return currentMaxArea;
    }

    //O(n)
    public int LeetCodeMaxArea(int[] heights)
    {
        int l = 0;
        int r = heights.Length - 1;
        int currentMaxArea = 0;
        while (l < r)
        {
            int minHight = Math.Min(heights[r], heights[l]);
            int currentHight = (r - l) * minHight;
            if (currentHight > currentMaxArea)
                currentMaxArea = currentHight;
            if (heights[r] < heights[l])
                r--;
            else
                l++;
        }
        return currentMaxArea;
    }
}
partial class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Testing");
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
        var result = solution.MaxArea(heights);
        Console.WriteLine($"{testcount}) Result: {result}");
        testcount++;
    }

}
