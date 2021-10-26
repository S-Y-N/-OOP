using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenWonders
{
    class TempleOfArtemis
    {
        private static string _name = "Храм Артемиды в Эфесе ";
        private static string _data = "Бронзовый век  - 4 век н.э.";
        private static string _location = "Турция";

        public static string Info()
        {
            return $"Название чуда - {_name}, года существования {_data}, местоположение {_location}  ";
        }
    }
}
