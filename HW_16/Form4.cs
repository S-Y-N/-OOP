using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Tamagotchii
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            pictureBox1.Image = imageList1.Images[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value > progressBar1.Minimum + 100)
                progressBar1.Value -= 100;
            pictureBox1.Image = imageList1.Images[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[1];
            if (progressBar3.Value < progressBar3.Maximum - 100)
                progressBar3.Value += 100;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[2];
            if (progressBar2.Value > progressBar2.Minimum + 100)
                progressBar2.Value -= 100;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[3];
            if (progressBar2.Value < progressBar2.Maximum - 100)
                progressBar2.Value += 100;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(Tamagotchii.Properties.Resources.Tanuki);
            simpleSound.Play();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(Tamagotchii.Properties.Resources.Tanuki);
            simpleSound.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            if (progressBar2.Value < progressBar2.Maximum - 100)
            { progressBar2.Value++; }
            progressBar3.Value--;
        }
    }
}
