using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Lesson_05
{
    public class CreateTextFile
    {
        public string Filename { get; set; }
        public string CreateFile(string Filename)
        {
            // Задание 1 Ввод информации в текстовый файл

            

            Console.WriteLine("Введите текст для записи в файл ");
            string filename = "text.txt";
            File.WriteAllText(filename, Console.ReadLine());

            string fileText = File.ReadAllText(filename);
            
            return filename;
        }

        public void info()
        {
            Console.WriteLine(CreateFile(Filename));
        }

    }
}
