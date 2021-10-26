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
    class Basement : IPart
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
            WriteLine("╔■■■■■■■■■■■■■■■■■■■■■■■■■╗\n"
                         + "║░░░░░░░░░░░░░░░░░░░░░░░░░║\n"
                          + "║░░░░░░░░░░░░░░░░░░░░░░░░░║\n"
                          + "║■■■■■■░░░░░░░	     ■■■■■║\n"
                          + "║░░░░░░░░░░░░░░░░░        ║\n"
                          + "║■■■■■■ ░░░░■■░ ■■   ■■■■■║\n"
                          + "║░░░░░░░░░░░■░░░░■░░░░░░░░║\n"
                          + "║░░░░░░░░░░░■    ■░░░░░░░░║\n"
                          + "╚■■■■■■■■■■■■■■■■■■■■■■■■■╝\n");

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
            WriteLine("Вид сверху\n"
                           + "╔■■■■■■■■■■■■■■■■■╗\n"
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
    class Walls : IPart
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
          + "      ╔═╝   ╔═╗   ╚═╗\n"
        + "    ╔═╝	    ╚═╝     ╚═╗\n"
      + "  ╔═╝		      ╚═╗\n"
    + "╔═╝			╚═╗\n"
    + "║			  ║\n"
    + "║  ╔═════╗	 ╔═════╗  ║\n"
    + "║  ║     ║	 ║     ║  ║\n"
    + "║  ╚═════╝       ╚═════╝  ║\n"
    + "║                         ║\n"
    + "╠═════════════════════════╣\n"
    + "╚═════════════════════════╝\n");

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
        

         public Human(string fName, string lastname)
        {
            _firstName = fName;
            _lastName = lastname;
        }

       

    }
    interface IWorker
    {
        bool CheckTeam { get; }
        void CreateTeam();
    }
    class Team : Human, IWorker
    {
        string _position;
        public Team(string fName, string lastname, string position) : base(fName, lastname)
        {
            _position = position;

        }
        bool _сheckTeam = true;
        public bool CheckTeam
        {
            get { return _сheckTeam; }
        }
        
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
    class Workers : Human, IWorker
    {
        string _position;
        public Workers(string fName, string lastname, string position) : base(fName, lastname)
        {
            _position = position;

        }
        bool _checkTeam = true;
        public bool CheckTeam
        {
            get { return _checkTeam; }
        }
        public void CreateTeam()
        {
            Console.WriteLine("Набираем работников");
        }
        public override string ToString()
        {
            return $"{_firstName},{_lastName},{_position}";
        }


    }
    class TeamLeader : Human, IWorker
    {
        string _position;
        public List<IWorker> ListOfWorkers { get; set; }
        bool _checkTeam = true;
        public bool CheckTeam
        {
            get { return _checkTeam; }
        }
        public TeamLeader(string fName, string lastname, string position):base(fName,lastname)
        {
            _position = position;

        }
        public void CreateTeam()
        {
            Console.WriteLine("Я тут главный");
        }
        public override string ToString()
        {
            return $"{_firstName},{_lastName},{_position}";
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ДЗ-9 Строительство дома\nПв-011 Тристан Евгений\n");
            Console.WriteLine("Добро пожаловать в программу \"Строим дом\"\n");
            Console.WriteLine("Нажмите Enter что бы продолжить...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            Console.Clear();
            Console.WriteLine("Первым делом нужно собрать бригаду.");
           
            Console.WriteLine("Трезвыми и умелыми ложить кирпичи ровно нашлись:\n");
            Thread.Sleep(100);
            TeamLeader tm = new TeamLeader("1.\tСан Саныч ", "", "Прораб");
            Console.WriteLine(tm.ToString());
            Thread.Sleep(100);
            Workers worker = new Workers("2.\tДжамшут", "Жантынбаев", "Умэу кэрпишь лажить");
            Console.WriteLine(worker.ToString());
            Thread.Sleep(100);
            Workers worker2 = new Workers("3.\tВася" , "Сокол", "Крыша, окна, это мое");
            Console.WriteLine(worker2.ToString());
            Thread.Sleep(100);
            Workers worker3 = new Workers("4.\tРавшен", "Джамамабаевовценюх", "Плытка, штукатуркэ, сынтэхника делать умеу, клэнусъ");
            Console.WriteLine(worker3.ToString());
            Thread.Sleep(100);


            Console.WriteLine("Нажмите Enter что бы продолжить...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            Console.Clear();
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

            Console.WriteLine("Стройка закончилась!\nПринимай работу, насяльник!");

            Console.ReadKey();
        }
    }
}
