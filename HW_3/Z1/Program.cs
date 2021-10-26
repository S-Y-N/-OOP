using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 ДЗ-3 
Задание 1.
Написать программу которая считывает символы с клавиатуры пока не будет введена точка.
Программа должна сосчитать к-во пробелов.

Тристан Евгений
ПВ-011
 */
namespace HoweWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любые символы: ");//вывод результатов только когда нажать .
            char symbols;
            int count = 0;
            do
            {
                symbols = (char)Console.ReadKey().KeyChar; //проверка на ключ
                if (symbols == ' ') //счет пробелов
                {
                    count++;
                }
            }
            while (symbols != '.');//цикл работает пока не ввели точку
                                   //другого варианта реализации пока не придумал
            //использование цикла do while, т.к. нужно инициализ перемен до while

            Console.WriteLine("\nКоличество пробелов {0}", count);

            Console.ReadKey();
        }
    }
}
