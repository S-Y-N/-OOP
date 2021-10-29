using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ДЗ 13 Тристан Евгений ПВ-011
namespace КарточнаяИгра
{
     public class Game //класс игра 
    {
        public List<Cards> cardsDeck; //создаем коллекцию (список карт)
        public List<Player> players;//колекция игроков

        private Random _random; //метод перемешивания карт
        private int _cardCount = 36;//количество карт
        public Game (int playerCount =2)//по умолчанию игроков 2
        {
            _random = new Random();//создаем метод рандом, выдел памяти под метод
            players = new List<Player>();//присвоение нового объекта коллекций
            for(int i=0; i<playerCount;i++)
            {
                players.Add(new Player());//добавить игрока
            }
            cardsDeck = createCardDeck();//создать раскладку
            mixCards(cardsDeck);//перемешать карты
            dealerCards(players, cardsDeck);//раздать карты игрокам
        }
        public List<Cards> createCardDeck()//создать коллекцию карточного стола
        {
            cardsDeck = new List<Cards>(); //колода карт = создаем коллекцю карт
            int suitCount = _cardCount / 4;//рубашки карт 4 шт, делим ко-во карт на 4 масти
            for(int i=0; i<suitCount;i++)//цикл будет работать от 1 до 9 (9 значений карт одной масти)
            {
                cardsDeck.Add(new Cards((CardValue)i, (CardSuit)0));//создание колоды по масти
                cardsDeck.Add(new Cards((CardValue)i, (CardSuit)1));
                cardsDeck.Add(new Cards((CardValue)i, (CardSuit)2));
                cardsDeck.Add(new Cards((CardValue)i, (CardSuit)3));
            }
            return cardsDeck;//возвратить колоду
        }
        public void mixCards(List<Cards> cards)//метод перемешивания карт
        {
            cards.Sort((a, b) => _random.Next(-2, 2));//метод Сортировки передает лямбду, что бы следующие карты перемешивало в диапазоне -2 +2
        }
        public void dealerCards(List<Player> players, List<Cards> cards)//раздача карт игрокам 
        {
            int currPl = 0;//к-во игроков
            for(int i=0; i<cards.Count;i++)
            {
                players[currPl].cards.Add(cards[i]);
                currPl++;
                currPl %= players.Count;
            }
        }
        public bool PlayerStep()//ходы игроков
        {
            Console.WriteLine("Ход игроков");
            Console.WriteLine("Игрок\tКарты\t\tХод");
            int maxValue = -1;
            Player playerWithMaxValue = null;//вначале карт у всех поровну
            Stack<Cards> cardStack = new Stack<Cards>();
            for(int i=0; i<players.Count;i++)
            {
                Player player = players[i];
                if(player.cards.Count>0)
                {
                    Cards cards = player.cards[_random.Next(player.cards.Count)];
                    Console.WriteLine($"{i}\t{player.cards.Count}\t\t{cards}");
                    player.cards.Remove(cards);

                    if((int)cards.value>maxValue)
                    {
                        maxValue = (int)cards.value;
                        playerWithMaxValue = player;
                    }
                    cardStack.Push(cards);
                }
            }
            playerWithMaxValue.cards.AddRange(cardStack);
            Console.WriteLine($"Забрал игрок {players.IndexOf(playerWithMaxValue)}");
            Console.WriteLine("\n");

            if(playerWithMaxValue.cards.Count == _cardCount)
            {
                Console.WriteLine($"Победил игрок номер {players.IndexOf(playerWithMaxValue)}");
                return false;
            }
            return true;
        }
    }
    public class Player
    {
        public List<Cards> cards = new List<Cards>();   
    }
    public enum CardValue
    {
         Шесть=0,Семь,Восемь,Девять,Десять,Валет,Дама,Король,ТУЗ
    }
    public enum CardSuit
    {
        Черви=0, Крести, Пики, Буби
    }
    public class Cards
    {
        public  readonly CardValue value;
        public readonly CardSuit suit;

        public Cards(CardValue value1, CardSuit suit1)
        {
            value = value1;
            suit = suit1;
        }
        public override string ToString()
        {
            return $"{ value} {suit}";  
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Домашнее задание 13***\"");
            Console.WriteLine("Тристан Евгений\nПВ=011");
            Console.WriteLine("=> Карточная игра \"Пяница\"");
            Console.WriteLine("=>Создать карточную игру с реализацией игроков, колодой на 36 карт, перемешивание карт случайным образом и раздачей");
            Console.WriteLine("=>Забирает карты игрок с картой вышего ранга");
            Console.WriteLine("=>Побеждает тот, у кого все карты");
            Console.WriteLine("\nНажмите любую клапишу чтобы продолжить");
            Console.ReadKey();
            Console.Clear();
              
            Console.WriteLine("Добро пожаловать в игру!");
            back:
                Console.WriteLine("Cколько игроков будет играть (минимум 2 максимум 6)?");
                string str = Console.ReadLine();
                int x = int.Parse(str);
            if (x >= 2 && x <= 6)
            {
                Game game = new Game(x);
                while (game.PlayerStep())
                {
                    Console.ReadKey();
                }
            }
            else 
            {
                Console.WriteLine("Недопустимое количество игроков");
                goto back;
            }
                Console.ReadKey();
         }      
       }  
    }


