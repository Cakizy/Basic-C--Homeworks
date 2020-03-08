using System;

namespace Homework_C_Sharp_02___homeworks_tasks_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1 Start ---------------------------------------------------------------------------------

            //double firstNumber;
            //double secondNumber;
            //double sum;

            //Console.WriteLine("Welcome to real calculator!");

            //Console.WriteLine("Enter the First number: ");
            //firstNumber = InputNumber();

            //Console.WriteLine("Enter the Second number: ");
            //secondNumber = InputNumber();

            //Console.WriteLine("Enter the Operation: ");
            //string operatorString = Console.ReadLine();
            //switch (operatorString)
            //{
            //    case "*":
            //        sum = firstNumber * secondNumber;
            //        Console.WriteLine($"The result is: {sum} ");
            //        break;
            //    case "/":
            //        sum = firstNumber / secondNumber;
            //        Console.WriteLine($"The result is: {sum} ");
            //        break;
            //    case "+":
            //        sum = firstNumber + secondNumber;
            //        Console.WriteLine($"The result is: {sum} ");
            //        break;
            //    case "-":
            //        sum = firstNumber - secondNumber;
            //        Console.WriteLine($"The result is: {sum} ");
            //        break;
            //    default:
            //        Console.WriteLine("You need to enter operator between: + , - , / , *");
            //        break;
            //}
            //Console.ReadLine();

            //Task 1 END -----------------------------------------------------------------------------------
            //Task 2 Start ---------------------------------------------------------------------------------

            //int firstNumber;
            //int secondNumber;
            //int thirdNumber;
            //int fourthNumber;
            //int average;
            //Dokolku e ova pogresen nacin za variablive sto ne go kratam kodot pisete mi vaka gi pisuvam zatoa sto neli najgore se inicijalziraat pa posle koga ni treba rabotime so niv

            //Console.WriteLine("Welcome to Average Number!");

            //Console.WriteLine("Enter the First number: ");
            //firstNumber = Convert.ToInt32(InputNumber());

            //Console.WriteLine("Enter the Second number: ");
            //secondNumber = Convert.ToInt32(InputNumber());

            //Console.WriteLine("Enter the Third number: ");
            //thirdNumber = Convert.ToInt32(InputNumber());

            //Console.WriteLine("Enter the Fourth number: ");
            //fourthNumber = Convert.ToInt32(InputNumber());
            //average = (firstNumber + secondNumber + thirdNumber + fourthNumber)/4;
            //Console.WriteLine($"The average of {firstNumber}, {secondNumber}, {thirdNumber} and {fourthNumber} is: {average}");
            //Console.ReadLine();

            //Task 2 END -----------------------------------------------------------------------------------
            //Task 3 Start ---------------------------------------------------------------------------------

            double firstNumber;
            double secondNumber;
            double helper;
            Console.WriteLine("Welcome to Swap Numbers!");

            Console.WriteLine("Please enter the First Number");
            firstNumber = InputNumber();

            Console.WriteLine("Please enter the Second Number");
            secondNumber = InputNumber();

            helper = firstNumber;
            firstNumber = secondNumber;
            secondNumber = helper;
            Console.WriteLine($"After Swapping: First Number: {firstNumber}, Second Number: {secondNumber}");
            Console.ReadLine();

            //Task 3 END -----------------------------------------------------------------------------------
        }
        static double InputNumber()
        {
            bool parsingNumber = double.TryParse(Console.ReadLine(), out double number);
            while (!parsingNumber)
            {
                Console.WriteLine("Whoops, something went wrong, you need to enter a number!");
                parsingNumber = double.TryParse(Console.ReadLine(), out number);
            }
            return number;
        }
    }
}
