
namespace FullProject
{
    partial class Skoblia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фонРедактораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цвет1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цвет2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цвет3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типШрифтаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размерШрифтаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветТекстаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 32);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(920, 700);
            this.textBox1.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.фонРедактораToolStripMenuItem,
            this.типШрифтаToolStripMenuItem,
            this.размерШрифтаToolStripMenuItem,
            this.цветТекстаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(935, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.закрытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // фонРедактораToolStripMenuItem
            // 
            this.фонРедактораToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.цвет1ToolStripMenuItem,
            this.цвет2ToolStripMenuItem,
            this.цвет3ToolStripMenuItem});
            this.фонРедактораToolStripMenuItem.Name = "фонРедактораToolStripMenuItem";
            this.фонРедактораToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.фонРедактораToolStripMenuItem.Text = "ФонРедактора";
            // 
            // цвет1ToolStripMenuItem
            // 
            this.цвет1ToolStripMenuItem.Name = "цвет1ToolStripMenuItem";
            this.цвет1ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.цвет1ToolStripMenuItem.Text = "Цвет1";
            this.цвет1ToolStripMenuItem.Click += new System.EventHandler(this.цвет1ToolStripMenuItem_Click);
            // 
            // цвет2ToolStripMenuItem
            // 
            this.цвет2ToolStripMenuItem.Name = "цвет2ToolStripMenuItem";
            this.цвет2ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.цвет2ToolStripMenuItem.Text = "Цвет2";
            this.цвет2ToolStripMenuItem.Click += new System.EventHandler(this.цвет2ToolStripMenuItem_Click);
            // 
            // цвет3ToolStripMenuItem
            // 
            this.цвет3ToolStripMenuItem.Name = "цвет3ToolStripMenuItem";
            this.цвет3ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.цвет3ToolStripMenuItem.Text = "Цвет3";
            this.цвет3ToolStripMenuItem.Click += new System.EventHandler(this.цвет3ToolStripMenuItem_Click);
            // 
            // типШрифтаToolStripMenuItem
            // 
            this.типШрифтаToolStripMenuItem.Name = "типШрифтаToolStripMenuItem";
            this.типШрифтаToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.типШрифтаToolStripMenuItem.Text = "ТипШрифта";
            this.типШрифтаToolStripMenuItem.Click += new System.EventHandler(this.типШрифтаToolStripMenuItem_Click);
            // 
            // размерШрифтаToolStripMenuItem
            // 
            this.размерШрифтаToolStripMenuItem.Name = "размерШрифтаToolStripMenuItem";
            this.размерШрифтаToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.размерШрифтаToolStripMenuItem.Text = "РазмерШрифта";
            this.размерШрифтаToolStripMenuItem.Click += new System.EventHandler(this.размерШрифтаToolStripMenuItem_Click);
            // 
            // цветТекстаToolStripMenuItem
            // 
            this.цветТекстаToolStripMenuItem.Name = "цветТекстаToolStripMenuItem";
            this.цветТекстаToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.цветТекстаToolStripMenuItem.Text = "ЦветТекста";
            this.цветТекстаToolStripMenuItem.Click += new System.EventHandler(this.цветТекстаToolStripMenuItem_Click);
            // 
            // Skoblia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 730);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Skoblia";
            this.Text = "Skoblia";
            this.Load += new System.EventHandler(this.Skoblia_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фонРедактораToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цвет1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цвет2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цвет3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типШрифтаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размерШрифтаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветТекстаToolStripMenuItem;
    }
}