using System;
using System.IO;

namespace FullLessons
{
    class Program
    {
        static void Main(string[] args)
        {

            // Задание 1 Вывод содержимого каталога в текстовый файл
            Console.WriteLine("Задание 1 Вывод содержимого каталога в текстовый файл");
            string WorkDir = @"C:\Dz";
            string filename = @"C:\Dz\text.txt";
            Console.WriteLine(Directory.Exists(WorkDir));
            string notesDir = Path.Combine(WorkDir, "Notes");
            Directory.CreateDirectory(notesDir);
            string[] entries = Directory.GetFileSystemEntries(WorkDir, "*", SearchOption.AllDirectories);

            for (int i = 0; i < entries.Length; i++)
            {
                Console.WriteLine(entries[i]);
                
            }
            File.WriteAllLines(filename, entries);
            
        }
    }
}
