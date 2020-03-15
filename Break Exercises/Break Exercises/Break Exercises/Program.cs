using System;
using System.Text.RegularExpressions;

namespace Break_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Exercise 1. Flip the boolean

            //bool parsingNumber;
            //bool value;
            //Console.WriteLine("Please enter True or False!");
            //parsingNumber = bool.TryParse(Console.ReadLine(), out value);
            //while (!parsingNumber)
            //{
            //    Console.WriteLine("Error, incorrect value");
            //    parsingNumber = bool.TryParse(Console.ReadLine(), out value);
            //}
            //if (value)
            //{
            //    Console.WriteLine("False");
            //}
            //else
            //{
            //    Console.WriteLine("True");
            //}
            //Console.ReadLine();

            ////Exercise 2. Multiple of 100

            //bool parsingNumber;
            //int value;
            //Console.WriteLine("Please enter a number!");
            //parsingNumber = Int32.TryParse(Console.ReadLine(), out value);
            //while (!parsingNumber)
            //{
            //    Console.WriteLine("Can't you read? Enter a number, not anything else!");
            //    Console.WriteLine("Please enter a proper number!");
            //    parsingNumber = Int32.TryParse(Console.ReadLine(), out value);
            //}
            //int sum = value % 100;
            //if (sum == 0)
            //{
            //    Console.WriteLine("You have entered a cool number");
            //}
            //else
            //{
            //    Console.WriteLine("The number you've enterd is not cool at all!");
            //}
            //Console.ReadLine();

            ////Exercise 3. Return name of month

            //bool parsingNumber;
            //int value;

            //string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            //Console.WriteLine("Please enter a value from 1-12!");
            //parsingNumber = Int32.TryParse(Console.ReadLine(), out value);
            //while (!parsingNumber || value > 12 || value < 1)
            //{
            //    Console.WriteLine("Can't you read? Enter a value from 1-12!, not anything else!");
            //    Console.WriteLine("Please enter a proper value from 1-12!");
            //    parsingNumber = Int32.TryParse(Console.ReadLine(), out value);
            //}
            //Console.WriteLine("Your month is {0}", months[value -1]);
            //Console.ReadLine();

            ////Exercise 3. Profitable Gamble

            //double prob;
            //double prize;
            //double pay;
            //double sum;

            //Console.WriteLine("Please enter the prob!");
            //prob = InputNumber();
            //Console.WriteLine("Please enter the prize !");
            //prize = InputNumber();
            //Console.WriteLine("Please enter the pay !");
            //pay = InputNumber();
            //sum = prob * prize;
            //if (sum > pay)
            //{
            //    Console.WriteLine("You Won!");
            //}
            //else
            //{
            //    Console.WriteLine("You Lose!");
            //}

            ////Exercise 5. The Farm Problem

            //double chickens;
            //double cows;
            //double pigs;
            //double sum;

            //Console.WriteLine("Please enter how many chickens you have!");
            //chickens = InputNumber();
            //Console.WriteLine("Please enter how many cows you have!");
            //cows = InputNumber();
            //Console.WriteLine("Please enter how many pigs you have!");
            //pigs = InputNumber();

            //sum = chickens * 2 + cows * 4 + pigs * 4;
            //Console.WriteLine(sum);
            //Console.ReadLine();

            ////Exercise 6. Word count

            //Console.WriteLine("Please enter something!");
            //string words = Console.ReadLine();
            //int counter;
            //char[] delimiters = new char[] { ' ', '\r', '\n' };
            //counter = words.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Length;
            //Console.WriteLine(counter);
            //Console.ReadLine();

            ////Exercise 7. Liquor store
            //    string firstName;
            //    string lastName;
            //    string drinkName;
            //    Int32 age;
            //    Console.WriteLine("Welcome to Liquor store!");
            //    Console.WriteLine("Please enter your First Name");
            //    firstName = Console.ReadLine();
            //    while (Regex.IsMatch(firstName, @"\d"))
            //    {
            //        Console.WriteLine("Please don't use numbers and special characters in the First Name input!");
            //        firstName = Console.ReadLine();
            //    }
            //    Console.WriteLine("Please enter your Last Name");
            //    lastName = Console.ReadLine();
            //    while (Regex.IsMatch(lastName, @"\d"))
            //    {
            //    Console.WriteLine("Please don't use numbers and special characters in the Last Name input");
            //        lastName = Console.ReadLine();
            //    }
            //    Console.WriteLine("Please enter your Age");
            //    age = Convert.ToInt32(InputNumber());
            //    if (age > 18)
            //    {
            //        Console.WriteLine("What kind of drink you want to buy?");
            //        drinkName = Console.ReadLine();
            //        Console.WriteLine("Dear {0} {1}, here you go, a bottle of {2}, have a nice day!", firstName,lastName, drinkName);
            //    } else if (age < 18)
            //    {
            //        Console.WriteLine("Dear #firstName #lastName, I am sorry but you are not allowed to buy alchocol");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Please enter a valid input!");
            //    }
            //Console.ReadLine();

            ////Exercise 8. Coffe machine

            //int drinkChoose;
            //double sweetnes;
            //double money;
            //double missingMoney;
            //double[] prices = {2, 3.5, 4, 6, 1.5};
            //Console.WriteLine("Welcome dear customer, please select a drink:");
            //Console.WriteLine($"1.Espresso...........2$\n2.Macchiato........3.5$\n3.Latte..............4$\n4.Cappuccino.........6$\n5.Tea..............1.5$");
            //drinkChoose = Convert.ToInt32(InputNumber());
            //while (drinkChoose < 1 || drinkChoose > 5)
            //{
            //    Console.WriteLine("Please select a drink from 1 -5");
            //    drinkChoose = Convert.ToInt32(InputNumber());
            //}
            //Console.WriteLine("Please select a sweetnes from 1 - 5:");
            //sweetnes = InputNumber();
            //while (sweetnes < 1 || sweetnes > 5)
            //{
            //    Console.WriteLine("Please select sweetnes from 1 -5");
            //    sweetnes = InputNumber() - 1;
            //}
            //Console.WriteLine("Please input money as the drink costs");
            //money = InputNumber();
            //drinkChoose -= 1;
            //missingMoney = prices[drinkChoose] - money;
            //while (money < prices[drinkChoose])
            //{
            //    Console.WriteLine("The drink costs {0}! You're missing {1}!", prices[drinkChoose], missingMoney);
            //    Console.WriteLine("Please enter the remaining sum!");
            //    money += InputNumber();
            //}
            //Console.WriteLine("Have a good drink!");
            //Console.ReadLine();

            ////Exercise 9. Future prediction

            //int predictedNumber;
            //string[] predict = { "You got a jackpot 1.000.000EUR", "You will lost weights", "Your boyfriend will break up with you!", "Your cousine will buy you a dog!", "You will leave 100 years!" };
            //Random rnd = new Random();
            //predictedNumber = rnd.Next(5);

            //Console.WriteLine(predict[predictedNumber]);
            //Console.ReadLine();

            ////Exercise 10. Farenheit to Celsius conversion

            double celsius;
            double fahrenheit;
            double kelvin;
            Console.WriteLine("Please enter the number of celsius you want to convert:");
            celsius = InputNumber();
            fahrenheit = (celsius * 9 / 5) + 32;
            kelvin = celsius + 273.15;

            Console.WriteLine("{0}C = {1}F\n{0}C = {2}K", celsius,fahrenheit,kelvin);
            Console.ReadLine();
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
