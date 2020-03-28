using System;

namespace Homework_CSharp_03__homeworks_Task_3___Bonus_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] trainers = { "Martin", "Dejan", "Ivo" };
            string[] g1 = { "Stefan", "Martin", "Petar" };
            string[] g2 = { "Dragce", "Irina", "Martina" };
            string[] g3 = { "Ilija", "Todor", "Pero" };
            string[] academySubjects = {"Web dev", "Paint","PS" };
            string[] announcments = { "Class is canceled!", "The exam will be on Friday!" };
            Console.WriteLine("Please enter you are trainer or a student?");
            string wheather = Console.ReadLine().ToLower();
            while (wheather != "trainer" && wheather != "student")
            {
                Console.WriteLine("Please re-enter you are trainer or a student?(write: trainer or student) ");
                wheather = Console.ReadLine().ToLower();
            }
            Console.WriteLine("Please enter you're name");
            string name = Console.ReadLine();
            if (wheather == "trainer")
            {
                int index1 = Array.IndexOf(trainers, name);
                if (index1 == -1)
                {
                    Console.WriteLine("Something went wrong.");
                } else
                {
                    Console.WriteLine("Students in G1: ");
                    foreach (var item in g1)
                    {
                        Console.WriteLine(item + " ");
                    }
                    Console.WriteLine("Students in G2: ");
                    foreach (var item in g2)
                    {
                        Console.WriteLine(item + " ");
                    }
                    Console.WriteLine("Students in G3: ");
                    foreach (var item in g3)
                    {
                        Console.WriteLine(item + " ");
                    }
                    Array.Resize(ref announcments, announcments.Length + 1);
                    Console.WriteLine("Enter new announcement");
                    announcments[announcments.Length - 1] = Console.ReadLine();
                }
            }
            else
            {
                int index2 = Array.IndexOf(g1, name);
                int index3 = Array.IndexOf(g2, name);
                int index4 = Array.IndexOf(g3, name);
                if (index2 == -1 && index3 == -1 && index4 == -1)
                {
                    Console.WriteLine("Something went wrong.");
                }
                else
                {
                    Console.WriteLine("All academy subjects: ");
                    foreach (var item in academySubjects)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("All announcments: ");
                    foreach (var item in announcments)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
