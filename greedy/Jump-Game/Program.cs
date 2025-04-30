public class Solution
{

    //Greedy
    public bool CanJump(int[] nums)
    {
        int currentMaxJumpLength = nums[0];
        for (int i = 0; i < nums.Length - 1 && currentMaxJumpLength >= 0; i++)
        {
            if (nums[i] > currentMaxJumpLength)
                currentMaxJumpLength = nums[i];
            currentMaxJumpLength = currentMaxJumpLength - 1;
        }
        return currentMaxJumpLength >= 0;
    }

}
partial class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Testing");
        Test([1, 2, 0, 1, 0]);
        Test([2, -3, 4, -2, 2, 1, -1, 4]);
        Test([-1]);
        Test([1, 7, 2, 5, 4, 7, 3, 4]);
        Test([1, 7, 2, 5, 4, 7, 3, 6, 5]);
        Test([1, 2, 3, 4, 5, 6, 7, 8, 9]);

        Test([1, 2, 3, 4, 5, 6, 7, 8, 9, 10]);
    }
    static int testcount = 1;
    static void Test(int[] heights)
    {
        var solution = new Solution();
        var result = solution.CanJump(heights);
        Console.WriteLine($"{testcount}) Result: {result}");
        testcount++;
    }

}
