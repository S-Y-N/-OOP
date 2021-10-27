/*
 ДЗ-15
Использовать классі BinaryReader & BinaryWriter для реализации простой программы учета товарных запасов
Для учета учитывать наименования, к-во и стомость товара

Релизовать поиск по названию товара.
Если товар найдет - показать про него информацию (цена, остаток на складе)

 */

using System;
using System.IO;

class Shina
{
    static void Main()
    {
        while(true)
        { 
        BinaryWriter dataOut;
        BinaryReader dataIn;

        string name;
        int balance;
        int price;

        try
        {
            dataOut = new BinaryWriter(new FileStream("infoshina.txt", FileMode.Create));
        }
        catch (IOException exc)
        {
            Console.WriteLine("Ну удается открыть файл товарных запасов для вывода");
            Console.WriteLine("Причина " + exc.Message);
            return;
        }

        try
        {
            dataOut.Write("Continental");
            dataOut.Write(12);
            dataOut.Write(1600);

            dataOut.Write("ROSAVA");
            dataOut.Write(18);
            dataOut.Write(750);

            dataOut.Write("Goodyear");
            dataOut.Write(52);
            dataOut.Write(1150);

            dataOut.Write("Nokian");
            dataOut.Write(24);
            dataOut.Write(1450);

            dataOut.Write("Dunlop");
            dataOut.Write(44);
            dataOut.Write(1850);

        }
        catch (IOException exc)
        {
            Console.WriteLine("Ошибка записи в файл товарныъ запасов");
            Console.WriteLine("Причина " + exc.Message);

        }
        finally
        {
            dataOut.Close();
        }
        Console.WriteLine();

        try
        {
            dataIn = new BinaryReader(new FileStream("infoshina.txt", FileMode.Open));
        }
        catch (IOException exc)
        {
            Console.WriteLine("Не удается открыть файл товарных запасов для ввода");
            Console.WriteLine("Причина " + exc.Message);
            return;
        }
        Console.WriteLine("Онлайн магазин автомобильных шин Инфошина");
        Console.WriteLine("Сейчас в наличии есть покрышки таких фирм:\n");
        Console.WriteLine("1.Continental\n2.ROSAVA\n3.Goodyear\n4.Nokian\n5.Dunlop\n");
        Console.WriteLine("\nНажмите любую клавишу для продолжения...");
        Console.ReadKey();
       
            Console.WriteLine("\nВведите наименования для поиска: ");
            Console.WriteLine("Для выхода ничего не вводите  и нажмите Enter\n");
            string what = Console.ReadLine();
            Console.WriteLine();
            if (what == "")
            {
                Console.WriteLine("До скорой встречи");
                System.Threading.Thread.Sleep(1000);
                return;
            }
            try
            {
                for (; ; )
                {
                    name = dataIn.ReadString();
                    balance = dataIn.ReadInt32();
                    price = dataIn.ReadInt32();

                    if (name.Equals(what, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Покрышка " + name + "\n" + balance + " еденицы в наличии\n" + "Цена :{0}грн за штуку", price);
                        Console.WriteLine("Общая стоимость всех покрышек  {0} =  {1} грн.", name, price * balance);
                        break;
                    }
                }
            }
            catch (EndOfStreamException)
            {
                Console.WriteLine("Предмет не найден");
            }
            catch (IOException exc)
            {
                Console.WriteLine("Ошибка чтения из фейла товарных запасов");
                Console.WriteLine("Причина " + exc.Message);
            }
            finally
            {
                dataIn.Close();
            }
            Console.ReadLine();
            Console.Clear();
        }
    }
}
