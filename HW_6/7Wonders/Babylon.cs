using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenWonders
{
    class Babylon
    {
        private static string _name = "Статуя Зевса в Олимпии  ";
        private static string _data = "6 век н.э";
        private static string _location = "Ирак";

        public static string Info()
        {
            return $"Название чуда - {_name}, года существования {_data}, местоположение {_location}  ";
        }
    }
}
