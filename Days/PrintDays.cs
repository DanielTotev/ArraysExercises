namespace Days
{
    using System;
    public class PrintDays
    {
        static void Main(string[] args)
        {
            string[] days = { "Monday", "Tuesday" , "Wednesday" , "Thursday" , "Friday", "Saturday" , "Sunday" };
            int numberOfDay = int.Parse(Console.ReadLine());
            if (numberOfDay > 0 && numberOfDay <= 7)
            {
                Console.WriteLine(days[numberOfDay - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
