namespace MostFrequentNumber
{
    using System;
    using System.Linq;
    public class FindMostFrequentNumber
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int maxCount = 0;
            int repeatingNumber = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentCount = 0;

                for (int j = i; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        currentCount++;
                    }
                }

                if (currentCount > maxCount)
                {
                    repeatingNumber = numbers[i];
                    maxCount = currentCount;
                }
            }

            Console.WriteLine(repeatingNumber);
        }
    }
}
