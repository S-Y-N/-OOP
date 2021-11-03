
namespace Tamagotchii
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(173, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "たまごっち";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "pika1.jpg");
            this.imageList1.Images.SetKeyName(1, "pika2.jpg");
            this.imageList1.Images.SetKeyName(2, "pika3.jpg");
            this.imageList1.Images.SetKeyName(3, "pika4.jpg");
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(234, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 145);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Prestige Elite Std", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(136, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "餌";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Prestige Elite Std", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(113, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "演奏する";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Prestige Elite Std", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(397, 124);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(63, 51);
            this.button3.TabIndex = 4;
            this.button3.Text = "寝る";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Prestige Elite Std", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(397, 229);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 40);
            this.button4.TabIndex = 5;
            this.button4.Text = "起きろ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::Tamagotchii.Properties.Resources.Screenshot_1;
            this.button5.Location = new System.Drawing.Point(12, 18);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(30, 30);
            this.button5.TabIndex = 6;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::Tamagotchii.Properties.Resources.Screenshot_2;
            this.button6.Location = new System.Drawing.Point(547, 18);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(30, 30);
            this.button6.TabIndex = 7;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(26, 373);
            this.progressBar1.Maximum = 10000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(113, 29);
            this.progressBar1.Step = 100;
            this.progressBar1.TabIndex = 8;
            this.progressBar1.Value = 4000;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(241, 373);
            this.progressBar2.Maximum = 10000;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(113, 29);
            this.progressBar2.Step = 100;
            this.progressBar2.TabIndex = 9;
            this.progressBar2.Value = 4000;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(461, 373);
            this.progressBar3.Maximum = 10000;
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(116, 29);
            this.progressBar3.Step = 100;
            this.progressBar3.TabIndex = 10;
            this.progressBar3.Value = 10000;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Prestige Elite Std", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(35, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 27);
            this.label2.TabIndex = 11;
            this.label2.Text = "飢え";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Prestige Elite Std", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(249, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 27);
            this.label3.TabIndex = 12;
            this.label3.Text = "疲労";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Prestige Elite Std", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(469, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 27);
            this.label4.TabIndex = 13;
            this.label4.Text = "幸福";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tamagotchii.Properties.Resources.b319425;
            this.ClientSize = new System.Drawing.Size(598, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}