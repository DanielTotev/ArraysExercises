namespace RoundNumbers
{
    using System;
    using System.Linq;

    public class RoundNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            var result = numbers.Select(x => Math.Round(x , MidpointRounding.AwayFromZero)).ToArray();
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{numbers[i]} => {result[i]}");
            }
        }
    }
}
