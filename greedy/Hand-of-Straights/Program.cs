public class Solution
{

    public bool IsNStraightHand(int[] hand, int groupSize)
    {
        PriorityQueue<int, int> minHeap = new();
        Dictionary<int, int> counter = new Dictionary<int, int>();
        if (hand.Length % groupSize != 0)
            return false;

        for (int i = 0; i < hand.Length; i++)
        {
            if (!counter.ContainsKey(hand[i]))
            {
                counter[hand[i]] = 1;
                minHeap.Enqueue(hand[i], hand[i]);
            }
            else
                counter[hand[i]] += 1;
        }
        bool flag = true;
        while (flag && minHeap.Count > 0)
        {
            int minVal = minHeap.Dequeue();
            if (counter[minVal] == 0)
                continue;
            if (counter[minVal] > 1)
                minHeap.Enqueue(minVal, minVal);
            for (int i = 0; i < groupSize; i++)
            {
                int val = minVal + i;
                if (!counter.ContainsKey(val) || counter[val] == 0)
                {
                    if (i > 0)
                        flag = false;
                    break;
                }
                else
                    counter[val] -= 1;
            }
        }
        return flag;
    }
}
partial class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Testing");
        Test([1, 2, 4, 2, 3, 5, 3, 4], 4);
        Test([1, 2, 3, 3, 4, 5, 6, 7], 4);
        Test([8, 10, 12], 3);



    }
    static int testcount = 1;
    static void Test(int[] hand, int groupSize)
    {
        var solution = new Solution();
        var result = solution.IsNStraightHand(hand, groupSize);
        Console.WriteLine($"{testcount}) Result: {result}");
        testcount++;
    }

}
