using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FullProject
{
    public partial class Jila : Form
    {
        int p1, p2;
        public Jila()
        {
            InitializeComponent();
        }
        public override string ToString()
        {
            return "Жила";
        }
        private void Jila_Load(object sender, EventArgs e)
        {
            string[] figure = { "Квадрат", "Круг", "Ромб", "Треугольник" };
            listBox1.Items.AddRange(figure);
            textBox5.Visible = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox5.Text = listBox1.SelectedItem.ToString();
            if (textBox5.Text == "Квадрат")
                pictureBox1.Image = Properties.Resources.square;
            if (textBox5.Text == "Круг")
                pictureBox1.Image = Properties.Resources.circle;
            if (textBox5.Text == "Ромб")
                pictureBox1.Image = Properties.Resources.romb;
            if (textBox5.Text == "Треугольник")
                pictureBox1.Image = Properties.Resources.triang;
        }

        private void param1_TextChanged(object sender, EventArgs e)
        {
            string pa1 = param1.Text.ToString();
            int.TryParse(pa1, out p1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "Квадрат")
            {
                resPlosha.Text = (p1 * p2).ToString();
                resPerimert.Text = (p1 * 4).ToString();
            }
            if (textBox5.Text == "Круг")
                resPlosha.Text = (Math.Round(Math.PI * (p1 * p1), 2)).ToString();
            if (textBox5.Text == "Ромб")
            {
                resPlosha.Text = ((p1 * p2) / 2).ToString();
                resPerimert.Text = (p1 * 4).ToString();
            }
            if (textBox5.Text == "Треугольник")
            {
                resPlosha.Text = (((p1 * p1) * Math.Sqrt(3)) / 4).ToString();
                resPerimert.Text = (p1 * 3).ToString();
            }
        }

        private void param2_TextChanged(object sender, EventArgs e)
        {
            string pa2 = param2.Text.ToString();
            int.TryParse(pa2, out p2);
        }
    }
}
