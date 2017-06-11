namespace SieveOfEratosthenes
{
    using System;
  
    using System.Collections.Generic;
    public class FindAllPrimes
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool[] arr = new bool[n + 1];
            for (int i = 2; i < n; i++)
            {
                arr[i] = true;
            }
            List<int> result = new List<int>();
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (arr[i] == true)
                {
                    for (int j = 2; j * i < n; j+= i)
                    {
                        arr[(j * i)] = false;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == true)
                {
                    result.Add(i);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
