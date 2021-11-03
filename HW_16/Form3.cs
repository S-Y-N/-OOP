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
    public partial class Form3 : Form
    {
        public Form3()//russian
        {
            InitializeComponent();
            pictureBox1.Image = RussiaList1.Images[1];
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//feed
        {
            if (progressBar1.Value > progressBar1.Minimum + 100)
                progressBar1.Value -= 100;
            pictureBox1.Image = RussiaList1.Images[0];
        }

        private void button2_Click(object sender, EventArgs e)//play
        {
            pictureBox1.Image = RussiaList1.Images[1];
            if (progressBar3.Value < progressBar3.Maximum - 100)
                progressBar3.Value += 100;
        }

        private void button3_Click(object sender, EventArgs e)//sleep
        {
            pictureBox1.Image = RussiaList1.Images[2];
            if (progressBar2.Value > progressBar2.Minimum + 100)
                progressBar2.Value -= 100;
        }

        private void button4_Click(object sender, EventArgs e)//wake up
        {
            pictureBox1.Image = RussiaList1.Images[3];
            if (progressBar2.Value < progressBar2.Maximum - 100)
                progressBar2.Value += 100;
        }

        private void button5_Click(object sender, EventArgs e)//sound on
        {
            SoundPlayer simpleSound = new SoundPlayer(Tamagotchii.Properties.Resources.vstavaj__strana_ogromnaja___vstavaj__strana_ogromnaja__z2_fm_);
            simpleSound.Play();
        }

        private void button6_Click(object sender, EventArgs e)//sound off
        {
            SoundPlayer simpleSound = new SoundPlayer(Tamagotchii.Properties.Resources.vstavaj__strana_ogromnaja___vstavaj__strana_ogromnaja__z2_fm_);
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
