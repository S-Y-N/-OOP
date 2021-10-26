using System;


namespace SevenWonders
{
    class PyramidOfGiza
    {
        private static string _name = "Пирамиды Гизы  ";
        private static string _data = "26 век н.э";
        private static string _location = "Египет";

        public static string Info()
        {
            return $"Название чуда - {_name}, года существования {_data}, местоположение {_location}  ";
        }
    }
}
