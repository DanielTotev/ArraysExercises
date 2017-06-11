namespace ReverseArray
{
    using System;
    using System.Linq;
    public class ReverseArr
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            numbers = numbers.Reverse().ToArray();
            //for (int i = 0; i < numbers.Length / 2; i++)
            //{
            //    int temp = numbers[i];
            //    numbers[i] = numbers[numbers.Length - i - 1];
            //    numbers[numbers.Length - i - 1] = temp;
            //}
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
