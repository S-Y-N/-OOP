using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenWonders
{
    class LighthouseOfAlexandria
    { 
        private static string _name = "Фаросский маяк";
        private static string _data = "247 до н.э - 1494 г. н. э.";
        private static string _location = "Египет";
        
        public static  string Info()
        {
            return $"Название чуда - {_name}, года существования {_data}, местоположение {_location}  ";
        }
    }
}
