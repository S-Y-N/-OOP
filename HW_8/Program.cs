using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Threading;

namespace СтроительствоДома
{
    interface IPart
    {
        bool Check { get; }
        void Build();
    }
    class Basement:IPart
    {
        bool isCheck = false;
        public bool Check
        {
            get { return isCheck; }
        }
       public void Build()
        {
            Console.WriteLine("Подготовка к строительству: вырываем котлован");
            Thread.Sleep(250);
            WriteLine     ("╔■■■■■■■■■■■■■■■■■■■■■■■■■╗\n"
                         + "║░░░░░░░░░░░░░░░░░░░░░░░░░║\n"
	                      +"║░░░░░░░░░░░░░░░░░░░░░░░░░║\n"
	                      +"║■■■■■■░░░░░░░	     ■■■■■║\n"
	                      +"║░░░░░░░░░░░░░░░░░        ║\n"
	                      +"║■■■■■■ ░░░░■■░ ■■   ■■■■■║\n"
                          +"║░░░░░░░░░░░■░░░░■░░░░░░░░║\n"
                          +"║░░░░░░░░░░░■    ■░░░░░░░░║\n"
                          +"╚■■■■■■■■■■■■■■■■■■■■■■■■■╝\n");

            Console.WriteLine("Теперь пора вызывать БЕ-ТО-НН\nМихалычь жги!");
            Thread.Sleep(1000);
            WriteLine("\n" +
                    " ___\n"
                + "\\/   \" ─ \n"
                + " \"____/║║─╖\n"
                + "  ╚─ОО───О─╛\n");
            Thread.Sleep(1000);
            WriteLine("Фундик залили, идем курить на 3 недели.");
            Thread.Sleep(1000);
            WriteLine("прошло три недели - ну шо - погнали ?:%!;!");
            WriteLine      ("Вид сверху\n"
                           +"╔■■■■■■■■■■■■■■■■■╗\n"
                          + "║░░░░░░░░░░░░░░░░░║\n"
                          + "║░░░░░░░░░░░░░░░░░║\n"
                          + "║░░░░░░░░░░░░░░░░░║\n"
                          + "║░░░░░░░░░░░░░░░░░║\n"
                          + "║░░░░░░░░░░░░░░░░░║\n"
                          + "║░░░░░░░░░░░░░░░░░║\n"
                          + "║░░░░░░░░░░░░░░░░░║\n"
                          + "╚■■■■■■■■■■■■■■■■■╝\n");
            Thread.Sleep(300);
            Console.WriteLine("вид сбоку");
            WriteLine(
                            "      _____________________________\n"
                          + "     /░░░░░░░░░░░░░░░░░░░░░░░░░░░░░/|\n"
                          + "    /░░░░░░░░░░░░░░░░░░░░░░░░░░░░░/ /\n"
                          + "   /░░░░░░░░░░░░░░░░░░░░░░░░░░░░ / /\n"
                          + "  /░░░░░░░░░░░░░░░░░░░░░░░░░░░░░/ /\n"
                          + " /░░░░░░░░░░░░░░░░░░░░░░░░░░░░░/ /\n"
                          + "|______________________________|/\n");
            Console.WriteLine("Фундамент готов, теперь пора строить стены!");

        }
    }
    class Walls:IPart
    {
        bool isCheck = true;
        public bool Check
        {
            get { return isCheck; }
        }
        public void Build()
        {
            Console.WriteLine("Возводим стены");
            Thread.Sleep(100);
            Console.WriteLine("Фасад");
            Thread.Sleep(1000);
            WriteLine(
                           "╠───╧───╧───╧────╧────╧───╧───╣\n"
                         + "|			      |\n"
                         + "|			      |\n"
                         + "|   ╔═══╗     ╔══╗     ╔═══╗  |\n"
                         + "|   ║   ║     ║  ║     ║   ║  |\n"
                         + "|   ╚═══╝     ║  ║     ╚═══╝  |\n"
                         + "╒═════════════╚══╝════════════╕	\n"
                         + "╘═════════════════════════════╛ \n");
            Thread.Sleep(1500);
            WriteLine("Фронтон	1");
            WriteLine("        ╔═════════╗\n"
	      +"      ╔═╝   ╔═╗   ╚═╗\n"
	    +"    ╔═╝	    ╚═╝     ╚═╗\n"
	  +"  ╔═╝		      ╚═╗\n"
	+"╔═╝			╚═╗\n"
	+"║			  ║\n"
	+"║  ╔═════╗	 ╔═════╗  ║\n"
	+"║  ║     ║	 ║     ║  ║\n"
	+"║  ╚═════╝       ╚═════╝  ║\n"
	+"║                         ║\n"
	+"╠═════════════════════════╣\n"
	+"╚═════════════════════════╝\n");
            
            Thread.Sleep(1500);
            WriteLine("Фронтон	2\n");
            WriteLine("        ╔═════════╗\n"
          + "      ╔═╝   ╔═╗   ╚═╗\n"
        + "    ╔═╝	    ╚═╝     ╚═╗\n"
      + "  ╔═╝		      ╚═╗\n"
    + "╔═╩═════════════════════╩═╗\n"
    + "║			  ║\n"
    + "║ 	  ╔═══════╗	  ║\n"
    + "║  	  ║       ║	  ║\n"
    + "║  	  ║	  ║  	  ║\n"
    + "║         ║       ║       ║\n"
    + "╠═════════╚═══════╝═══════╣\n"
    + "╚═════════════════════════╝\n");

            Thread.Sleep(1500);
            WriteLine("Арьергард\n");
            WriteLine(
                          "╠───╧───╧───╧────╧────╧───╧───╣\n"
                        + "|			      |\n"
                        + "|			      |\n"
                        + "|   ╔═══╗     ╔══╗     ╔═══╗  |\n"
                        + "|   ║   ║     ╚══╝     ║   ║  |\n"
                        + "|   ╚═══╝              ╚═══╝  |\n"
                        + "╒═════════════════════════════╕	\n"
                        + "╘═════════════════════════════╛ \n");
            Thread.Sleep(1500);
        }
    }
    class Door : IPart
    {
        bool isCheck = true;
        public bool Check
        {
            get { return isCheck; }
        }
        public void Build()
        {
            Console.WriteLine("Ставим дверь");
            WriteLine("Установка дверей");
            WriteLine(
                           "   ___________________________\n"
                         + "  /▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\\\n"
                         + " /▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\\\n"
                         + "/╠───╧───╧───╧────╧────╧───╧───╣\\\n"
                          + " |			       |\n"
                         + " |   ╔═╦═╗     ╔══╗     ╔═╦═╗  |\n"
                         + " |   ║░║░║     ║▓▓║     ║░║░║  |\n"
                         + " |   ╚═╩═╝     ║▓▓║     ╚═╩═╝  |\n"
                         + " ╒═════════════╚══╝════════════╕	\n"
                         + " ╘═════════════════════════════╛ \n");
            Thread.Sleep(1500);
        }
    }
    class Windows : IPart
    {
        bool isCheck = true;
        public bool Check
        {
            get { return isCheck; }
        }
        public void Build()
        {
            Console.WriteLine("Вставляем окна");
            WriteLine("Доустановка окон");
            WriteLine(
                           "           /▓▓▓▓\\\n"
                         + "         /▓▓▓▓▓▓▓▓\\              \\\n"
                         + "       /▓▓▓▓▓▓▓▓▓▓▓▓\\\n"
                         + "     /▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\\\n"
                          + "  /▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\\\n"
                         + "/▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓\\\n"
                         + "╔═════════════════════════╗\n"
                         + "║			  ║\n"
                         + "║			  ║\n"
                          + "║ 	  ╔═══╦═══╗	  ║\n"
                          + "║  	  ║░░░║░░░║	  ║\n"
                            + "║  	  ║░░░║░░░║  	  ║\n"
                             + "║         ║░░░║░░░║       ║\n"
                              + "╠═════════╚═══╩═══╝═══════╣\n"
                         + "╚═════════════════════════╝ \n");
            Thread.Sleep(1500);
        }
    }
    class Roof : IPart
    {
        bool isCheck = true;
        public bool Check
        {
            get { return isCheck; }
        }
        public void Build()
        {
            WriteLine("Поднимаем крышу");
            Thread.Sleep(333);
            WriteLine("Установка крышы");
            WriteLine(
                           "   ___________________________\n"
                         + "  /		              \\\n"
                         + " /			       \\\n"
                         + "/╠───╧───╧───╧────╧────╧───╧───╣\\\n"
                          + " |			       |\n"
                         + " |   ╔═══╗     ╔══╗     ╔═══╗  |\n"
                         + " |   ║   ║     ║  ║     ║   ║  |\n"
                         + " |   ╚═══╝     ║  ║     ╚═══╝  |\n"
                         + " ╒═════════════╚══╝════════════╕	\n"
                         + " ╘═════════════════════════════╛ \n");
            Thread.Sleep(1500);

        }
    }
    abstract class Human
    {
        public string _firstName { get; set; }
        public string _lastName { get; set; }
        public string _position { get; set; }
       

        public override string ToString()
        {
            return $"\nФамилия {_lastName}, Имя {_firstName}, должность {_position}";
        }

    }
    interface IWorker
    {
        bool CheckTeam { get; }
        void CreateTeam();
    }
    class Team: Human, IWorker
    {
        bool _сheckTeam = true;
        public bool CheckTeam
        {
            get { return _сheckTeam; }
        }
        public List<IWorker> ListOfWorkers { get; set; }
        public void JobTeamLead()
        {
            Console.WriteLine("Проверять и контролировать криворуких");
        }
        public void JobWorkers()
        {
            Console.WriteLine("Делать что скажут");
        }
        public void CreateTeam()
        {
            Console.WriteLine("Собираем бригаду строителей");
        }
    }
    class Workers:Human, IWorker
    {
        bool _checkTeam = true;
        public bool CheckTeam
        {
            get { return _checkTeam; }
        }
        public void CreateTeam()
        {
            Console.WriteLine("Набираем работников");
        }
      
       
    }
    class TeamLeader:Human, IWorker
    {

        bool _checkTeam = true;
        public bool CheckTeam
        {
            get { return _checkTeam; }
        }
        public void CreateTeam()
        {
            Console.WriteLine("Я тут главный");
        }
       
    }



    class Program
    {
        static void Main(string[] args)
        {
            
            Basement basement = new Basement();
            basement.Build();
            Walls walls = new Walls();
            walls.Build();
            Roof roof = new Roof();
            roof.Build();
            Door door = new Door();
            door.Build();
            Windows windows = new Windows();
            windows.Build();
            

            Console.ReadKey();
        }
    }
}
