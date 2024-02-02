namespace Sequential_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //https://www.youtube.com/watch?v=Q-ca65wRJyI
            var low = 10; // 10
            var high = 30; /// 1000000000
            var ans = new Solution().SequentialDigits(low, high);
            Console.WriteLine(string.Join(",", ans));
        }
    }
    public class Solution
    {
        public IList<int> SequentialDigits(int low, int high)
        {
            var ans = new List<int>();
            var nos = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var queue = new Queue<int>(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            while (queue.Count > 0)
            {
                var no = queue.Dequeue();
                if (no > high)
                {
                    continue;
                }
                if (low <= no && no <= high)
                {
                    ans.Add(no);
                }
                var ones = no % 10;
                if (ones < 9)
                {
                    var newn = no * 10 + (ones + 1);
                    queue.Enqueue(newn);
                }
            }
            return ans;
        }
    }
}
