//ДЗ-14 Счет для оплаты

//Разработать счет для оплаты 
//В классе реализовать соответ поля для расчета оплаты и штрафа есть есть задержка оплаты
//Результаты записывать и считывать с файла

using System;
using System.IO;
namespace HW_14
{
    class Payment
    {
        private double _payForDay { get; set; }//плата за день
        private int _days { get; set; }//к-во дней
        private double _penalty { get; set; }//штраф
        private int _daysOdDelay { get; set; }//к-во дней просрочки
        private float _sum { get; set; }//сумма к оплате
        private double _sumWithDelay { get; set; }//сумма к оплате со штрафом

        //переводим строку в числовый тип
        public void payForDay()
        {
            Console.WriteLine("Введите тариф оплаты:(сумма за день)");
            string spr = Console.ReadLine();
            float pr = float.Parse(spr);
            _payForDay = pr;
        }
        //метод для определения даты отсчета для рассчета
        DateTime dateBegging()
        {
            DateTime dt; //переменная типа ДатаТайм
            string inp1;//переменная будет принимать значения с клавиатуры и потом переводить в тип Дата

            do//цикл будет работать до тех пор, пока пользователь не введет дату в правильном формате
            {
                Console.WriteLine("Введите дату до которой нужно оплатить счет (в формате дд.мм.гггг(01.01.2001)");
                inp1 = Console.ReadLine();//считать дату с клавы
            }
            while (!DateTime.TryParseExact(inp1, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out dt));//переводит строковое значние в формат DateTime, в формате заданным мною, а именно dd.MM.yyyy, 
            //без форматирования, без стилизации, с передачений ссылки на еще не инициализированную переменную
            {
                return dt;//возврат той самой переменной
            }
        }
        DateTime dateEnding()//для вычисления второй даты
        {
            DateTime dt2;
            string inp2;

            do
            {
                Console.WriteLine("Введите текущую дату (в формате дд.мм.гггг(01.01.2001)");
                inp2 = Console.ReadLine();
            }
            while (!DateTime.TryParseExact(inp2, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out dt2));
            {
                return dt2;
            }
        }
        public void dateDiff()//вычесления разницы между двумя датами
        {
            DateTime d1;
            DateTime d2;
            d1 = dateBegging();
            d2 = dateEnding();
            TimeSpan diff = d2.Subtract(d1);//вычисления между датами c помощь структуры TimeSpan и ее метода Subtract
            int x = int.Parse(diff.Days.ToString()); //перевод результата в int, запарсить результат с типа DataTime. 2.00.00.00 ->2
            _daysOdDelay = x;//присвоения результата
            if (x > 0)
            {
                Console.WriteLine(x+" дней просрочки ");
            }
            else if (x < 0)
            {
                ;
            }
        }
        public void Penalty()//Вычесления штрафа
        {
            double ca1 = 0.1;//категории штрафов в зависимости от дней прострочки платежа
            double ca2 = 0.25;
            double ca3 = 0.5;
            Console.WriteLine("\nСумма штрафа вычисляется от цены тарифа.\nПросрочка на 1-5 дней  = 10%\n\t5-30 = 25%\n\tбольше 30 дней = 50% от цены тарифа");
            if(_daysOdDelay < 0)
            {//просрочки нет или оплатили раньше - голая сумма
                _penalty = 0 ;
                Console.WriteLine("Сумма штрафа: " + _penalty);
            }
            else if (_daysOdDelay > 0 && _daysOdDelay < 5)//вычесления для рассчета штрафов
            {
                _penalty = (_payForDay *_daysOdDelay) * ca1;
                Console.WriteLine("Сумма штрафа: " + _penalty);
            }
            else if (_daysOdDelay > 5 && _daysOdDelay < 30)
            {
                _penalty = (_payForDay * _daysOdDelay) * ca2;
                Console.WriteLine("Сумма штрафа: " + _penalty);
            }
            else if (_daysOdDelay > 30)
            {
                _penalty = (_payForDay * _daysOdDelay) * ca3;
                Console.WriteLine("Сумма штрафа: " + _penalty);
            }
            else {; }

            _sumWithDelay = _penalty + (_payForDay*_daysOdDelay);//присвоение к переменной сумма к оплате с штрафом
          
            Console.WriteLine("Сумма к оплате:" + Math.Abs(_sumWithDelay) + " грн");
        }

        class Program
        {

            static void Main(string[] args)
            {
                Console.WriteLine("***Домашнее Задание № 14***");
                Console.WriteLine("   Тристан Евгений");
                Console.WriteLine("->Разработать счет для оплаты");
                Console.WriteLine("->Реализовать оплату со штрафом за просрочку и без");
                Console.WriteLine("\nНажмите любуюю кнопку чтобы продолжить\n");

                Console.ReadKey();
                Console.Clear();
                Payment payment = new Payment();
                payment.dateDiff();
                payment.payForDay();
                payment.Penalty();
                string path = @"C:\Users\duost\source\repos\ConsoleApp8\ConsoleApp8\bin\Debug\netcoreapp3.1\payemnt.txt";//указываем путь к файлу, у каждого он может быть свой, так что этот момент нужно поправлять вручную на каждой машине
                try
                {
                    using(StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default))//создаение нового объекта, использую StreamWriter, он практичен для работы с текстом
                    {
                        sw.WriteLine(payment._payForDay);//вывод для результатов. По правильному, нужно для каждого поля свой файл или таблицу создавать
                        sw.WriteLine(payment._days);
                        sw.WriteLine(payment._penalty);
                        sw.WriteLine(payment._daysOdDelay);
                        sw.WriteLine(payment._sum);
                        sw.WriteLine(payment._sumWithDelay);

                    }
                    Console.WriteLine("Информация сохарнена в файл ");
                }
                catch(Exception ex)//обработка исключения
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine("Для чтения данных с файла нажмите N, для выхода нажмите Enter");
                string what = Console.ReadLine();
                Console.WriteLine();
                if (what == "n")
                {
                    Console.Clear();
                    Console.WriteLine("Вывод на экран записаных данных\n");

                    string pathFrom = @"C:\Users\duost\source\repos\ConsoleApp8\ConsoleApp8\bin\Debug\netcoreapp3.1\payemnt.txt";

                    try//чтения данных с файла
                    {
                        using (StreamReader sr = new StreamReader(pathFrom))
                        {
                            Console.WriteLine(sr.ReadToEnd());
                        }
                        Console.WriteLine("Для выхода нажмите любую кнопку");
                        Console.ReadKey();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else if (what =="")
                {
                    Console.WriteLine("До скорой встречи");
                    System.Threading.Thread.Sleep(1000);
                    return;
                }
            }
        }
    }
}
