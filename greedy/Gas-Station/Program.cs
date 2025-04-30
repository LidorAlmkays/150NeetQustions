public class Solution
{
    public int CanCompleteCircuit(int[] gas, int[] cost)
    {
        int sumGas = 0, sumCost = 0, currentTotal = 0, startingIndex = 0;
        for (int i = 0; i < gas.Length; i++)
        {
            sumGas += gas[i];
            sumCost += cost[i];
        }
        if (sumCost > sumGas)
            return -1;
        for (int i = 0; i < gas.Length; i++)
        {
            currentTotal += gas[i] - cost[i];
            if (currentTotal < 0)
            {
                currentTotal = 0;
                startingIndex = i + 1;
            }
        }
        return startingIndex;
    }
}
partial class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Testing");
        Test([1, 2, 3, 4], [2, 2, 4, 1]);
        Test([1, 2, 3], [2, 3, 2]);
        Test([1, 2, 3, 4, 5], [3, 4, 5, 1, 2]);
        Test([3, 1, 1], [1, 2, 2]);


    }
    static int testcount = 1;
    static void Test(int[] gas, int[] cost)
    {
        var solution = new Solution();
        var result = solution.CanCompleteCircuit(gas, cost);
        Console.WriteLine($"{testcount}) Result: {result}");
        testcount++;
    }

}
