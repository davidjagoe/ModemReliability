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
            (new Form1()).Show();
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