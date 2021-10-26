using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenWonders
{
    class Halicarnassus
    {
        private static string _name = "Галикарнасский мавзолей ";
        private static string _data = "351 г до н.э  - 1494 г.";
        private static string _location = "Турция";

        public static string Info()
        {
            return $"Название чуда - {_name}, года существования {_data}, местоположение {_location}  ";
        }
    }
}
