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


namespace hw16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            base.Text = "HW_16_by_Trystan";
            Font f = new Font("Arial",14);
            textBox1.Font = f;
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "All fies (*)| *.*| Text Files(*.txt)| *.txt";
            open.FilterIndex = 1;
            if (open.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    StreamReader reader = File.OpenText(open.FileName);
                    textBox1.Text = reader.ReadToEnd();
                    reader.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void новоеОкноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();        
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

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveAs = new SaveFileDialog();
            saveAs.Filter = "All fies (*)| *.*| Text Files(*.txt)| *.txt| PDF |*.pdf | MS Office|*.doc";
            saveAs.FilterIndex = 1;
            if(saveAs.ShowDialog()==DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(saveAs.FileName);
                writer.Write(textBox1.Text);
                writer.Close();
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            string result = Convert.ToString(textBox1.Text);
            e.Graphics.DrawString(result, new Font("Arial", 14), Brushes.Black, 0, 0);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void отменаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if((textBox1.CanUndo)==true)
            {
                textBox1.Undo();
                textBox1.ClearUndo();
            }
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

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
                textBox1.Copy();
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
                textBox1.Paste();
            
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HW-16 by Trystan\n2022", "Hw-16");
        }
    }
}
