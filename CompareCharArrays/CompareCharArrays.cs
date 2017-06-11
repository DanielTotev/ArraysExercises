namespace CompareCharArrays
{
    using System;
    using System.Linq;
    public class CompareCharArrays
    {
        public static void Main()
        {
            char[] firstCharArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] secondCharArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            int length = firstCharArray.Length > secondCharArray.Length ? secondCharArray.Length : firstCharArray.Length;
            bool LetterIsEqual = false;
            for (int i = 0; i < length; i++)
            {
                if (firstCharArray[i] == secondCharArray[i])
                {
                    LetterIsEqual = true;
                    continue;
                }
                else
                {
                    LetterIsEqual = false;
                    if (firstCharArray[i] > secondCharArray[i])
                    {
                        Console.WriteLine(string.Join("", secondCharArray));
                        Console.WriteLine(string.Join("", firstCharArray));
                    }
                    else
                    {
                        Console.WriteLine(string.Join("", firstCharArray));
                        Console.WriteLine(string.Join("", secondCharArray));
                    }
                    break;
                }
            }
            if (LetterIsEqual)
            {
                if (firstCharArray.Length == secondCharArray.Length)
                {
                    Console.WriteLine(string.Join("", firstCharArray));
                    Console.WriteLine(string.Join("", firstCharArray));
                }
                else
                {
                    string firstArr = firstCharArray.Length > secondCharArray.Length ? string.Join("", secondCharArray) : string.Join("",firstCharArray);
                    string secondArr = firstCharArray.Length > secondCharArray.Length ? string.Join("", firstCharArray) : string.Join("", secondCharArray);
                    Console.WriteLine(firstArr);
                    Console.WriteLine(secondArr);
                }
                
            }
        }
    }
}
