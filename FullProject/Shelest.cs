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
    public partial class Shelest : Form
    {
        Size _startSize = new Size(0, 0);
        public Shelest()
        {
            InitializeComponent();
            base.Text = "Shelest";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                _startSize = pictureBox1.Size;
                pictureBox1.Image = new Bitmap(open.FileName);
                this.ClientSize = pictureBox1.Size;
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Size size = new Size(600, 600);
            pictureBox1.Size = size;
            this.ClientSize = size;
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Size size = new Size(300, 300);
            pictureBox1.Size = size;
            this.ClientSize = size;
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Size.Width != 0)
                pictureBox1.Size = _startSize;
            this.ClientSize = pictureBox1.Size;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа создана в целях изучения языка С#\n\nCreate by Syn");

        }
    }
}
