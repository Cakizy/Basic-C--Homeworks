using System;

namespace Homework_CSharp_04__homeworks_tasks2_
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            Console.WriteLine(today);

            Console.WriteLine("Tomorrow is " + today.AddDays(3));
            Console.WriteLine("One month from now " + today.AddMonths(1));
            Console.WriteLine("one month and 3 days from now " + today.AddDays(3).AddMonths(1));
            Console.WriteLine("1 year and 2 months ago from today " + today.AddMonths(-2).AddYears(-1));
            Console.WriteLine("Month " + today.Month);
            Console.WriteLine("Year " + today.Year);
            Console.ReadLine();
        }
    }
}
