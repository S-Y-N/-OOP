using System;
using System.Globalization;
/*
 ДЗ №4 Си-шарп

Разработать класс "Самолет"
Реализовать закрытые поля разных типов, которые представляют основный характеристики класса
Создать не менее 3 методов управления классом и методы доступа к его закрытым полям
Создать метод, передачи аргумента по ссылке
Создать статические поля, что представляют общие хаарктеристики объектов данного класса

Тристан Евгений 
ПВ-011
 */
namespace FactoryBoeing
{
    class Boeing
    {
        static string name = "Boeing 737"; 
        static string manuf_country = "USA";
      

        private int _speed = 750;
        private int _ceilling_height = 11600;
        private int _rangeOfFlight = 3800;
        private int _price = 50000000;
        private string _type = "Пассажирский";
        private string _countryOperator ="ЕС, США, Азия";
        private int _count = 10681;

        public int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }
        public int Ceilling_height 
        { 
            get { return _ceilling_height; } 
            set {
                    if ( value <= 11600)
                    {
                        _ceilling_height = value;
                    }
                    else
                    {
                    Console.WriteLine("Опасная высота для полета! Максимум 11600 метров");
                    }
                } 
        }
        public int RangeOfFlight 
        {
            get { return _rangeOfFlight; }
            set {
                    if (value <= 3800)
                    {
                        _rangeOfFlight = value;
                    }
                    else 
                    {
                        Console.WriteLine("Для продолжения полета нужна дозаправка"); 
                    }
                 }
        }
        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public string Type { get { return _type; } set { _type = value; } }
        public string CountryOperator 
        {
            get {return _countryOperator; }
            set {_countryOperator=value; }
        }
        public int  Count 
        {
            get { return _count; }
            set { _count = value; } 
        }
        public void Print()
        {
            Console.WriteLine("Все характеристики самолета");
            Console.Write("Модель ");
            Console.WriteLine(Boeing.name);
            Console.Write("Страна изготовитель ");
            Console.WriteLine( Boeing.manuf_country) ;
           
            Console.WriteLine($"Скорость {Speed} км/ч, \nПотолочная высота {Ceilling_height} м,\nДальность полета {RangeOfFlight} км.\nЦена {Price} $\nТип самолета {Type}\nСтраны-эксплуатанты {CountryOperator} \nКоличество бортов в мире {Count}");
       
        }
        public void Instal()
        {
            Console.WriteLine("Установить характеристики самолета вручную");
            Console.WriteLine("Новая скорость самолета: ");
            Speed = int.Parse(Console.ReadLine());
            Console.WriteLine("Потолочная высота: ");
            Ceilling_height = int.Parse(Console.ReadLine());
            Console.WriteLine("Дальность полета: ");
            RangeOfFlight = int.Parse(Console.ReadLine());

            Print();
        }
        public int newPrice(ref int _price)
        {
            Console.WriteLine("Enter new price");
            int nprice = int.Parse(Console.ReadLine());
            return nprice;
        }
    }
}
    namespace Boeing
    {
        class Program
        {
            static void Main(string[] args)
            {

                FactoryBoeing.Boeing boeing = new FactoryBoeing.Boeing();
                Console.WriteLine("Выберите режим для демонстрации работы приложения: 1 - значения по умолчанию, 2 - ручной ввод");


                    int sel = int.Parse(Console.ReadLine());
                    switch (sel)
                    {
                        case 1:
                            boeing.Print(); break;

                        case 2:
                            boeing.Instal(); break;
                    }
            Console.ReadKey();
            System.Console.Clear();

            }

        }
    }
