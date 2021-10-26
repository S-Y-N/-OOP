using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 ДЗ -2
Задание 2
Ввести с клавиатуры номер билета(6-ное число) и проверить его на удачу. Если сумма первых трех чисел
равна сумме второй тройки чисел - счастливый.

Тристан Евгений
ПВ-011
 */
namespace СчастливыйБилетик_Сшарп
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер трамвайного билета:(6 цифр) ");
            string str = Console.ReadLine();
            char[] ch = new char[str.Length];
            ch = str.ToCharArray();
            int[] ticket = ch.Select(s => int.Parse(s.ToString())).ToArray();
            if (ch.Length == 6)
            {
                int firstNumber = 0;
                int secondNumber = 0;
                for (int i = 0; i < ch.Length; i++)
                {
                    if (i < 3)
                    {
                        firstNumber += ticket[i];
                    }
                    else secondNumber += ticket[i];
                }
                if (firstNumber == secondNumber)
                {
                    Console.WriteLine("У вас счастливый билетик: {0} = {1}", firstNumber, secondNumber);
                }
                else
                {
                    Console.WriteLine("У вас не счастливый билетик: {0} !={1}", firstNumber, secondNumber);
                }
            }
            else
                Console.WriteLine("Ошибка ввода числа!");
            Console.ReadKey();
        }
    }
}
