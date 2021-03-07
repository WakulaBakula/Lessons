using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.Text;

namespace Lesson_05
{
    public class CreateBinaryFile
    {

        public byte Num { get; set; }
        public int BinaryFile(int Num)
        {
            // Задание 3 Ввод чисел в бинарный файл

            int n;
            Console.WriteLine("Введите число элементов массива ");
            
            n = Convert.ToByte(Console.ReadLine());
            byte[] num = new byte[n];
            int i = 0;
            while (i < n)
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
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(new FileStream("bytes.bin", FileMode.OpenOrCreate), num);

            //File.WriteAllBytes("bytes.bin", num);
            return n;
        }

        public void info()
        {
            Console.WriteLine(BinaryFile(Num));
        }
    }
}
