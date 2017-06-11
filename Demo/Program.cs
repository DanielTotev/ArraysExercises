namespace Demo
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var items = new int[10];
            items[3] = -10;
            items[5] = 20;
            items[0] = 150;
            Console.WriteLine(items[3]);

            var books = new string[10];
            books[0] = "aaa";
            books[1] = "bbbb";
            int n = int.Parse(Console.ReadLine());
            var numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        }
    }
}
