using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class AppDaNang : Form
    {
        public AppDaNang()
        {
            InitializeComponent();
        }

        #region Button 1
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("You Are About To Open Junk Folder"
                , "Are You Sure?"
                , MessageBoxButtons.OKCancel
                , MessageBoxIcon.Question);
            if (rs == DialogResult.OK)
            {
                Process.Start("shutdown");
                MessageBox.Show("You Should Delete All Files In This Folder To Boost Your Computer Performance"
                    , "Suggestion"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Information
                    , MessageBoxDefaultButton.Button2
                    , MessageBoxOptions.ServiceNotification);
            }
            else MessageBox.Show("Canceled"
                , "Notification"
                , MessageBoxButtons.OK
                , MessageBoxIcon.Information);
        }

        #endregion

        #region Button 2
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text);
            textBox1.Text = string.Empty;
        }

        #endregion

        #region Button 3
        private void button3_Click(object sender, EventArgs e)
        {

            Random rd = new Random();

            button3.Location = new Point(rd.Next(1, ClientSize.Width), rd.Next(1, ClientSize.Height));
           // button3.Size = new Size(rd.Next(1, 1000), rd.Next(1, 100));

        }

        #endregion

        #region Button 4
        private void button4_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i = 0; i <= random.Next(1, 1000); i++)
                try
                {
                    Process.Start(Application.StartupPath + "\\WindowsFormsApp1.exe");
                }
                catch (Exception ms)
                {
                    MessageBox.Show (ms.Message);
                }
        }
        #endregion

        #region Button 5
        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Are You Sure ?"
                              , "Your Computer Will Be Lagged"
                              , MessageBoxButtons.YesNo
                             , MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {

                Process prs = new Process();
                prs.StartInfo.FileName = "WindowsFormsApp1.exe";
                prs.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                for (int i = 0; i < 100000; i++)
                    prs.Start();
                MessageBox.Show("Your Computer is hacked", "Notifcation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Are You Scared?", "Hahaha", MessageBoxButtons.OK);
            }
        }

        #endregion

        #region Button 6
        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Loading...");

            Process.Start("dxdiag");
        }

        #endregion

        #region Button 7
        private void button7_Click(object sender, EventArgs e)
        {

            try
            {
                string chromePath = @"C:\Program Files\Google\Chrome\Application\chrome.exe";
                string url = "https://www.";
                url += textBox2.Text;
                DialogResult rs = MessageBox.Show("Are You Sure To Open " + textBox2.Text, " ", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show("Loading...");
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = chromePath,
                        Arguments = url,
                        UseShellExecute = true
                    });
                }
                textBox2.Text = string.Empty;
            }
            catch
            {
                MessageBox.Show("Chrome Doesn't Exist On Your Computer, Please Install Chorome And Try Again");
            }
        }

        private void button7_MouseMove(object sender, MouseEventArgs e)
        {
            button7.BackColor = Color.Beige;

        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.BackColor = Color.White;
        }
        #endregion

        #region Button 8
        private void button8_Click(object sender, EventArgs e)
        {
            string name = comboBox1.Text;
            try
            {
                Process.Start(name + ".exe");
            }
            catch 
            {
                MessageBox.Show($"Your Computer Doesn't Have {name}"
                    , " "
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Asterisk
                    , MessageBoxDefaultButton.Button2
                    , MessageBoxOptions.DefaultDesktopOnly);

            }
        }
        #endregion

        #region Button 9
        private void button9_Click(object sender, EventArgs e)
        {
           
            try
            {
                int day = int.Parse(textBox3.Text);
                int month = int.Parse(textBox4.Text);
                int year = int.Parse(textBox5.Text);
                DateTime Date = new DateTime(year, month, day);
                MessageBox.Show($"{day}/{month}/{year} is " + Date.DayOfWeek.ToString());
            }
            catch 
            {
                MessageBox.Show("Please enter follow this instruction: day -> month -> year from top down");
            }
            
        }
        #endregion

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Loading...");
            Process.Start("msinfo32");
        }

     
    }
}
