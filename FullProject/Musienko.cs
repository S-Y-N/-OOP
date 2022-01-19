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
    public partial class Musienko : Form
    {
        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;
        Pen p = new Pen(Color.Black, 1);
        ColorDialog cd = new ColorDialog();
        int x, y, sY, sX, cX, cY;

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Change Width to 10pt");
            p.Width = 10;
            g.DrawLine(p, px, px);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pictureBox1.Image = bm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            p.Color = cd.Color;
        }

        public Musienko()
        {
            InitializeComponent();
        }

        private void Musienko_Load(object sender, EventArgs e)
        {
            base.Text = "4";
            this.Width = 620;
            this.Height = 400;
            bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pictureBox1.Image = bm;
        }
        private void mouse_down(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;

            cX = e.X;
            cY = e.Y;

        }
        private void mouse_move(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                px = e.Location;
                g.DrawLine(p, px, py);
                py = px;
            }
            pictureBox1.Refresh();

        }
        private void mouse_up(object sender, MouseEventArgs e)
        {
            paint = false;
        }
    }
}
