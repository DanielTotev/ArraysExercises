namespace PairsByDifference
{
    using System;
    using System.Linq;
    public class FindDifference
    {
        public static void Main()
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var difference = int.Parse(Console.ReadLine());
            var count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (Math.Abs(nums[i] - nums[j]) == difference)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
