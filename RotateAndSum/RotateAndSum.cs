namespace RotateAndSum
{
    using System;
    using System.Linq;

    public class RotateAndSum
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());
            int[] sum = new int[numbers.Length];

            for (int i = 0; i < k; i++)
            {
                int last = numbers[numbers.Length - 1];
                for (int j = numbers.Length - 1; j > 0; j--)
                {
                    numbers[j] = numbers[j - 1];
                }
                numbers[0] = last;
                for (int l = 0; l < numbers.Length; l++)
                {
                    sum[l] += numbers[l];
                }
            }
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
