public class Solution
{
    public int MaxSubArray(int[] nums)
    {
        int maxSub = nums[0];
        int tempMaxSub = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            tempMaxSub = tempMaxSub + nums[i];
            if (tempMaxSub > maxSub)
                maxSub = tempMaxSub;
            if (tempMaxSub < 0)
                tempMaxSub = 0;
        }
        return maxSub;
    }
}
partial class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Testing container with most water");
        Test([2, -3, 4, -2, 2, 1, -1, 4]);
        Test([-1]);
        Test([-2, -1]);
        Test([1, 7, 2, 5, 4, 7, 3, 4]);
        Test([1, 7, 2, 5, 4, 7, 3, 6, 5]);
        Test([1, 2, 3, 4, 5, 6, 7, 8, 9]);

        Test([1, 2, 3, 4, 5, 6, 7, 8, 9, 10]);
    }
    static void Test(int[] heights)
    {
        var solution = new Solution();
        var result = solution.MaxSubArray(heights);
        Console.WriteLine($"Max Area: {result}");
    }

}
