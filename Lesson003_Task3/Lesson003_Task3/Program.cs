using System;
using System.Text;

namespace Lesson003_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Загадка: Хто завжди правду каже?\nВідповідь (english) :");
            string answer = Console.ReadLine();

            if (answer == "Mirror" || answer == "mirror" || answer == "MIRROR" || answer == "mIRROR")
                Console.WriteLine("Відповідь правильна!");

            else
                Console.WriteLine("Відповідь неправильна!");
        }
    }
}
