public class Solution
{
    //Greedy
    public int Jump(int[] nums)
    {
        int res = 0, l = 0, r = 0;
        while (r < nums.Length - 1)
        {
            int farthest = 0;
            for (; l < r + 1; l++)
                farthest = Math.Max(farthest, l + nums[l]);
            l = r + 1;
            r = farthest;
            res = res + 1;
        }
        return res;
    }
}
partial class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Testing");
        Test([2, 4, 1, 1, 1, 1]);
        Test([2, 1, 2, 1, 0]);
        Test([1, 2, 0, 1, 0]);
        Test([1, 7, 2, 5, 4, 7, 3, 4]);
        Test([1, 7, 2, 5, 4, 7, 3, 6, 5]);
        Test([1, 2, 3, 4, 5, 6, 7, 8, 9]);

        Test([1, 2, 3, 4, 5, 6, 7, 8, 9, 10]);
    }
    static int testcount = 1;
    static void Test(int[] heights)
    {
        var solution = new Solution();
        var result = solution.Jump(heights);
        Console.WriteLine($"{testcount}) Result: {result}");
        testcount++;
    }

}
