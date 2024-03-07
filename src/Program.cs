using CertificateManager.CertificateManager.Business.Helpers;
using CertificateManager.UI.Forms;
using Serilog;
using System;
using System.Windows.Forms;

namespace CertificateManager.UI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            string logPath = AppDomain.CurrentDomain.BaseDirectory;
            Log.Logger = new LoggerConfiguration()
                .WriteTo.File($@"{logPath}\Logs\log.txt")
                .CreateLogger();

            ApplicationConfiguration.Initialize();

            if (AccessTokenHelper.IsValidToken())
            {
                Application.Run(new SearchCertificate());
            }
            else
            {
                Application.Run(new Login());
            }
        }
    }
}
