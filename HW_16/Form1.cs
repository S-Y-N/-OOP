using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tamagotchii
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 f2 = new Form2();
        Form3 f3 = new Form3();
        Form4 f4 = new Form4();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            f2.ShowDialog();
            this.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            f3.ShowDialog();
            this.Show();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            f4.ShowDialog();
            this.Show();
            Close();
        }
    }
}
