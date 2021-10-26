using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenWonders
{
    class Zeus
    {
        private static string _name = "Статуя Зевса в Олимпии  ";
        private static string _data = "435 г до н.э  - 426 г. н. э.";
        private static string _location = "Греция";

        public static string Info()
        {
            return $"Название чуда - {_name}, года существования {_data}, местоположение {_location}  ";
        }
    }
}
