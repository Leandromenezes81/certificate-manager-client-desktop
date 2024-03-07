using System;
using System.IO;

namespace CertificateManager.CertificateManager.Business.Helpers;

public static class Logger
{
    public static void WriteLog(string message)
    {
        string logPath = AppDomain.CurrentDomain.BaseDirectory;

        using StreamWriter writer = new($@"{logPath}\Logs\log.txt", true);
        writer.WriteLine($"{DateTime.Now} : {message}");
    }
}
