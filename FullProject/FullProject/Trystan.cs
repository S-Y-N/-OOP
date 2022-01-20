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
using System.Net;
using System.Net.Mail;

namespace FullProject
{
    public partial class Trystan : Form
    {
        public Trystan()
        {
            InitializeComponent();
            base.Text = "Texter by Syn";
            this.Width = 800;
            this.Height = 600;
            StartPosition = FormStartPosition.CenterScreen;
            Font font = new Font("Arial", 14);
            textBox1.Font = font;
        }
        public override string ToString()
        {
            return "Тристан";
        }
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "All files (*)| *.*|Text Files(*.txt)|*.txt";
            open.FilterIndex = 1;
            if (open.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader reader = File.OpenText(open.FileName);
                    textBox1.Text = reader.ReadToEnd();
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void новоеОкноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trystan f1 = new Trystan();
            f1.Show();
            Hide();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(save.FileName);
                writer.Write(textBox1.Text);
                writer.Close();
            }
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveAs = new SaveFileDialog();
            saveAs.Filter = "All files(*) |*.*| Text Files(*.txt)|*.txt| PDF (*.pdf)|*.pdf|MS Office (*.doc)|*doc";
            saveAs.FilterIndex = 1;
            if (saveAs.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writerAS = new StreamWriter(saveAs.FileName);
                writerAS.Write(textBox1.Text);
                writerAS.Close();
            }
        }

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument print = new PrintDocument();
            print.PrintPage += PrintPageHandler;

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = print;
            try
            {
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDialog.Document.Print();
                }
            }
            catch
            {
                MessageBox.Show("Ошибка печати", "Принтер");
            }

        }
        void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            string resultPrint = Convert.ToString(textBox1.Text);
            e.Graphics.DrawString(resultPrint, new Font("Arial", 14), Brushes.Black, 0, 0);
        }

        private void отменаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.CanUndo == true)
            {
                textBox1.Undo();
                textBox1.ClearUndo();
            }
        }

        private void выToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var start = textBox1.SelectionStart;
            Clipboard.SetText(textBox1.Text.Substring(textBox1.SelectionStart, textBox1.SelectionLength));
            textBox1.Text = textBox1.Text.Remove(textBox1.SelectionStart, textBox1.SelectionLength);
            textBox1.SelectionStart = start;
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
                textBox1.Copy();
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                textBox1.Paste();
                Clipboard.Clear();
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void выделитьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
            textBox1.Focus();
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
                textBox1.Font = fd.Font;
        }

        private void цветШрифтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
                textBox1.ForeColor = cd.Color;
        }

        private void цветФонаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
                textBox1.BackColor = cd.Color;
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа разработа в учебный целях\n при изучении технологии WFA C#\n\nCreate by Syn. 2022");

        }

        private void Trystan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult res = MessageBox.Show("Сохранить файл?", "Выход", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
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
