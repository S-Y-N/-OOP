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

namespace FullProject
{
    public partial class Skoblia : Form
    {
        public Skoblia()
        {
            InitializeComponent();
        }

        private void Skoblia_Load(object sender, EventArgs e)
        {

        }
        public override string ToString()
        {
            return "Скобля";
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = File.OpenText(textBox1.Text);
                textBox1.Text = reader.ReadToEnd();
                reader.Close();
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter writer = new StreamWriter(save.FileName);
                    writer.Write(textBox1.Text);
                    writer.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void цвет1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.LightGray;
        }

        private void цвет2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.HotPink;
        }

        private void цвет3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.AliceBlue;
        }

        private void типШрифтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
                textBox1.Font = fd.Font;
        }

        private void размерШрифтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
                textBox1.Font = fd.Font;
        }

        private void цветТекстаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
                textBox1.ForeColor = cd.Color;
        }
    }
    }
