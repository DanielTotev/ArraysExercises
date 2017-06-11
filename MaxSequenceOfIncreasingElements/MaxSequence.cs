namespace MaxSequenceOfIncreasingElements
{
    using System;
    using System.Linq;

    public class MaxSequence
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var length = 1;
            var bestLength = 1;
            //var start = 0;
            var bestStart = 0; 
            for (int i = 1; i <= numbers.Length - 1; i++)
            {
                //start = i;
                if (numbers[i] - numbers[i - 1] >= 1)
                {
                    length++;
                    if (length > bestLength)
                    {
                        bestLength = length;
                        bestStart = i - (bestLength - 1);
                    }
                }
                else
                {
                    length = 1;
                }
            }
            for (int i = bestStart; i < bestStart + bestLength; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
        }
    }
}
