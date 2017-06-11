namespace LargestCommonEnd
{
    using System;
    using System.Linq;

    public class LargetsCommonEnd
    {
        public static void Main()
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();
            string[] moreWords = Console.ReadLine().Split(' ').ToArray();
            int length = words.Length > moreWords.Length ? moreWords.Length : words.Length;
            int leftCount = 0;
            for (int i = 0; i < length; i++)
            {
                if (words[i] == moreWords[i])
                {
                    leftCount++;
                }
            }
            int rightCount = 0;
            int longerArrLength = words.Length > moreWords.Length - 1 ? words.Length - 1 : moreWords.Length - 1;
            for (int i = length - 1; i >= 0; i--)
            {
                if (words.Length < moreWords.Length)
                {
                    if (words[i] == moreWords[longerArrLength])
                    {
                        rightCount++;
                    }
                }
                else
                {
                    if (words[longerArrLength] == moreWords[i])
                    {
                        rightCount++;
                    }
                }
               
                longerArrLength--;
            }
            Console.WriteLine(rightCount > leftCount ? rightCount : leftCount);
        }
    }
}
