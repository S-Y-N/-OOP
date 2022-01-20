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
    public partial class Parent : Form
    {
        public Parent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            if(listBox1.SelectedIndex <0)
            {
                MessageBox.Show("Выбиритие программу для запуска");
                return;
            }
            (listBox1.SelectedItem as Form).ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.FormattingEnabled = false;
            listBox1.Items.Add(new Jila());
            listBox1.Items.Add(new Musienko());
            listBox1.Items.Add(new Skoblia());
            listBox1.Items.Add(new Chernishov());
            listBox1.Items.Add(new Fursenko());
            listBox1.Items.Add(new Trystan());
            listBox1.Items.Add(new Shelest());

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.SelectedItem.ToString();
        }
    }
}
