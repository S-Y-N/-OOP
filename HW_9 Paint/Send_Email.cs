using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.IO;

namespace HW_9_Paint_by_Trystan
{
    public partial class Send_Email : Form
    {
        public Send_Email()
        {
            InitializeComponent();
            txtSmptServer.Text = "smtp.gmail.com";
            txtPortNo.Text = "587";
            cbxSSL.Checked = true;
         }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient clientDetails = new SmtpClient();
                clientDetails.Port = Convert.ToInt32(txtPortNo.Text.Trim());
                clientDetails.Host = txtSmptServer.Text.Trim();
                clientDetails.EnableSsl = cbxSSL.Checked;
                clientDetails.DeliveryMethod = SmtpDeliveryMethod.Network;
                clientDetails.UseDefaultCredentials = false;
                clientDetails.Credentials = new NetworkCredential(txtSender.Text.Trim(), txtPassword.Text.Trim());

                MailMessage mailDetails = new MailMessage();
                mailDetails.From = new MailAddress(txtSender.Text.Trim());
                mailDetails.To.Add(txtRecipient.Text.Trim());
                mailDetails.Subject = txtSubject.Text.Trim();
                mailDetails.IsBodyHtml = cbxSSL.Checked;
                mailDetails.Body = txtBody.Text.Trim();
                foreach(string filename in openFileDialog1.FileNames)
                {
                    if(File.Exists(filename))
                    {
                        string fname = Path.GetFileName(filename);
                        mailDetails.Attachments.Add(new Attachment(filename));
                    }
                }
                clientDetails.Send(mailDetails);

                MessageBox.Show("Email Sent");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            button1.Text = "Show";
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.ShowDialog();
            foreach(string filename in openFileDialog1.FileNames)
            {
                MessageBox.Show(filename);
                label8.Text = filename.ToString();
            }
        }
    }
}
