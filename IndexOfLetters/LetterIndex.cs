namespace IndexOfLetters
{
    using System;
    using System.Collections.Generic;
    public class LetterIndex
    {
        public static void Main()
        {
            Dictionary<char, int> letters = new Dictionary<char, int>();
            letters['a'] = 0;
            letters['b'] = 1;
            letters['c'] = 2;
            letters['d'] = 3;
            letters['e'] = 4;
            letters['f'] = 5;
            letters['g'] = 6;
            letters['h'] = 7;
            letters['i'] = 8;
            letters['j'] = 9;
            letters['k'] = 10;
            letters['l'] = 11;
            letters['m'] = 12;
            letters['n'] = 13;
            letters['o'] = 14;
            letters['p'] = 15;
            letters['q'] = 16;
            letters['r'] = 17;
            letters['s'] = 18;
            letters['t'] = 19;
            letters['u'] = 20;
            letters['v'] = 21;
            letters['w'] = 22;
            letters['x'] = 23;
            letters['y'] = 24;
            letters['z'] = 25;
            string word = Console.ReadLine().ToLower();
            foreach (var character in word)
            {
                if (letters.ContainsKey(character))
                {
                    Console.WriteLine($"{character} -> {letters[character]}");
                }
            }
        }
    }
}
