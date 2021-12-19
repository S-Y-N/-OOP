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
using System.Text.RegularExpressions;

namespace HW_7
{
    
    public partial class Form1 : Form
    {
        Color color;
       
       
        Font currFont = new Font("Timer New Roman", 14.0f);
        public string filename;

        public Form1()
        {
            InitializeComponent();
            color = this.BackColor;
            statusBar1.Visible = false;
           
            textBox1.Font = currFont;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            base.Text = "Notepad by Trystan";

        }
       

        private void новоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "All fies (*)| *.*| Text Files(*.txt)| *.txt";
            open.FilterIndex = 1;
            if(open.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    StreamReader reader = File.OpenText(open.FileName);
                    textBox1.Text = reader.ReadToEnd();
                    reader.Close();
                }
                catch
                {
                    MessageBox.Show("Ошибка открытия файла");
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if(save.ShowDialog()==DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(save.FileName);
                writer.Write(textBox1.Text);
                writer.Close();
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("До скорой встречи!");
            this.Close();
        }
         
        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveAS = new SaveFileDialog();
            saveAS.Filter = "All fies (*)| *.*| Text Files(*.txt)| *.txt| PDF |*.pdf | MS Office|*.doc";
            saveAS.FilterIndex = 1;
            if (saveAS.ShowDialog()==DialogResult.OK)
            {
                StreamWriter writerAS = new StreamWriter(saveAS.FileName);
            }
        }

        private void новоеОкноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void цветФонаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
           if( cd.ShowDialog()== DialogResult.OK)
            {
                textBox1.BackColor = cd.Color;
            }

           
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа сделана в целях обучения C# и WinForms\nСтудент ИТ Академии \"ШАГ\" Тристан\"SYN\" Евгений", "Справка");
        }

        private void времяИДатаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime date = new DateTime();
            date = DateTime.Now;
            textBox1.Text = System.Convert.ToString(date);
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var start = textBox1.SelectionStart;
            Clipboard.SetText(textBox1.Text.Substring(textBox1.SelectionStart, textBox1.SelectionLength));
              
            textBox1.Text = textBox1.Text.Remove(textBox1.SelectionStart, textBox1.SelectionLength);
            textBox1.SelectionStart = start;
          
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Clipboard.SetText(textBox1.SelectedText);
           if(textBox1.Text.Length>0)
            {
                textBox1.Copy();
               
            }
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if(Clipboard.GetDataObject().GetDataPresent(DataFormats.Text)==true)
            {
                textBox1.Paste();
                Clipboard.Clear();
              
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var start = textBox1.SelectionStart;
            textBox1.Text = textBox1.Text.Remove(textBox1.SelectionStart, textBox1.SelectionLength);
            textBox1.SelectionStart = start;
            Clipboard.Clear();
            
        }

        private void выделитьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
                textBox1.SelectAll();
                textBox1.Focus();
        }

        private void отменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(textBox1.CanUndo==true)//если можно отменить операцию 
            {
                textBox1.Undo();//отменить
                textBox1.ClearUndo();//очистить буффер
            }
            
        }

        private void серыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem c = (ToolStripMenuItem)sender;
            if (c.Checked == true)
            {
                textBox1.BackColor = Color.Gray;
            }
           else
            {
                textBox1.BackColor = Color.White;
            }
        }

        private void черныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem c = (ToolStripMenuItem)sender;
            if (c.Checked == true)
            {
                textBox1.BackColor = Color.Black;
                textBox1.ForeColor = Color.White;
            }
            else
            {
                textBox1.BackColor = Color.White;
                textBox1.ForeColor = Color.Black;
            }
        }

        private void белыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem c = (ToolStripMenuItem)sender;
            if (c.Checked == true)
            {
                textBox1.ForeColor = Color.White;
            }
            else
            {
                textBox1.ForeColor = Color.Black;
            }
        }

        private void зеленыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem c = (ToolStripMenuItem)sender;
            if (c.Checked == true)
            {
                textBox1.ForeColor = Color.Green;
            }
            else
            {
                textBox1.ForeColor = Color.Black;
            }
        }

        private void красныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem c = (ToolStripMenuItem)sender;
            if (c.Checked == true)
            {
                textBox1.ForeColor = Color.Red;
            }
            else
            {
                textBox1.ForeColor = Color.Black;
            }
        }

        private void синийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem c = (ToolStripMenuItem)sender;
            if (c.Checked == true)
            {
                textBox1.ForeColor = Color.Blue;
            }
            else
            {
                textBox1.ForeColor = Color.Black;
            }
        }

        private void серыйToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem c = (ToolStripMenuItem)sender;
            if (c.Checked == true)
            {
                textBox1.ForeColor = Color.Gray;
            }
            else
            {
                textBox1.ForeColor = Color.Black;
            }
        }

        private void черныйToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem c = (ToolStripMenuItem)sender;
            if (c.Checked == true)
            {
                textBox1.ForeColor = Color.Black;
            }
            else
            {
                textBox1.ForeColor = Color.Black;
            }
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fs = new FontDialog();
            if(fs.ShowDialog()==DialogResult.OK)
            {
                textBox1.Font = fs.Font;
            }
            
        }

        private void строкаСостоянияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tp = (ToolStripMenuItem)sender;
            
            if(tp.Checked==true)
            {
                statusBar1.Visible = true;
            }
            else
            {
                statusBar1.Visible = false;
            }
        }

        private void statusBar1_PanelClick(object sender, StatusBarPanelClickEventArgs e)
        {
            
        }

        private void timer_tick(object sender, EventArgs e)
        {
            statusBar1.Panels[0].Text = DateTime.Now.ToString("hh:mm tt");
        }

       
        public static float newFontSize(Graphics graphics, Size size, Font font, string str)
        {
            SizeF stringSize = graphics.MeasureString(str, font);
            float wRatio = size.Width / stringSize.Width;
            float hRatio = size.Height / stringSize.Height;
            float ratio = Math.Min(hRatio, wRatio);
            return font.Size * ratio;

        }

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument print = new PrintDocument(); //объект для печати
            print.PrintPage +=  PrintPageHandler;//обработкич события печати

            PrintDialog printDialog = new PrintDialog();//диалог настройки печати
            printDialog.Document = print;//установка объекта печати
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
        void PrintPageHandler(object sender, PrintPageEventArgs e)//обработчик события печати
        {
            string resultPrint = Convert.ToString(textBox1.Text);
            e.Graphics.DrawString(resultPrint, new Font("Arial", 14), Brushes.Black, 0, 0);//печать
        }

        private void найтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.ShowDialog();
            /*
            string search = System.Convert.ToString(textBox1.Text);
            Regex regex = new Regex(search);
            MatchCollection match = regex.Matches(search);
            if(match.Count>0)
            {
                foreach(Match match1 in match)
                    Console.WriteLine(match1.Value);
            }
            else
            {
                Console.WriteLine("Совпадений не найдено");
            }
            */
        }

        private void увеличитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font fontMin = new Font("Times NEw Roman", 24.0f);
            textBox1.Font = fontMin;
        }

        private void уменьшитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font fontMin = new Font("Times NEw Roman", 8.0f);
            textBox1.Font = fontMin;
        }

        private void вЕрнутьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Font = currFont;
        }

        private void Form_close(object sender, FormClosingEventArgs e)
        {

                if (e.CloseReason == CloseReason.UserClosing)
                {
                DialogResult res = MessageBox.Show("Сохранить файл?", "Выход",MessageBoxButtons.YesNo);
                if(res ==DialogResult.Yes)
                    {
                        SaveFileDialog save = new SaveFileDialog();
                         if (save.ShowDialog() == DialogResult.OK)
                         {
                            StreamWriter writer = new StreamWriter(save.FileName);
                             writer.Write(textBox1.Text);
                             writer.Close();
                         }
                   }  
                }
        }
    }
}
