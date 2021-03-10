using System;
using System.IO;
using System.Collections;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Text;

namespace FullLessons.Lesson_06
{
    class Class1
    {
        public static void ReadTxt()
        {

            string Path = @"C: \Users\korneev.i\Documents\Temp\ReadTxt";
            StreamReader textstream = new StreamReader(@"{Path}\list.txt", System.Text.Encoding.Default);
            ArrayList arr = new ArrayList();
            Regex regex = new Regex(@"\d{2}-\d{6}-\d{5}");

            foreach (var item in textstream)
            {
                using (FileStream fileStream = new FileStream($"{Path}\list.txt", FileMode.OpenOrCreate))
                {

                }
            }
            //string lines = File.ReadAllText(@"C:\Users\korneev.i\Documents\Temp\ReadTxt\list.txt");
            
            //int count = 0;
            //for (int i = 0; i < lines.Length; i++)
            //{
            //    File.WriteAllText(@"C:\Users\korneev.i\Documents\Temp\ReadTxt\Result.txt", )
            //}




        }
        
    }
}
