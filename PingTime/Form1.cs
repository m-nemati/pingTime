using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;

namespace PingTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPing8_Click(object sender, EventArgs e)
        {
           try
            {
                Ping ping_8 = new Ping();
                PingReply r_8;
                string s_8;
                s_8 = "8.8.8.8";
                r_8 = ping_8.Send(s_8);
                //if (r_8.Status == IPStatus.Success)
                //{
                //    txtResults.Text = "Ping to "  + "[" + r_8.Address.ToString() + "]" + " Successful >>"
                //       + " Response delay = " + r_8.RoundtripTime.ToString() + " ms" + "\n";
                //}

                if (r_8.Status == IPStatus.Success)
                {
                    lblResult.Items.Add("Ping 8.8.8.8 >> Successful >>"
                       + " Response delay = " + r_8.RoundtripTime.ToString() + " ms" + "\n");
                }
            }
            catch
            {
                MessageBox.Show("مشکلی رخ داده است. مجدد تلاش کنید.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           try
            {
                Ping ping_4 = new Ping();
                PingReply r_4;
                string s_4;
                s_4 = "4.2.2.4";
                r_4 = ping_4.Send(s_4);

                if (r_4.Status == IPStatus.Success)
                {
                    lblResult.Items.Add("Ping 4.2.2.4 >> Successful >>"
                       + " Response delay = " + r_4.RoundtripTime.ToString() + " ms" + "\n");
                }
            }
            catch
            {
                MessageBox.Show("مشکلی رخ داده است. مجدد تلاش کنید.");
            }
        }

        private void btnPing1_Click(object sender, EventArgs e)
        {
            try
            {
                Ping ping_1 = new Ping();
                PingReply r_1;
                string s_1;
                s_1 = "1.1.1.1";
                r_1 = ping_1.Send(s_1);

                if (r_1.Status == IPStatus.Success)
                {
                    lblResult.Items.Add("Ping 1.1.1.1 >> Successful >>"
                       + " Response delay = " + r_1.RoundtripTime.ToString() + " ms" + "\n");
                }
            }
            catch
            {
                MessageBox.Show("مشکلی رخ داده است. مجدد تلاش کنید.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblResult.Items.Clear();
        }
    }
}
