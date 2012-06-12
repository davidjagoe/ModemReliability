using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Threading;

using log4net;

namespace ModemReliabilityTest
{
    static class Program
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));

        [MTAThread]
        static void Main()
        {
            setupLogging();
            log.Info("Starting");
            HttpWebRequest r;

            while (true)
            {
                log.Info("Running download");
                try
                {
                    //string url = "http://ftp.gnu.org/gnu/emacs/windows/libxpm-3.5.8-w32-src.zip"; // 1.4 MB
                    //string url = "http://drillersdashboard.com/images/productivity-circle.png"; // 125 kB
                    string url = "http://ftp.gnu.org/gnu/emacs/windows/libxpm-3.5.8-w32-src.zip.sig"; // 96 bytes
                    r = (HttpWebRequest)WebRequest.Create(url);
                    using (var resp = r.GetResponse())
                    using (var s = resp.GetResponseStream())
                    using (var sr = new StreamReader(s))
                    {
                        sr.ReadToEnd();
                    }
                }
                catch (Exception e)
                {
                    log.Error("Error downloading file: ", e);
                }
                log.Info("Download complete");
                Thread.Sleep(2 * 1000);
            }
        }

        private static void setupLogging()
        {
            string path = Path.GetDirectoryName(
                System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            log4net.Config.XmlConfigurator.Configure(
                new System.IO.FileInfo(
                    Path.Combine(path, "logconfig.xml")));
        }

    }
}