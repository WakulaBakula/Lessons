using System;

namespace Lesson_03
{


    class Program
    {
        static void Main(string[] args)

        {

            //// 1 Задание Вывод элементов массива по диагонали
            Console.WriteLine("============================================");
            Console.WriteLine("Задание 1 Вывод элементов массива по диагонали");
            Console.WriteLine("============================================");
            Console.WriteLine("                                            ");
            Console.WriteLine("                                            ");

            //int[,] array01 = new int[5, 5];
            //array01[2, 2] = 1;

            //for (int i = 0; i < array01.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array01.GetLength(1); j++)
            //    {
            //        System.Console.Write(0);  //($"{array01[i, j]} ");
            //    }
            //    System.Console.WriteLine();
            //}


            //Console.WriteLine(array01);
            //foreach(int 3)







            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i == j)
                    {
                        Console.Write(i);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                //Console.WriteLine(i + " " + j);
                //Console.Write(0);

                Console.WriteLine();


            }

            ///2 Задание Справочник
            Console.WriteLine("============================================");
            Console.WriteLine(" Задние 2 Справочник адресов почты ");
            Console.WriteLine("============================================");
            Console.WriteLine("                                            ");
            Console.WriteLine("                                            ");

            {
                string[,] mailSprv = { { "Иванов", "Ридусов", "Хидеокодзимов", "Изенхорний", "Понтий" }, { "ivanov@mmamil.ru", "ridusov@mmail.ru", "hideo@mmail.ru", "izenhorn@mmail.ru", "pontii@mmail.ru" } };
                int rows = mailSprv.GetUpperBound(0) + 1;
                int columns = mailSprv.Length / rows;

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write($"{mailSprv[i, j]} \t");
                    }
                    Console.WriteLine();
                }
            }

            /// 3 Задание Вывод строки в обраном порядке
            
            Console.WriteLine("============================================");
            Console.WriteLine(" Задние 3 Вывод строки в обраном порядке ");            
            Console.WriteLine("============================================");
            Console.WriteLine("                                            ");
            Console.WriteLine("                                            ");



            {

                Console.Write("Введите строку: ");
                string str1 = Console.ReadLine();
                //string str1 = "Hello";
                //char s2 = str1[4];
                //Console.WriteLine(s2);
                //Console.WriteLine(str1.Length);
                //int s3 = s2 - 1;
                //if (int i = str1[4]; ; i--)
                //{
                //    Console.WriteLine(i);
                //}
                //string str1 = "Hello"; 
                string s2 = string.Empty;
                for (int i = str1.Length - 1; i > -1; i--)
                s2 += str1[i];
                Console.WriteLine(s2);


            }
            /// 4 Задание Морской бой

            Console.WriteLine("============================================");
            Console.WriteLine(" Задние 4 Морской бой ");
            Console.WriteLine("============================================");
            Console.WriteLine("                                            ");
            Console.WriteLine("                                            ");

            {

                int[,] seaFightPlace = new int[10, 10];
                //for ( seaFightPlace = [2, 3] )
                //{
                //    Console.Write("X");
                //}
                //seaFightPlace[2, 3] = 'X'; //ship01
                //seaFightPlace[3, 8] = 'X'; //ship01
                //seaFightPlace[2, 7] = 'X'; //ship01
                //seaFightPlace[5, 3] = 'X'; //ship01
                //seaFightPlace[5, 4] = 'X'; //ship01
                //seaFightPlace[6, 1] = 'X'; //ship01
                //seaFightPlace[5, 2] = 'X'; //ship01
                //seaFightPlace[9, 3] = 'X'; //ship01
                //seaFightPlace[9, 3] = 'X'; //ship01

                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {

                        //Console.Write($"{seaFightPlace[i, j] } ");
                        if (i == 2 && j == 3)
                        {
                            Console.Write("X");
                        }
                        else if (j == 0 && i == 0) // однопалубник
                        {
                            Console.Write("X");
                        }
                        else if ( j == 7 && i == 1) // однопалубник
                        {
                            Console.Write("X");
                        }
                        else if (j == 1 && i >= 7 && i <= 8) // двухпалубник
                        {
                            Console.Write("X");
                        }
                        else if (j == 0 && i >= 3 && i <= 5) // трёхпалубник
                        {
                            Console.Write("X");
                        }
                        else if (j == 5 && i == 4)
                        {
                            Console.Write("X");
                        }
                        else if (j == 9 && i >= 8 && i <=9) // двухпалубник
                        {
                            Console.Write("X");
                        }                     
                        else if (j == 3 && i == 7)
                        {
                            Console.Write("X");
                        }
                        else if (j >= 5 && j<= 9 && i == 6) // четырёхпалубник
                        {
                            Console.Write("X");
                        }
                        else
                        {
                            Console.Write("O");
                        }
                    }

                    //Console.WriteLine(i + " " + j);
                    //Console.Write(0);

                    Console.WriteLine();



                } 
            }
        }
    }
}
