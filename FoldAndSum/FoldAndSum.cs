namespace FoldAndSum
{
    using System;
    using System.Linq;
    public class FoldAndSum
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] firstPartOfFirstRow = numbers.Take(numbers.Length / 4).Reverse().ToArray();
            int[] secondPartOfFirstRow = numbers.Skip(numbers.Length - (numbers.Length / 4)).Take(numbers.Length / 4).Reverse().ToArray();
            int[] seondRow = numbers.Skip(numbers.Length / 4).Take(numbers.Length / 2).ToArray();
            int[] firstRow = new int[numbers.Length / 2];
            for (int i = 0; i < firstPartOfFirstRow.Length; i++)
            {
                firstRow[i] = firstPartOfFirstRow[i];
            }
            for (int i = 0; i < secondPartOfFirstRow.Length; i++)
            {
                firstRow[i + numbers.Length / 4] = secondPartOfFirstRow[i];
            }
            int[] sum = new int[numbers.Length / 2];
            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] = firstRow[i] + seondRow[i];
            }
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
