
namespace FullProject
{
    partial class Chernishov
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
            this.btnAutumn = new System.Windows.Forms.Button();
            this.btnSummer = new System.Windows.Forms.Button();
            this.btnSpring = new System.Windows.Forms.Button();
            this.btnWinter = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAutumn
            // 
            this.btnAutumn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAutumn.Location = new System.Drawing.Point(521, 344);
            this.btnAutumn.Margin = new System.Windows.Forms.Padding(4);
            this.btnAutumn.Name = "btnAutumn";
            this.btnAutumn.Size = new System.Drawing.Size(143, 48);
            this.btnAutumn.TabIndex = 11;
            this.btnAutumn.Text = "Осень";
            this.btnAutumn.UseVisualStyleBackColor = false;
            this.btnAutumn.Click += new System.EventHandler(this.btnAutumn_Click);
            // 
            // btnSummer
            // 
            this.btnSummer.BackColor = System.Drawing.Color.Yellow;
            this.btnSummer.Location = new System.Drawing.Point(358, 344);
            this.btnSummer.Margin = new System.Windows.Forms.Padding(4);
            this.btnSummer.Name = "btnSummer";
            this.btnSummer.Size = new System.Drawing.Size(143, 48);
            this.btnSummer.TabIndex = 10;
            this.btnSummer.Text = "Лето";
            this.btnSummer.UseVisualStyleBackColor = false;
            this.btnSummer.Click += new System.EventHandler(this.btnSummer_Click);
            // 
            // btnSpring
            // 
            this.btnSpring.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSpring.Location = new System.Drawing.Point(192, 344);
            this.btnSpring.Margin = new System.Windows.Forms.Padding(4);
            this.btnSpring.Name = "btnSpring";
            this.btnSpring.Size = new System.Drawing.Size(143, 48);
            this.btnSpring.TabIndex = 9;
            this.btnSpring.Text = "Весна";
            this.btnSpring.UseVisualStyleBackColor = false;
            this.btnSpring.Click += new System.EventHandler(this.btnSpring_Click);
            // 
            // btnWinter
            // 
            this.btnWinter.BackColor = System.Drawing.Color.White;
            this.btnWinter.Location = new System.Drawing.Point(25, 344);
            this.btnWinter.Margin = new System.Windows.Forms.Padding(4);
            this.btnWinter.Name = "btnWinter";
            this.btnWinter.Size = new System.Drawing.Size(143, 48);
            this.btnWinter.TabIndex = 8;
            this.btnWinter.Text = "Зима";
            this.btnWinter.UseVisualStyleBackColor = false;
            this.btnWinter.Click += new System.EventHandler(this.btnWinter_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(358, 23);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(304, 244);
            this.listBox1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(25, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(309, 242);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Chernishov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 420);
            this.Controls.Add(this.btnAutumn);
            this.Controls.Add(this.btnSummer);
            this.Controls.Add(this.btnSpring);
            this.Controls.Add(this.btnWinter);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Chernishov";
            this.Text = "Chernishov";
            this.Load += new System.EventHandler(this.Chernishov_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAutumn;
        private System.Windows.Forms.Button btnSummer;
        private System.Windows.Forms.Button btnSpring;
        private System.Windows.Forms.Button btnWinter;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}