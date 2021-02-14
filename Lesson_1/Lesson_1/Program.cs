using System;

namespace Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Ваше имя!");
            string Name = Console.ReadLine();
            var Date = DateTime.Now;
            
            Console.WriteLine($"Привет {Name}, сегодня {Date}");
        }
    }
}
