using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

using System.Net;
using log4net;

namespace ModemReliabilityTest
{
    public partial class Form1 : Form
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Form1));
        System.Windows.Forms.Timer timer;
        HttpWebRequest r;
        static string url1 = "http://drillersdashboard.com/images/productivity-circle.png";
        static string url2 = "http://174.143.211.239/images/productivity-circle.png";

        string[] urls = { url1, url2 };

        public Form1()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            RunTest();
        }

        private void RunTest()
        {
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 10 * 1000;
            timer.Enabled = true;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            timer.Enabled = false;
            foreach (string u in urls)
            {

             try
              {
                r = (HttpWebRequest)WebRequest.Create(u);
                using (var resp = r.GetResponse())
                using (var s = resp.GetResponseStream())
                using (var sr = new StreamReader(s))
                {
                    sr.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
            }
            log.Info("Download complete");
            timer.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            Application.Exit();
        }
    }
}