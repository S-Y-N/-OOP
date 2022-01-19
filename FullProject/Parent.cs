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
            if(textBox1.Text== "Жила")
            {
                Jila jila = new Jila();
                jila.Show();

            }
            if (textBox1.Text == "Мусиенко")
            {
                Musienko musienko = new Musienko();
                musienko.Show();
            }
            if (textBox1.Text == "Скобля")
            {
                Skoblia skoblia = new Skoblia();
                skoblia.Show();
            }
            if (textBox1.Text == "Чернишов")
            {
                Chernishov cher = new Chernishov();
                cher.Show();
            }
            if (textBox1.Text == "Фурсенко")
            {
                Fursenko furs = new Fursenko();
                furs.Show();
            }
            if (textBox1.Text == "Тристан")
            {
                Trystan trystan = new Trystan();
                trystan.Show();
            }
            if (textBox1.Text == "Шелест")
            {
                Shelest shelest = new Shelest();
                shelest.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] list = { "Жила", "Мусиенко", "Скобля", "Чернишов", "Фурсенко", "Тристан", "Шелест" };
            listBox1.Items.AddRange(list);
            
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.SelectedItem.ToString();
        }
    }
}
