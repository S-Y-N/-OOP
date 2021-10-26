using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 ДЗ-2 Си-шарп
 Задание 1. 
Даны целые числа А и В ( А < B).
Вывести все целые числа от А до В включетельно. Выводить каждле число с новой строки и к-во = числу.

пример вывода 
1
2 2
3 3 3

Тристан Евгений
ПВ-011
 */
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;
            int i, j;
            Console.WriteLine("Введите два числа. Числа не могут быть меньше нуля");
            Console.WriteLine("Введите число А: ");
            A = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("Введите число B: ");
            B = Convert.ToUInt16(Console.ReadLine());
            Console.Write("\nResult: \n");
            for ( i = A; i <= B; i++)
            {
                for( j=1; j<=i; j++)
                {
                    Console.Write(i);
                    Console.Write(" ");                
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
