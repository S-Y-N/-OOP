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
    public partial class Chernishov : Form
    {
        public Chernishov()
        {
            InitializeComponent();
            base.Text = "Denis.10";
        }

        private void btnWinter_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Зима;
            listBox1.Items.Clear();
            listBox1.Items.AddRange(new string[] { "Happy New Year", "Marry Christmas" });

        }

        private void btnSpring_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Весна;
            listBox1.Items.Clear();
            listBox1.Items.AddRange(new string[] { "8 Марта", "День Победы" });
    
        }

        private void btnSummer_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Лето;
            listBox1.Items.Clear();
            listBox1.Items.AddRange(new string[] { "День защиты детей", "День Независимости" });
        }

        private void Chernishov_Load(object sender, EventArgs e)
        {

        }

        private void btnAutumn_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Осень;
            listBox1.Items.Clear();
            listBox1.Items.AddRange(new string[] { "День знаний", "Октябрьская революция" });
        }
    }
}
