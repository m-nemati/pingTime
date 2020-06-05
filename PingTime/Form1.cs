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
            PingTimeRun("8.8.8.8");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PingTimeRun("4.2.2.4");
        }

        private void btnPing1_Click(object sender, EventArgs e)
        {
            PingTimeRun("1.1.1.1");
        }

        private void btnPingFav_Click(object sender, EventArgs e)
        {
            PingTimeRun(txtInputIP.Text);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            lblResult.Items.Clear();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtInputIP.Text = "";
        }

        public void PingTimeRun(string ipAddr)
        {
            try
            {
                Ping ping = new Ping();
                PingReply r;
                string s = ipAddr;
               
                r = ping.Send(s);

                if (r.Status == IPStatus.Success)
                {
                    lblResult.Items.Add("Ping " + ipAddr + " >> Successful >>"
                       + " Response delay = " + r.RoundtripTime.ToString() + " ms" + "\n");
                }
            }
            catch
            {
                MessageBox.Show("مشکلی رخ داده است. مجدد تلاش کنید.");
            }
        }

        
    }
}
