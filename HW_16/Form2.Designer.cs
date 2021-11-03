
namespace Tamagotchii
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.TamagotchiList = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TamagotchiList
            // 
            this.TamagotchiList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("TamagotchiList.ImageStream")));
            this.TamagotchiList.TransparentColor = System.Drawing.Color.Transparent;
            this.TamagotchiList.Images.SetKeyName(0, "1.jpg");
            this.TamagotchiList.Images.SetKeyName(1, "2.jpg");
            this.TamagotchiList.Images.SetKeyName(2, "3.jpg");
            this.TamagotchiList.Images.SetKeyName(3, "4.jpg");
            this.TamagotchiList.Images.SetKeyName(4, "angry1.jpg");
            this.TamagotchiList.Images.SetKeyName(5, "angry2.jpg");
            this.TamagotchiList.Images.SetKeyName(6, "angry3.jpg");
            this.TamagotchiList.Images.SetKeyName(7, "angry4.jpg");
            this.TamagotchiList.Images.SetKeyName(8, "pika1.jpg");
            this.TamagotchiList.Images.SetKeyName(9, "pika2.jpg");
            this.TamagotchiList.Images.SetKeyName(10, "pika3.jpg");
            this.TamagotchiList.Images.SetKeyName(11, "pika4.jpg");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(200, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 142);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Prestige Elite Std", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(166, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tamagotchi";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Prestige Elite Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(74, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Feed";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Prestige Elite Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(74, 204);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Play";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Prestige Elite Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(366, 85);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Sleep";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Prestige Elite Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(366, 204);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Wake Up";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(48, 378);
            this.progressBar1.Maximum = 10000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.Step = 100;
            this.progressBar1.TabIndex = 6;
            this.progressBar1.Value = 5000;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(218, 378);
            this.progressBar2.Maximum = 10000;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(100, 23);
            this.progressBar2.Step = 100;
            this.progressBar2.TabIndex = 7;
            this.progressBar2.Value = 5000;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(391, 378);
            this.progressBar3.Maximum = 10000;
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(100, 23);
            this.progressBar3.Step = 100;
            this.progressBar3.TabIndex = 8;
            this.progressBar3.Value = 10000;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Prestige Elite Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Hunger";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Prestige Elite Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(215, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Fatigue";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Prestige Elite Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(393, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Happiness";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.MistyRose;
            this.button5.BackgroundImage = global::Tamagotchii.Properties.Resources.Screenshot_1;
            this.button5.Location = new System.Drawing.Point(12, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(28, 36);
            this.button5.TabIndex = 12;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::Tamagotchii.Properties.Resources.Screenshot_2;
            this.button6.Location = new System.Drawing.Point(10, 46);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(30, 30);
            this.button6.TabIndex = 13;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tamagotchii.Properties.Resources.depositphotos_73405399_stock_photo_chureito_pagoda_with_sakura_beautiful;
            this.ClientSize = new System.Drawing.Size(535, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList TamagotchiList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}