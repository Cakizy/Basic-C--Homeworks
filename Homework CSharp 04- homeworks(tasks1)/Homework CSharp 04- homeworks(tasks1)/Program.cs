using System;

namespace Homework_CSharp_04__homeworks_tasks1_
{
    class Program
    {
        static void Substrings()
        {
            string hello = "Hello from SEDC Codecademy v7.0";
            Console.WriteLine("Please enter a number n: ");
            bool inputNumber = int.TryParse(Console.ReadLine(), out int n);
            while (!inputNumber || n>hello.Length)
            {
                Console.WriteLine("Please re-enter a number n, don't mess with program!");
                inputNumber = int.TryParse(Console.ReadLine(), out n);
            }
            string newHello = hello.Substring(0, n);
            Console.WriteLine(newHello);
            Console.WriteLine("Length of the new string is: {0}", newHello.Length);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Substrings();
        }
    }
}
