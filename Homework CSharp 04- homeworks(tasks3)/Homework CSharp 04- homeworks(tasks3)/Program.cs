﻿using System;

namespace Homework_CSharp_04__homeworks_tasks3_
{
    class Program
    {
        static int AgeCalculator(DateTime bDay)
        {
            DateTime today = DateTime.Now;
            int age = today.Year - bDay.Year;
            //if (Convert.ToInt32(bDay.Month) == Convert.ToInt32(DateTime.Now.Month))
            //{
            //    if (Convert.ToInt32(bDay.Day) <= Convert.ToInt32(DateTime.Now.Day))
            //    {
            //        return age +1;
            //    }
            //}
            return age;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter you're date of bday! (MM/DD/YYYY)");
            bool userInput = DateTime.TryParse(Console.ReadLine(), out DateTime bday);
            while (!userInput || bday > DateTime.Now)
            {
                Console.WriteLine("Enter correct birthday :/ (MM/DD/YYYY)");
                userInput = DateTime.TryParse(Console.ReadLine(), out bday);
            }

            Console.WriteLine("Youre age: " + AgeCalculator(bday));
            Console.ReadLine();
        }
    }
}
