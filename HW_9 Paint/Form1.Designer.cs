
namespace HW_9_Paint_by_Trystan
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.печатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отправитьПоПочтеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pic_color = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.palette = new System.Windows.Forms.PictureBox();
            this.broom = new System.Windows.Forms.Button();
            this.bt_exit = new System.Windows.Forms.Button();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_line = new System.Windows.Forms.Button();
            this.bt_rect = new System.Windows.Forms.Button();
            this.bt_ellipse = new System.Windows.Forms.Button();
            this.bt_eraser = new System.Windows.Forms.Button();
            this.bt_pen = new System.Windows.Forms.Button();
            this.bt_fill = new System.Windows.Forms.Button();
            this.bt_Color = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.palette)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.toolStripSeparator1,
            this.печатьToolStripMenuItem,
            this.отправитьПоПочтеToolStripMenuItem,
            this.toolStripSeparator2,
            this.оПрограммеToolStripMenuItem,
            this.toolStripSeparator3,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(189, 6);
            // 
            // печатьToolStripMenuItem
            // 
            this.печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            this.печатьToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.печатьToolStripMenuItem.Text = "Печать";
            this.печатьToolStripMenuItem.Click += new System.EventHandler(this.печатьToolStripMenuItem_Click);
            // 
            // отправитьПоПочтеToolStripMenuItem
            // 
            this.отправитьПоПочтеToolStripMenuItem.Name = "отправитьПоПочтеToolStripMenuItem";
            this.отправитьПоПочтеToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.отправитьПоПочтеToolStripMenuItem.Text = "Отправить по почте";
            this.отправитьПоПочтеToolStripMenuItem.Click += new System.EventHandler(this.отправитьПоПочтеToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(189, 6);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(189, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 785);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 26);
            this.panel2.TabIndex = 2;
            // 
            // pic_color
            // 
            this.pic_color.BackColor = System.Drawing.Color.White;
            this.pic_color.Location = new System.Drawing.Point(272, 32);
            this.pic_color.Name = "pic_color";
            this.pic_color.Size = new System.Drawing.Size(40, 40);
            this.pic_color.TabIndex = 0;
            this.pic_color.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.palette);
            this.panel1.Controls.Add(this.broom);
            this.panel1.Controls.Add(this.bt_exit);
            this.panel1.Controls.Add(this.bt_save);
            this.panel1.Controls.Add(this.bt_line);
            this.panel1.Controls.Add(this.bt_rect);
            this.panel1.Controls.Add(this.bt_ellipse);
            this.panel1.Controls.Add(this.bt_eraser);
            this.panel1.Controls.Add(this.bt_pen);
            this.panel1.Controls.Add(this.bt_fill);
            this.panel1.Controls.Add(this.bt_Color);
            this.panel1.Controls.Add(this.pic_color);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 104);
            this.panel1.TabIndex = 1;
            // 
            // palette
            // 
            this.palette.Cursor = System.Windows.Forms.Cursors.Hand;
            this.palette.Image = global::HW_9_Paint_by_Trystan.Properties.Resources.palette;
            this.palette.Location = new System.Drawing.Point(12, 12);
            this.palette.Name = "palette";
            this.palette.Size = new System.Drawing.Size(222, 86);
            this.palette.TabIndex = 8;
            this.palette.TabStop = false;
            this.palette.MouseClick += new System.Windows.Forms.MouseEventHandler(this.palette_MouseClick);
            // 
            // broom
            // 
            this.broom.Image = global::HW_9_Paint_by_Trystan.Properties.Resources._24__5_;
            this.broom.Location = new System.Drawing.Point(906, 60);
            this.broom.Name = "broom";
            this.broom.Size = new System.Drawing.Size(32, 32);
            this.broom.TabIndex = 11;
            this.broom.UseVisualStyleBackColor = true;
            this.broom.Click += new System.EventHandler(this.broom_Click);
            // 
            // bt_exit
            // 
            this.bt_exit.Image = global::HW_9_Paint_by_Trystan.Properties.Resources._24__4_;
            this.bt_exit.Location = new System.Drawing.Point(956, 7);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(32, 32);
            this.bt_exit.TabIndex = 10;
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // bt_save
            // 
            this.bt_save.Image = global::HW_9_Paint_by_Trystan.Properties.Resources._32__3_;
            this.bt_save.Location = new System.Drawing.Point(906, 7);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(32, 32);
            this.bt_save.TabIndex = 9;
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_line
            // 
            this.bt_line.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.bt_line.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.bt_line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_line.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_line.ForeColor = System.Drawing.Color.White;
            this.bt_line.Image = global::HW_9_Paint_by_Trystan.Properties.Resources._24__2_;
            this.bt_line.Location = new System.Drawing.Point(794, 18);
            this.bt_line.Name = "bt_line";
            this.bt_line.Size = new System.Drawing.Size(70, 65);
            this.bt_line.TabIndex = 7;
            this.bt_line.Text = "Линия";
            this.bt_line.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_line.UseVisualStyleBackColor = true;
            this.bt_line.Click += new System.EventHandler(this.bt_line_Click);
            // 
            // bt_rect
            // 
            this.bt_rect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.bt_rect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.bt_rect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_rect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_rect.ForeColor = System.Drawing.Color.White;
            this.bt_rect.Image = global::HW_9_Paint_by_Trystan.Properties.Resources._24__1_;
            this.bt_rect.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_rect.Location = new System.Drawing.Point(718, 18);
            this.bt_rect.Name = "bt_rect";
            this.bt_rect.Size = new System.Drawing.Size(70, 65);
            this.bt_rect.TabIndex = 6;
            this.bt_rect.Text = "Прямоугольник";
            this.bt_rect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_rect.UseVisualStyleBackColor = true;
            this.bt_rect.Click += new System.EventHandler(this.bt_rect_Click);
            // 
            // bt_ellipse
            // 
            this.bt_ellipse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.bt_ellipse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.bt_ellipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ellipse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_ellipse.ForeColor = System.Drawing.Color.White;
            this.bt_ellipse.Image = global::HW_9_Paint_by_Trystan.Properties.Resources._24;
            this.bt_ellipse.Location = new System.Drawing.Point(642, 18);
            this.bt_ellipse.Name = "bt_ellipse";
            this.bt_ellipse.Size = new System.Drawing.Size(70, 65);
            this.bt_ellipse.TabIndex = 5;
            this.bt_ellipse.Text = "Эллипс";
            this.bt_ellipse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_ellipse.UseVisualStyleBackColor = true;
            this.bt_ellipse.Click += new System.EventHandler(this.bt_ellipse_Click);
            // 
            // bt_eraser
            // 
            this.bt_eraser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.bt_eraser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.bt_eraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_eraser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_eraser.ForeColor = System.Drawing.Color.White;
            this.bt_eraser.Image = global::HW_9_Paint_by_Trystan.Properties.Resources._32__2_;
            this.bt_eraser.Location = new System.Drawing.Point(566, 18);
            this.bt_eraser.Name = "bt_eraser";
            this.bt_eraser.Size = new System.Drawing.Size(70, 65);
            this.bt_eraser.TabIndex = 4;
            this.bt_eraser.Text = "Ластик";
            this.bt_eraser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_eraser.UseVisualStyleBackColor = true;
            this.bt_eraser.Click += new System.EventHandler(this.bt_eraser_Click);
            // 
            // bt_pen
            // 
            this.bt_pen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.bt_pen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.bt_pen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_pen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_pen.ForeColor = System.Drawing.Color.White;
            this.bt_pen.Image = global::HW_9_Paint_by_Trystan.Properties.Resources.Hopstarter_Soft_Scraps_Pen_Green;
            this.bt_pen.Location = new System.Drawing.Point(490, 18);
            this.bt_pen.Name = "bt_pen";
            this.bt_pen.Size = new System.Drawing.Size(70, 65);
            this.bt_pen.TabIndex = 3;
            this.bt_pen.Text = "Карандаш";
            this.bt_pen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_pen.UseVisualStyleBackColor = true;
            this.bt_pen.Click += new System.EventHandler(this.bt_pen_Click);
            // 
            // bt_fill
            // 
            this.bt_fill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.bt_fill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.bt_fill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_fill.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_fill.ForeColor = System.Drawing.Color.White;
            this.bt_fill.Image = global::HW_9_Paint_by_Trystan.Properties.Resources._32;
            this.bt_fill.Location = new System.Drawing.Point(419, 18);
            this.bt_fill.Name = "bt_fill";
            this.bt_fill.Size = new System.Drawing.Size(65, 65);
            this.bt_fill.TabIndex = 2;
            this.bt_fill.Text = "Заливка";
            this.bt_fill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_fill.UseVisualStyleBackColor = true;
            this.bt_fill.Click += new System.EventHandler(this.bt_fill_Click);
            // 
            // bt_Color
            // 
            this.bt_Color.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.bt_Color.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.bt_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Color.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_Color.ForeColor = System.Drawing.Color.White;
            this.bt_Color.Image = global::HW_9_Paint_by_Trystan.Properties.Resources._32__1_;
            this.bt_Color.Location = new System.Drawing.Point(348, 18);
            this.bt_Color.Name = "bt_Color";
            this.bt_Color.Size = new System.Drawing.Size(65, 65);
            this.bt_Color.TabIndex = 1;
            this.bt_Color.Text = "Цвет";
            this.bt_Color.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_Color.UseVisualStyleBackColor = true;
            this.bt_Color.Click += new System.EventHandler(this.bt_Color_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel3.Location = new System.Drawing.Point(328, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(556, 85);
            this.panel3.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1000, 657);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 811);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.palette)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem печатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отправитьПоПочтеToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button pic_color;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_line;
        private System.Windows.Forms.Button bt_rect;
        private System.Windows.Forms.Button bt_ellipse;
        private System.Windows.Forms.Button bt_eraser;
        private System.Windows.Forms.Button bt_pen;
        private System.Windows.Forms.Button bt_fill;
        private System.Windows.Forms.Button bt_Color;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox palette;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.Button broom;
    }
}

