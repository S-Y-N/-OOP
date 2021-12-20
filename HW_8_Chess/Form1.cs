using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public partial class Form1 : Form
    {
        public Image chessSprites;
        public int[,] map = new int[8, 8]
            {
                {15,14,13,12,11,13,14,15 },
                {16,16,16,16,16,16,16,16 },
                {0,0,0,0,0,0,0,0 },
                {0,0,0,0,0,0,0,0 },
                {0,0,0,0,0,0,0,0 },
                {0,0,0,0,0,0,0,0 },
                {26,26,26,26,26,26,26,26 },
                {25,24,23,22,21,23,24,25 },
            };

        public Button[,] butts = new Button[8, 8];

        public int currPlayer;
        public Button prevButton;
        public bool isMoving = false; //игрок сделал шаг
        public Form1()
        {
            InitializeComponent();
            base.Text = "Шахматы. ДЗ-8.Тристан";
            chessSprites = new Bitmap(Properties.Resources.img);
            Image part = new Bitmap(50, 50);
            Graphics g = Graphics.FromImage(part);
            g.DrawImage(chessSprites, new Rectangle(0, 0, 50, 50), 0, 0, 150, 150, GraphicsUnit.Pixel);

            Init();
        }
        public void Init()
        {
            map = new int[8, 8]
               {
                {15,14,13,12,11,13,14,15 },
                {16,16,16,16,16,16,16,16 },
                {0,0,0,0,0,0,0,0 },
                {0,0,0,0,0,0,0,0 },
                {0,0,0,0,0,0,0,0 },
                {0,0,0,0,0,0,0,0 },
                {26,26,26,26,26,26,26,26 },
                {25,24,23,22,21,23,24,25 },
               };
            currPlayer = 1;
            CreateMap();
        }
        public void CreateMap()
        {

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    butts[i, j] = new Button();

                    Button butt = new Button();
                    butt.Size = new Size(50, 50);
                    
                    butt.Location = new Point(j * 50, i * 50);
                   
                    switch (map[i, j] / 10)
                    {
                        case 1:
                            Image part = new Bitmap(50, 50);
                            Graphics g = Graphics.FromImage(part);
                            g.DrawImage(chessSprites, new Rectangle(0, 0, 50, 50), 0 + 150 * (map[i, j] % 10 - 1), 0, 150, 150, GraphicsUnit.Pixel);
                            butt.BackgroundImage = part;
                            break;
                        case 2:
                            Image part1 = new Bitmap(50, 50);
                            Graphics g1 = Graphics.FromImage(part1);
                            g1.DrawImage(chessSprites, new Rectangle(0, 0, 50, 50), 0 + 150 * (map[i, j] % 10 - 1), 150, 150, 150, GraphicsUnit.Pixel);
                            butt.BackgroundImage = part1;
                            break;
                    }

                    butt.BackColor = Color.White;
                    butt.Click += new EventHandler(OnFigurePress);
                    this.Controls.Add(butt);

                    butts[i, j] = butt;
                }
            }
        }
        
        public void OnFigurePress(object sender, EventArgs e)
        {
            if (prevButton != null)
                prevButton.BackColor = Color.White;
            Button pressedButton = sender as Button;

            if (map[pressedButton.Location.Y / 50, pressedButton.Location.X / 50] != 0 && map[pressedButton.Location.Y / 50, pressedButton.Location.X / 50] / 10 == currPlayer)//если по кнопкой что то есть - изменение цвета, если нет - ничего не делаем
            {
                CloseSteps();
                pressedButton.BackColor = Color.Red;
                DeactivateAll();
                pressedButton.Enabled = true;
                ShowSteps(pressedButton.Location.Y / 50, pressedButton.Location.X / 50, map[pressedButton.Location.Y / 50, pressedButton.Location.X / 50]);

                if (isMoving)
                {
                    CloseSteps();
                    pressedButton.BackColor = Color.White;
                    ActivateAll();
                    isMoving = false;
                }
                else isMoving = true;
            }
            else
            {
                if (isMoving)
                {
                    int temp = map[pressedButton.Location.Y / 50, pressedButton.Location.X / 50];
                    map[pressedButton.Location.Y / 50, pressedButton.Location.X / 50] = map[prevButton.Location.Y / 50, prevButton.Location.X / 50];
                    map[prevButton.Location.Y / 50, prevButton.Location.X / 50] = temp;
                    pressedButton.BackgroundImage = prevButton.BackgroundImage;
                    prevButton.BackgroundImage = null;
                    isMoving = false; // дает возможность сделать только 1 ход игроку
                    CloseSteps();
                    ActivateAll();
                    MultyPlayer();
                }
            }
            prevButton = pressedButton;
        }

        public void ShowSteps(int IccurFigure, int JcurrFigure, int currFigure)
        {
            int dir = currPlayer == 1 ? 1 : -1;
            switch(currFigure%10)
            {
                case 6:
                    if(InsideBorder(IccurFigure+1*dir, JcurrFigure))
                    {
                        if(map[IccurFigure+1*dir, JcurrFigure]==0)
                        {
                            butts[IccurFigure + 1 * dir, JcurrFigure].BackColor = Color.Yellow;
                            butts[IccurFigure + 1 * dir, JcurrFigure].Enabled = true;
                            if(InsideBorder(IccurFigure+2*dir,JcurrFigure))
                            {
                                if(map[IccurFigure+2*dir,JcurrFigure]==0)
                                {
                                    butts[IccurFigure + 2 * dir, JcurrFigure].BackColor = Color.Yellow;
                                    butts[IccurFigure + 2 * dir, JcurrFigure].Enabled = true;
                                }
                            }
                        }
                    }
                    if(InsideBorder(IccurFigure+1*dir,JcurrFigure+1))
                    {
                        if(map[IccurFigure+1*dir,JcurrFigure+1]!=0&&map[IccurFigure+1*dir,JcurrFigure+1]/10!=currPlayer)
                        {
                            butts[IccurFigure + 1 * dir, JcurrFigure + 1].BackColor = Color.Yellow;
                            butts[IccurFigure + 1 * dir, JcurrFigure + 1].Enabled = true;
                        }
                        if(InsideBorder(IccurFigure+1*dir,JcurrFigure-1))
                        {
                            if(map[IccurFigure+1/dir,JcurrFigure-1]!=0 && map[IccurFigure+1*dir, JcurrFigure-1]/10 !=currPlayer)
                            {
                                butts[IccurFigure + 1 * dir, JcurrFigure - 1].BackColor = Color.Yellow;
                                butts[IccurFigure + 1 * dir, JcurrFigure - 1].Enabled = true;
                            }
                        }
                    }
                    break;
                case 5:
                    ShowVerticalHorizontal(IccurFigure, JcurrFigure);break;
                case 4:
                    ShowHorseSteps(IccurFigure, JcurrFigure);break;
                case 3:
                    ShowDiagonal(IccurFigure, JcurrFigure);break;
                case 2:
                    ShowVertivalHorizontal(IccurFigure, JcurrFigure);
                    ShowDiagonal(IccurFigure, JcurrFigure);
                    break;
                case 1:
                    ShowVerticalHorizontal(IccurFigure, JcurrFigure, true);
                    ShowDiagonal(IccurFigure, JcurrFigure, true);
                    break;      
            }
        }

        public void ShowHorseSteps(int IccurFigure, int JcurrFigure)
        {
            if(InsideBorder(IccurFigure-2, JcurrFigure+1))
            {
                DeterminePath(IccurFigure - 2, JcurrFigure + 1);
            }
            if (InsideBorder(IccurFigure - 2, JcurrFigure - 1))
            {
                DeterminePath(IccurFigure - 2, JcurrFigure - 1);
            }
            if (InsideBorder(IccurFigure + 2, JcurrFigure + 1))
            {
                DeterminePath(IccurFigure + 2, JcurrFigure + 1);
            }
            if (InsideBorder(IccurFigure + 2, JcurrFigure - 1))
            {
                DeterminePath(IccurFigure + 2, JcurrFigure - 1);
            }
            if (InsideBorder(IccurFigure - 1, JcurrFigure + 2))
            {
                DeterminePath(IccurFigure -1, JcurrFigure +2);
            }
            if (InsideBorder(IccurFigure + 1, JcurrFigure + 2))
            {
                DeterminePath(IccurFigure + 1, JcurrFigure + 2);
            }
            if (InsideBorder(IccurFigure - 1, JcurrFigure - 2))
            {
                DeterminePath(IccurFigure - 1, JcurrFigure - 2);
            }
            if (InsideBorder(IccurFigure + 1, JcurrFigure - 2))
            {
                DeterminePath(IccurFigure + 1, JcurrFigure - 2);
            }
        }
        public void ShowVerticalHorizontal(int IccurFigure, int JcurrFigure, bool isOneStep = false)//если шаг 1 = true)
        {
            //все возможные ходы вниз
            for (int i = IccurFigure + 1; i < 8; i++)
            {
                if (InsideBorder(i, JcurrFigure))
                {
                    if (!DeterminePath(i, JcurrFigure))
                        break;
                }
                if (isOneStep)
                    break;
            }
            //все возможные ходы вверх
            for (int i = IccurFigure - 1; i >= 0; i--)
            {
                if (InsideBorder(i, JcurrFigure))
                {
                   if (!DeterminePath(i, JcurrFigure))
                        break;
                }
                    if (isOneStep)
                        break;
            }
                //все возможные ходы вправо
            for (int j = JcurrFigure + 1; j < 8; j++)
            {
                 if (InsideBorder(IccurFigure, j))
                 {
                   if (!DeterminePath(IccurFigure, j))
                        break;
                 }
                    if (isOneStep)
                        break;
            }
                //все возможные ходы влево
                for (int j = JcurrFigure - 1; j >= 0; j--)
                {
                    if (InsideBorder(IccurFigure, j))
                    {
                        if (!DeterminePath(IccurFigure, j))
                            break;
                    }
                    if (isOneStep)
                        break;
                }
        }
        public bool DeterminePath(int IccurFigure, int j)
        {
            if(map[IccurFigure,j]==0)//проверить ячейка пустая в данных координатах
            {
                butts[IccurFigure, j].BackColor = Color.Yellow;
                butts[IccurFigure, j].Enabled = true;
            }
            else
            {
                if(map[IccurFigure,j]/10!=currPlayer)//если есть - проверить, не наша ли она, если нет - показать ход
                {
                    butts[IccurFigure, j].BackColor = Color.Yellow;
                    butts[IccurFigure, j].Enabled = true;
                }
                return false;//встретили - врага - не показывает ход за врагом
            }
            return true;

        }
        public void MultyPlayer()
        {
            if (currPlayer == 1)
                currPlayer = 2;
            else currPlayer = 1;
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Init();
        }
        public void DeactivateAll()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    butts[i, j].Enabled = false;
                }
            }
        }
        public void ActivateAll()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    butts[i, j].Enabled = true;
                }
            }
        }
        public void CloseSteps()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                  butts[i, j].BackColor = Color.White; 
                }
            }
        }
        public bool InsideBorder(int ti, int tj)//проверка не выходят ли наши фигуры за границы
        {
            if (ti >= 8||tj>=8||ti<0||tj<0)
            {
                return false;
            }
            return true;
        }
        public void ShowDiagonal(int IccurFigure, int JcurrFigure, bool isOneStep=false)
        {
            int j = JcurrFigure + 1;
           for(int i=IccurFigure-1;i>=0;i--)
            {
                if(InsideBorder(i,j))
                {
                    if (!DeterminePath(i, j))
                        break;
                }
                if (j < 7)
                    j++;
                else break;
                if (isOneStep)
                    break;
            }
            j = JcurrFigure - 1;
            for(int i=IccurFigure-1;i>=0;i--)
            {
                if(InsideBorder(i,j))
                {
                    if (!DeterminePath(i, j))
                        break;
                }
                if (j > 0)
                    j--;
                else break;
                if (isOneStep)
                    break;
            }
            j = JcurrFigure - 1;
            for(int i=IccurFigure+1;i<8;i++)
            {
                if(InsideBorder(i,j))
                {
                    if (!DeterminePath(i, j))
                        break;
                }
                if (j < 7)
                    j++;
                else break;
                if (isOneStep)
                    break;
            }
        }
        public void ShowVertivalHorizontal(int IccurFigurem, int JcurrFigure, bool isOneStep = false)
        {
            for(int i=IccurFigurem+1;i<8;i++)
            {
                if(InsideBorder(i,JcurrFigure))
                {
                    if (!DeterminePath(i, JcurrFigure))
                        break;
                }if (isOneStep)
                    break;
            }
            for(int i=IccurFigurem-1;i>0;i--)
            {
                if(InsideBorder(i,JcurrFigure))
                {
                    if (!DeterminePath(i, JcurrFigure))
                        break;
                }if (isOneStep)
                    break;
            }
            for(int j=JcurrFigure+1;j<8;j++)
            {
                if(InsideBorder(IccurFigurem,j))
                {
                    if (!DeterminePath(IccurFigurem, j))
                        break;
                }if (isOneStep) break;
            }
            for(int j=JcurrFigure-1;j>=0;j--)
            {
                if(InsideBorder(IccurFigurem,j))
                {
                    if (!DeterminePath(IccurFigurem, j))
                        break;
                }
                if (isOneStep) break;
            }
        }
    }
}
