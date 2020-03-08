using System;

namespace HomeWork_class_02
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Exercise 5 Start-----------------------------------------------------------------------------------------

            //double branches = 12;
            //double apples = 8;
            //double basketHold = 5;
            //Console.WriteLine("Enter how many trees you want have: ");
            //string input1 = Console.ReadLine();

            //bool convertedTrees = double.TryParse(input1, out double trees);

            //if (convertedTrees)
            //{
            //    double sum = trees * branches * apples;
            //    int finnalSum = Convert.ToInt32(sum) / Convert.ToInt32(basketHold);
            //    double sum2 = sum % basketHold;
            //    if (sum2 == 1)
            //    {
            //        Console.WriteLine($"You need to get {finnalSum + 1} baskets");

            //    }else
            //    {
            //    Console.WriteLine($"You need to get {finnalSum} baskets");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("You need to enter a number. :/");
            //}
            //Console.ReadLine();

            ////Exercise 5 END--------------------------------------------------------------------------------------------
            ////Exercise 6 START------------------------------------------------------------------------------------------
            //int num1;
            //int num2;


            //bool input1 = int.TryParse(Console.ReadLine(), out num1);

            //while (!input1)
            //{
            //    Console.WriteLine("You need to enter a Number");
            //    input1 = int.TryParse(Console.ReadLine(), out num1);
            //}

            //bool input2 = int.TryParse(Console.ReadLine(), out num2);

            //while (!input2)
            //{
            //    Console.WriteLine("You need to enter a Number");
            //    input2 = int.TryParse(Console.ReadLine(), out num2);
            //}


            //if (num1 > num2)
            //{
            //    if (num1 % 2 == 0)
            //    {
            //    Console.WriteLine($"\"{num1}\" is even and is larger then \"{num2}\"");
            //    }else
            //    {
            //        Console.WriteLine($"\"{num1}\" is odd and is larger then \"{num2}\"");
            //    }
            //} else if (num1 < num2)
            //{
            //    if (num2 % 2 == 0)
            //    {
            //        Console.WriteLine($"Entered Number({num2}) is an even and is larger then \"{num1}\"");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Entered Number({num2}) is an odd and is larger then \"{num1}\"");

            //    }
            //} else
            //{
            //    if (num1 %2 == 0)
            //    {
            //        Console.WriteLine($"\"{num1}\" and \"{num2}\" are equal and they are even");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"\"{num1}\" and \"{num2}\" are equal and they are odd");
            //    }
            //}

            //Console.ReadLine();
            ////Exercise 6 End--------------------------------------------------------------------------------------------
            ////Exercise 7 Start------------------------------------------------------------------------------------------
            int num1;

            Console.WriteLine("Please enter a number from 1 to 3");
            bool input1 = int.TryParse(Console.ReadLine(), out num1);

            while (!input1)
            {
                Console.WriteLine("ERROR: You need to enter a Number");
                input1 = int.TryParse(Console.ReadLine(), out num1);
            }
            switch (num1)
            {
                case 1:
                    Console.WriteLine("You got a new car!");
                    break;
                case 2:
                    Console.WriteLine("You got a new plane!");
                    break;
                case 3:
                    Console.WriteLine("You got a new bike!");
                    break;
                default:
                    Console.WriteLine("ERROR: You need to enter a number from 1 to 3");
                    break;
            }
            Console.ReadLine();
            ////Exercise 7 End--------------------------------------------------------------------------------------------

        }
    }
}
