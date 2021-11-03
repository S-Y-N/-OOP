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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            pictureBox1.Image = TamagotchiList.Images[1];
        }
        private void button5_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\duost\source\repos\Tamagotchii\Tamagotchii\Englishman.wav");
            simpleSound.Play();
            simpleSound.Stop();

        }

        private void button1_Click(object sender, EventArgs e)//Feed
        {
            
            if (progressBar1.Value>progressBar1.Minimum+100)
            progressBar1.Value -= 100;
            pictureBox1.Image = TamagotchiList.Images[0];
        }

        private void button2_Click(object sender, EventArgs e)//Play
        {
            pictureBox1.Image = TamagotchiList.Images[1];
            if (progressBar3.Value < progressBar3.Maximum - 100)
                progressBar3.Value += 100;

        }

        private void button3_Click(object sender, EventArgs e)//Sleep
        {
            pictureBox1.Image = TamagotchiList.Images[2];
            if (progressBar2.Value > progressBar2.Minimum + 100)
                progressBar2.Value -= 100;
        }

        private void button4_Click(object sender, EventArgs e)//Wake up
        {
            pictureBox1.Image = TamagotchiList.Images[3];
            if (progressBar2.Value < progressBar2.Maximum - 100)
                progressBar2.Value += 100;
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            progressBar1.Value++;
            if (progressBar2.Value < progressBar2.Maximum - 100)
            { progressBar2.Value++; }
            progressBar3.Value--;

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(Tamagotchii.Properties.Resources.Englishman);
            simpleSound.Play();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(Tamagotchii.Properties.Resources.Englishman);
            simpleSound.Stop();
        }

       

       
    }
}
