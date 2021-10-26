/*
 Разработать приложение, где сравнивается население 3 столиц.
Страны обозначаются пространством имен, а город - классом в данном пространстве

 */

using System;

namespace Ukraine
{
    class Kyiv
    {
        private static string _name = "Киев";
        private static ulong _population = 2952499;

        public static string Info()
        {
            return $"Столица Украины  - {_name}, Население {_population} человек";
        }
      
    }
}
namespace USA
{
    class WashingtonDC
    {
        private static string _name = "Вашингтон";
        private static ulong _population = 601723;

        public static string Info()
        {
            return $"Столица США  - {_name}, Население {_population} человек";
        }
    }
}
namespace Island
{
    class Reykjavík
    {
        private static string _name = "Рейкьявик";
        private static ulong _population = 368590;

        public static string Info()
        {
            return $"Столица США  - {_name}, Население {_population} человек";
        }
    }
}
namespace Three_Capitals
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine(Ukraine.Kyiv.Info());
            Console.WriteLine(USA.WashingtonDC.Info());
            Console.WriteLine(Island.Reykjavík.Info());

            Console.ReadKey();
        }
    }
}
