using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenWonders
{
    class ColossusOfRhodes
    {
        private static string _name = "Колосс Родосский";
        private static string _data = "294 до н.э - 226 г. до н. э.";
        private static string _location = "Греция";

        public static string Info()
        {
            return $"Название чуда - {_name}, года существования {_data}, местоположение {_location}  ";
        }
    }
}
