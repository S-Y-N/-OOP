using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 ДЗ-3 Задание 3
    Программа должна считывать с клавиатуры и конвертировать все символы нижнего регистра в верхний и наоборот
 
Тристан Евгений
Пв-011
 */
namespace HW_3_Z_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 32;
            int r = 0;
            Console.WriteLine("Введите любую фразу");
            string str = Console.ReadLine();
            char[] ch = str.ToCharArray();
            for (int i = 0; i < str.Length; i++)
            {
                ch[i] = str[i];
                if ((int)ch[i] >= 65 && (int)ch[i] <= 90)
                {
                    r = (int)ch[i] + a;
                }
                if ((int)ch[i] >= 97 && (int)ch[i] <= 122)
                {
                    r = (int)ch[i] - a;
                }
                Console.Write((char)r);
            }
            Console.ReadKey();
        }
       
    }
}
