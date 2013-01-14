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
        HttpWebResponse m_resp;
        int DataBlockSize = 10;
        byte[] dataBuffer;
        FileStream m_fs;
        static string url1 = "http://drillersdashboard.com/images/productivity-circle.png";
        //static string url2 = "http://174.143.211.239/images/productivity-circle.png";

        //string[] urls = { url1, url2 };

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

        void oldDownload(string u)
        {

            r = (HttpWebRequest)WebRequest.Create(u);
            using (var resp = r.GetResponse())
            using (var s = resp.GetResponseStream())
            using (var sr = new StreamReader(s))
            {
                sr.ReadToEnd();
            }
        }
        
        void doDownload(string u)
        {
            try
            {
                r = (HttpWebRequest)HttpWebRequest.Create(u);
                r.BeginGetResponse(new AsyncCallback(ResponseReceived), null);
            }
            catch (Exception ex)
            {
                log.Error("Failed in doDownload", ex);
                this.Invoke(new EventHandler(this.Failure));
            }
        }

        void ResponseReceived(IAsyncResult res)
        {
            try
            {
                try
                {
                    m_resp = (HttpWebResponse)r.EndGetResponse(res);
                }
                catch (WebException ex)
                {
                    log.Error("error in response received", ex);
                    this.Invoke(new EventHandler(this.Failure));
                    return;
                }
                dataBuffer = new byte[DataBlockSize];
                m_fs = new FileStream(Directory.GetCurrentDirectory() + @"\download.png",
                                        FileMode.Create);
                // Request the first chunk
                m_resp.GetResponseStream().BeginRead(dataBuffer, 0, DataBlockSize,
                  new AsyncCallback(OnDataRead), this);
            }
            catch (Exception ex)
            {
                log.Error("Failure in ResponseReceived", ex);
                this.Invoke(new EventHandler(this.Failure));
            }
        }

        void OnDataRead(IAsyncResult res)
        {
            try
            {
                // How many bytes did we get this time
                int nBytes = m_resp.GetResponseStream().EndRead(res);
                // Write buffer
                m_fs.Write(dataBuffer, 0, nBytes);
                // Are we done yet?
                if (nBytes > 0)
                {
                    // No, keep reading
                    m_resp.GetResponseStream().BeginRead(dataBuffer, 0,
                      DataBlockSize, new AsyncCallback(OnDataRead), this);
                }
                else
                {
                    m_fs.Close();
                    m_fs = null;
                    this.Invoke(new EventHandler(this.AllDone));
                }
            }
            catch (Exception ex)
            {
                log.Error("Failure in OnDataRead", ex);
                this.Invoke(new EventHandler(this.Failure));
            }
        }

        void AllDone(object sender, EventArgs e)
        {
            log.Info("Download complete");
            timer.Enabled = true;
        }

        void Failure(object sender, EventArgs e)
        {
            log.Info("fail");
            this.n_failures.Text = ((int)(int.Parse(this.n_failures.Text) + 1)).ToString();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            timer.Enabled = false;
            this.n_requests.Text = ((int)(int.Parse(this.n_requests.Text) + 1)).ToString();
            doDownload(url1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
            Application.Exit();
        }

        private void dns_total_ParentChanged(object sender, EventArgs e)
        {

        }
    }
}