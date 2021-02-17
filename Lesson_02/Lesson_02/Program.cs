using System;

namespace Lesson_02
{
    
    class Program
    {
       
        static void Main(string[] args)
        
        { 
            
            ///Задание 1 Среднесуточная температура
            Console.WriteLine("Задание 1 Среднесуточная температура");
            { 
                Console.WriteLine("Введите минимальную температуру за сутки");
                String MinTemp = Console.ReadLine();
                Console.WriteLine("Введите максимальную температуру за сутки");
                String MaxTemp = Console.ReadLine();
                int sMinTemp = Convert.ToInt32(MinTemp);
                int sMaxTemp = Convert.ToInt32(MaxTemp);
                int MidTempDay = (sMinTemp + sMaxTemp) / 2;
                Console.WriteLine($"Среднесуточная температура {MidTempDay}");
            
            
            } 
           // Задание 2 Вывод месяца по порядковому номеру
        
            {
                Console.WriteLine("Задание 2 Вывод месяца по порядковому номеру");
                { 
                Console.WriteLine("Введите номер месяца");
                String NumberMonth = Console.ReadLine();
                int sNumberMonth = Convert.ToInt32(NumberMonth);
                if (sNumberMonth < 1 || sNumberMonth > 12)
                {
                    Console.WriteLine("Такого месяца не существует! Введите номер от 1 до 12");
                    return ;
                }
                    //else if(sNumberMonth == 12 && MidTempDay > 0)
                    //    {
                    //    Console.WriteLine("Такого месяца не существует! Введите номер от 1 до 12");
                    //}
             
            //int[] Months = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            string MonthTitle = "";
            switch (sNumberMonth)
            {
                case 1:
                    MonthTitle = "Январь";
                    break;
                case 2:
                    MonthTitle = "Февраль";
                    break;
                case 3:
                    MonthTitle = "Март";
                    break;
                case 4:
                    MonthTitle = "Апрель";
                    break;
                case 5:
                    MonthTitle = "Май";
                    break;
                case 6:
                    MonthTitle = "Июнь";
                    break;
                case 7:
                    MonthTitle = "Июль";
                    break;
                case 8:
                    MonthTitle = "Август";
                    break;
                case 9:
                    MonthTitle = "Сентябрь";
                    break;
                case 10:
                    MonthTitle = "Октябрь";
                    break;
                case 11:
                    MonthTitle = "Ноябрь";
                    break;
                case 12:
                    MonthTitle = "Декабрь";
                    break;

                    


            }
            Console.WriteLine(MonthTitle); 
            }
            
            
            
            } 

            /// Задание 3 Проверка чисел на чётность

            {
                Console.WriteLine("Задание 3 Проверка чисел на чётность");
                Console.WriteLine("Введите число");
                String a = Console.ReadLine();
                long a1 = Convert.ToInt64(a);
                
                if (a1 % 2 == 0 )
                {
                    Console.WriteLine("Вы ввели чётное число");
                }
                else
                {
                    Console.WriteLine("Вы ввели нечётное число");
                    
                }
               
            }
                
            // Задание 4 Вывод Чека из магазина

            {
                Console.WriteLine("Задание 4 Вывод Чека из магазина");

                // наименование товаров
                string t1 = "Батон Нарезной в/с";
                string t2 = "Хлеб Хуторок Зерновой 400 гр.";
                string t3 = "БЗМЖ Сливки 10% 500 мл.";
                // цены товаров
                double c1 = 3.000 * 40.50 ; // 40.00 руб
                double c2 = 1.000 * 38.10; // 38.00 руб
                double c3 = 1.000 * 105.150; // 105.00 руб
                //Кассир
                string k1 = "Иванова Ивана Ивановна";

                double itogo = c1 + c2 + c3;

                Console.WriteLine("|---------------Белорусский-------------|");
                Console.WriteLine("|-----------------Дворик----------------|");
                Console.WriteLine("|-------------С Нами Вкусно!------------|");
                Console.WriteLine("|---------------------------------------|");
                Console.WriteLine("|--------------Кассовый чек-------------|");
                Console.WriteLine("| Товар " + t1 + "-|");
                Console.WriteLine("| Цена: ---------------------" + c1 + "-|");
                Console.WriteLine("| Товар " + t2 + "-|");
                Console.WriteLine("| Цена: ---------------------" + c2 + "-|");
                Console.WriteLine("| Товар " + t3 + "-|");
                Console.WriteLine("| Цена: ---------------------" + c3 + "-|");
                Console.WriteLine("|---------------------------------------|");
                Console.WriteLine("|---------------------------------------|");
                Console.WriteLine("|---------"+k1+"--------|");
                Console.WriteLine("|Итого: ---------------------" + itogo+"-|");
            }
        }
    }
}
