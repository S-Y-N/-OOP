using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
using System.Net.Mail;

namespace HW_9_Paint_by_Trystan
{
    public partial class Form1 : Form
    {
        Bitmap bm; //переменная для работы с изображениями
        Graphics g;// переменная для рисования
        bool paint = false; 
        Point px, py; //координаты
        Pen p = new Pen(Color.Black,1);//объект для рисования прямых линий и кривых, (черный, ширина 1 рх)
        Pen eraser = new Pen(Color.White, 10);//ластик
        int index;
        int x, y, sY, sX, cX, cY;//координаты
        ColorDialog cd = new ColorDialog();
        Color new_color;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            base.Text = "Paint_by_Trystan";
            this.Width = 1024;
            this.Height = 800;
            bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pictureBox1.Image = bm;
        }

       
        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)//сохранение
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "All files(*)|*.*|Image Files(*.jpg)|*.jpg|*.png|*.jpeg";
            open.FilterIndex = 1;
            if(open.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = new Bitmap(open.FileName);
                }
                catch
                {
                    MessageBox.Show("Ошибка открытия файла", "Ошибка");
                }
            }
        }
        
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = @"PNG|*.png|JPG|*jpg" })
            {
                try
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        pictureBox1.Image.Save(saveFileDialog.FileName);
                        MessageBox.Show("Изображение сохранено", "Сохранить");
                    }
                }
                catch
                {
                    MessageBox.Show("Ошибка сохранения", "Ошибка");
                }
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа сделана в целях обучения C# и WinForms\nСтудент ИТ Академии \"ШАГ\" Тристан\"SYN\" Евгений", "Справка");
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument print = new PrintDocument();
            print.PrintPage += PrintPageHandler;

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = print;
            try
            {
                if (printDialog.ShowDialog() == DialogResult.OK)//если ОК - то запуск печати
                {
                    printDialog.Document.Print();//печатаем документ
                }
            }
            catch
            {
                MessageBox.Show("Ошибка печати", "Принтер");//нет - ошибка
            }
        }
        void PrintPageHandler(object sender, PrintPageEventArgs e)//результаты процесса печати
        {
            string resultPrint = Convert.ToString(pictureBox1.Image);
            e.Graphics.DrawString(resultPrint, new Font("Arial", 14), Brushes.Black, 0, 0);//печать
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveAs = new SaveFileDialog() { Filter = @"PNG|*.png|JPEG|*.jpg|*.jpeg|*.jpe|*.jfif|GIF|*.gif|*.gif"})
            {
                try
                {
                    if (saveAs.ShowDialog() == DialogResult.OK)
                    {
                        pictureBox1.Image.Save(saveAs.FileName);
                    }
                }
                catch
                {
                    MessageBox.Show("Неправильный формат сохраниния", "Ошибка");
                }
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)//ф-ция при нажимании мышки
        {
            paint = true; //рисуем при нажимании
            py = e.Location;// передаем координате полученные координаты мышки

            cX = e.X; //таже шляпа
            cY = e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(paint)//движение мауса ( если нет)
            {
                if(index==1)
                {
                    px = e.Location;
                    g.DrawLine(p, px, py);//рисуем линию, карандашом по таких-то координатах
                    py = px;
                }
                if (index == 2)//ластик ( по сути тот же карандаш только белый)
                {
                    px = e.Location;
                    g.DrawLine(eraser, px, py);
                    py = px;
                }/*
                if(index==3)
                {
                    g.DrawEllipse(p, cX, cY, sX, sY); //3D ellipse lmao
                }*/
            }
            pictureBox1.Refresh();//обновить

            x = e.X;
            y = e.Y;
            sX = e.X - cX;//стартовые коодинаты= полученные от текущих
            sY = e.Y - cY;
        }

        private void bt_ellipse_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void bt_rect_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        private void bt_line_Click(object sender, EventArgs e)
        {
            index = 5;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {//Метод рисования фигуры с выбраным индексом и одновременно изображение его
            //во время рисования в текущей позиции, если bool paint =true;
            Graphics g = e.Graphics; 

            if(paint)
            {
                if (index == 3)
                {
                    g.DrawEllipse(p, cX, cY, sX, sY);
                }
                if (index == 4)
                {
                    g.DrawRectangle(p, cX, cY, sX, sY);
                }
                if (index == 5)
                {
                    g.DrawLine(p, cX, cY, x, y);
                }
            }


        }

        private void broom_Click(object sender, EventArgs e)//очистка экрана
        {
            g.Clear(Color.White);
            pictureBox1.Image = bm;
            index = 0;
        }

        private void bt_Color_Click(object sender, EventArgs e)//выбор цвета мышкой
        {
            cd.ShowDialog();//вызываем меню
            new_color = cd.Color; //присвоить цвет 
            pic_color.BackColor = cd.Color;//присвоить выбраный цвет пробнику
            p.Color = cd.Color;//присвоить цвет карандашу
        }
        static Point set_point(PictureBox pb, Point pt)
        {//метод уставнавливает и возвращает точку изображения цвет палитры
            float pX = 1f * pb.Width / pb.Width;
            float pY = 1f * pb.Height / pb.Height;
            return new Point((int)(pt.X * pX), (int)(pt.Y * pY));//получаем точные координаты точки
        }

        private void palette_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = set_point(palette, e.Location);//точка = получает точные координаты при нажатии
            pic_color.BackColor = ((Bitmap)palette.Image).GetPixel(point.X, point.Y); //пробник получает цвет = с палетки . getpixel возвращает цвет с указанного пикселя в коодинату
            new_color = pic_color.BackColor;//присвоение
            p.Color = pic_color.BackColor;
        }
        private void validate(Bitmap bm,Stack<Point>sp, int x, int y, Color old_color, Color new_color)//функция валидации координат и цвета
        {
            Color cx = bm.GetPixel(x, y); //задаем цвет
            if (cx == old_color)//присвоили старый цвет 
            {
                sp.Push(new Point(x, y));//запушили коорд
                bm.SetPixel(x, y, new_color);//задаем цвет пикселю по такиз коордах
            }
        }
        public void Fill(Bitmap bm, int x, int y, Color new_col)//заливка
        {
            Color old_color = bm.GetPixel(x, y); //старый цвет  = получает значения по коордах с изображения
            Stack<Point> pixel = new Stack<Point>();//стекаем
            pixel.Push(new Point(x, y));//пуш пикселя по коордах
            bm.SetPixel(x, y, new_col);//задаем коорд для нового цвета
            if (old_color == new_col) return;//если коорды совпадают = присвоить

            while(pixel.Count>0)//если пикселей больше 0
            {
                Point pt = (Point)pixel.Pop();//точке присваиваем вершину 
                if(pt.X>0&&pt.Y>0&&pt.X<bm.Width-1&&pt.Y<bm.Height-1)
                {
                    validate(bm, pixel, pt.X - 1, pt.Y, old_color, new_color);//идет замыкание координат
                    validate(bm, pixel, pt.X, pt.Y-1, old_color, new_color);
                    validate(bm, pixel, pt.X + 1, pt.Y, old_color, new_color);
                    validate(bm, pixel, pt.X, pt.Y+1, old_color, new_color);
                }
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if(index==7)
            {
                Point point = set_point(pictureBox1, e.Location);
                Fill(bm, point.X, point.Y, new_color);

               
            }
        }

        private void bt_fill_Click(object sender, EventArgs e)
        {
            index = 7;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult res = MessageBox.Show("Сохранить файл?", "Выход", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = @"PNG|*.png|JPG|*jpg" })

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            pictureBox1.Image.Save(saveFileDialog.FileName);
                            MessageBox.Show("Изображение сохранено", "Сохранить");

                        }
                }
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {//в текущем варианте фигуру видно только когда отпускаешь клавишу мышки. 
            //невидно процесс рисования и фактического размера фигуры
            paint = false;

            sX = x - cX;
            sY = y - cY;
            if(index==3)
            {
                g.DrawEllipse(p,cX,cY,sX,sY);
            }
            if (index == 4)
            {
                g.DrawRectangle(p, cX, cY, sX, sY);
            }
            if(index==5)
            {
                g.DrawLine(p, cX, cY,x,y);
            }
        }

        private void bt_pen_Click(object sender, EventArgs e)
        {
            index = 1;

        }

        private void bt_eraser_Click(object sender, EventArgs e) 
        {
            index = 2;
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("До скорой встречи","Выход");
            this.Close();
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = @"PNG|*.png|JPG|*jpg" })
            {
                try
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        pictureBox1.Image.Save(saveFileDialog.FileName);
                    }
                }
                catch{ MessageBox.Show("Ошибка сохранения", "Ошибка");}
            }
        }

        private void отправитьПоПочтеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Send_Email send = new Send_Email();
            send.ShowDialog();
        }
    }
}
