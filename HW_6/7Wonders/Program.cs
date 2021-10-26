/*
 Написать программу 7 чудес света
Каждое чудо в своем классе
Отдельный класс для точки входа
Разделить на файлы и с помощью проостранства имен обеспечить взаимодействие классов
 */

using System;

namespace SevenWonders
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ColossusOfRhodes.Info());
            Console.WriteLine(Halicarnassus.Info());
            Console.WriteLine(Zeus.Info());
            Console.WriteLine(TempleOfArtemis.Info());
            Console.WriteLine(Babylon.Info());
            Console.WriteLine(PyramidOfGiza.Info());
            Console.WriteLine(LighthouseOfAlexandria.Info());


            Console.ReadKey();
        }
    }
}
