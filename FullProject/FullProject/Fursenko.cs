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
    public partial class Fursenko : Form
    {
        int a1, a2;
        Random rnd = new Random();
        public Fursenko()
        {
            InitializeComponent();
        }
        public override string ToString()
        {
            return "Фурсенко";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string s = textBox1.Text.ToString();
            int.TryParse(s, out a1);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string s = textBox2.Text.ToString();
            int.TryParse(s, out a2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
                listBox1.Items.Add(textBox4.Text);
            if (textBox4.Text == "")
                MessageBox.Show("Введи текст");

            textBox4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                int value = rnd.Next(0, listBox1.Items.Count);
                textBox5.Text = listBox1.Items[value].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Enabled == true)
            {
                if (a2 > a1)
                {
                    int value = rnd.Next(a1, a2) + 1;
                    textBox3.Text = value.ToString();
                }
                if (a1 > a2)
                    MessageBox.Show("Первое число не может быть больше второго");
            }
        }
    }
}
