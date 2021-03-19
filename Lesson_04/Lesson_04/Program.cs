using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_04
{ 
    enum Seasons
        {
            Name = 0,
            Winter = 1,
            Spring = 2,
            Summer = 3,
            Autumn = 4
        }
    class Program
    {
       

        static void Main(string[] args)
        {
            //// 1 Задание Вывод элементов массива по диагонали
            Console.WriteLine("============================================");
            Console.WriteLine("Задание 1 ");
            Console.WriteLine("============================================");
            Console.WriteLine("                                            ");
            Console.WriteLine("                                            ");
            //string[,] arrFullNames = {{ "Иван", "Поликарп", "Дмитрий", "Переявославль" }, { "Абарикуков", "Земандовансков", "Полиморфимов", "Ямельянов" },
            //{ "Павлович", "Серафимович", "Сергеевич", "Автозакович" } };
            string[] firstName = { "Иван", "Поликарп", "Дмитрий", "Переявославль" };
            string[] lastName = { "Абарикуков", "Земандовансков", "Полиморфимов", "Ямельянов" };
            string[] patronymic = { "Павлович", "Серафимович", "Сергеевич", "Автозакович" };


            //Console.WriteLine(GetFullName(lastName, firstName, patronymic));
            for (int i = 0; i < lastName.Length; i++)
            {
                //Console.WriteLine($"{lastName[i]} {firstName[i]} {patronymic[i]}");
                Console.WriteLine(GetFullName(lastName[i], firstName[i], patronymic[i]));

            }
            //// 2 Задание вывод суммы чисел введённых в строку
            Console.WriteLine("============================================");
            Console.WriteLine("Задание 2 ");
            Console.WriteLine("============================================");
            Console.WriteLine("                                            ");
            Console.WriteLine("                                            ");
            //StrDeform(); 

            //Console.WriteLine(name);

            Console.WriteLine(StrDeform(Console.ReadLine()));
            Console.WriteLine();



            //// 3 Задание Вывод сезона в соответствии с введённым номером месяца
            Console.WriteLine("============================================");
            Console.WriteLine("Задание 3 ");
            Console.WriteLine("============================================");
            Console.WriteLine("                                            ");
            Console.WriteLine("                                            ");
            
            Console.WriteLine("Введите номер месяца");
            int number = Convert.ToInt32(Console.ReadLine());
            //string str = Console.ReadLine();

            //Console.WriteLine(EnterNumberofMonth(Console.ReadLine()));
            if (number < 1 || number > 12)
            {
                Console.WriteLine("Такого месяца не существует! Введите номер от 1 до 12");
            }
            return;
            //Seasons seasons = GetSeasons(number);
            
            Console.WriteLine(GetSeasons(number));
            //Console.WriteLine();

            


        }


        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            //// 1 Задание Метод GetFullName

            //string Fullname = "";
            //foreach (var z in str1)
            //{
            //    Fullname += z + ' ';

            //}
            //return Fullname;

            return $"{firstName} {lastName} {patronymic}";
        } 

        static string StrDeform(string str2)
        {

            int sum = 0;

            //Console.WriteLine("Введите число");
            //string str = "";
            //Console.ReadLine();

            string[] str1 = str2.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(str1);
            foreach (string i in str1)
            {
                sum += Convert.ToInt32(i);
                //Console.WriteLine(i);
            }

                


            return Convert.ToString(sum);
        }

        static Seasons GetSeasons(int s)
        {
            string SeasonTitle = "";
            Seasons NameSeason =  Seasons.Name;
            switch (s)
            {
                case 12:
                case 1:
                case 2:
                    NameSeason = Seasons.Winter;
                    SeasonTitle = "Зима";
                    break;
                case 3:
                case 4:
                case 5:
                    NameSeason = Seasons.Spring;
                    SeasonTitle = "Весна";
                    break;
                case 6:
                case 7:
                case 8:
                    NameSeason = Seasons.Summer;
                    SeasonTitle = "Лето";
                    break;
                case 9:
                case 10:
                case 11:
                    NameSeason = Seasons.Autumn;
                    SeasonTitle = "Осень";
                    break;
            }
            Console.WriteLine(SeasonTitle);
            return NameSeason;
        }

        //static int EnterNumberofMonth(string str2)
        //{
        //    //Console.WriteLine("Введите номер месяца");
        //    str2 = Console.ReadLine();
            
        //    str2 = Convert.ToInt32();
            
        //    //do
        //    //{ 
        //        if (str2 < 1 || str2 > 12)
        //        {
        //            Console.WriteLine("Такого месяца не существует! Введите номер от 1 до 12");
        //        }
               

        //    //} while (number < 1 || number > 12);

        //    return str2;
        //}
    }
}
