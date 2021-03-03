using System;
using System.IO;

namespace Lesson_05
{
    class Program
    {
        static void Main(string[] args)
        {

            CreateFile();
            DateTimeInStartup();
            BinaryFile();
        }

         static string CreateFile()
        {
            // Задание 1 Ввод информации в текстовый фал
            Console.WriteLine("Введите текст для записи в файл ");
            string filename = "text.txt";
            File.WriteAllText(filename, Console.ReadLine());

            string fileText = File.ReadAllText(filename);
            Console.WriteLine(filename);
            return filename;
        }

        static string DateTimeInStartup()
        {
            // Задание 2 Сегодняшнее время в файл startup.txt
            string filename = "startup.txt";
            var DateTameNow = DateTime.Now;
            string DateTameNow1 = Convert.ToString(DateTameNow);
            File.WriteAllText(filename, DateTameNow1);

            string fileText = File.ReadAllText(filename);
            Console.WriteLine(filename);
            return filename;
        }


        static int BinaryFile()
        {
            // Задание 3 Ввод чисел в бинарный файл

            int n;
            Console.WriteLine("Введите число элементов массива ");
            
            n = Convert.ToByte(Console.ReadLine());
            byte[] num = new byte[n];
            int i = 0;
            while(i < n)
            {
                Console.WriteLine("Введите элемент массива");
                num[i] = byte.Parse(Console.ReadLine());
                Console.WriteLine();
                i++;

            }
            foreach (var item in num)
            {
                Console.WriteLine(item);
            }
            File.WriteAllBytes("bytes.bin", num);
            return n;
        }
    }
}
