using System;

namespace Homework_CSharp_03__homeworks_tasks1_
{
    class Program
    {
        static void Students(string[] message, int group)
        {
            Console.WriteLine("The Students in G{0} are:", group);

            foreach (var item in message)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            string[] studentsG1 = { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
            string[] studentsG2 = { "Caki", "Petar", "Martin", "Gordon", "Filip" };

            Console.WriteLine("Please enter student group number: (1 or 2)");
            bool input1 = Int32.TryParse(Console.ReadLine(), out int group);
            while (group != 2 && group != 1)
            {
                Console.WriteLine("Whoops, something went wrong you need to input between 1 and 2 (G1 and G2)");
                input1 = Int32.TryParse(Console.ReadLine(), out group);
            }
            if (group == 1) Students(studentsG1, group);
            else Students(studentsG2, group);
            Console.ReadLine();
        }
    }
}
