using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Lesson_05
{
    public class DateTimeNow
    {
        public string Filename { get; set; }
        public string DateTimeInStartup(string Filename)
        {
            // Задание 2 Сегодняшнее время в файл startup.txt
            string filename = "startup.txt";
            var DateTameNow = DateTime.Now;
            string DateTameNow1 = Convert.ToString(DateTameNow);
            File.WriteAllText(filename, DateTameNow1);

            string fileText = File.ReadAllText(filename);
            //Console.WriteLine(filename);
            return filename;
        }
        public void info()
        {
            Console.WriteLine(DateTimeInStartup(Filename));
        }
    }
}
