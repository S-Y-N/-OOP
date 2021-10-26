using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace HW_3_Z_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер билета ( 6 цифр): \n");
            string str = Console.ReadLine();
            char[] ch = new char[str.Length];
            ch = str.ToCharArray();
            int[] ticket = ch.Select(s => int.Parse(s.ToString())).ToArray();
            if(ch.Length ==6)
            {
                int fisrt = 0;
                int second = 0;
                for (int i = 0; i < ch.Length; i++)
                {
                    if (i < 3)
                    {
                        fisrt += ticket[i];
                    }
                    else
                        second += ticket[i];
                }
                if(fisrt==second)
                {
                    Console.WriteLine("У Вас счастливый билет \n");
                }
                else
                {
                    Console.WriteLine("Вам не повезло");
                }
            }
            else
                Console.WriteLine("Ошибка ввода числа");
            Console.ReadKey();   
        }
    }
}
