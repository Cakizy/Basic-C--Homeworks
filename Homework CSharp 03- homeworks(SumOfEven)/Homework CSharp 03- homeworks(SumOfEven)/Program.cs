using System;

namespace Homework_CSharp_03__homeworks_SumOfEven_
{
    class Program
    {
        static int InputNumber(int oNumber)
        {
            bool success = Int32.TryParse(Console.ReadLine(), out int number);
            while (!success)
            {
                Console.WriteLine("You need to enter a number!");
                Console.WriteLine("Enter integer no.{0}",oNumber);
                success = Int32.TryParse(Console.ReadLine(), out number);
            }
            return number;
        }
        static int Checker(int[] inputs)
        {
            int result = 0;
            foreach (var item in inputs)
            {
                if (item % 2 == 0)
                {
                    result += item;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter integer no.1");
            int firstNumber = InputNumber(1);
            Console.WriteLine("Enter integer no.2");
            int secondNumber = InputNumber(2);
            Console.WriteLine("Enter integer no.3");
            int thirdNumber = InputNumber(3);
            Console.WriteLine("Enter integer no.4");
            int fourthNumber = InputNumber(4);
            Console.WriteLine("Enter integer no.5");
            int fifthNumber = InputNumber(5);
            Console.WriteLine("Enter integer no.6");
            int sixthNumber = InputNumber(6);
            int[] userNumbers = {firstNumber,secondNumber,thirdNumber,fourthNumber,fifthNumber,sixthNumber};
            int result = Checker(userNumbers);
            if (result == 0)
            {
                Console.WriteLine("You don't have even numbers");
            }
            else Console.WriteLine("The result is: {0}",result);
            Console.ReadLine();
        }
    }
}
