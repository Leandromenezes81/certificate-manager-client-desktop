using CertificateManager.CertificateManager.Business.Helpers;
using CertificateManager.CertificateManager.Domain.Entities;
using Serilog;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace CertificateManager.CertificateManager.Business.UseCases;

public class InstallCertificateUseCase
{
    public static bool InstallCertificate(DigitalCertificate certificate)
    {
        string base64 = DecryptHelper.DecryptValue(certificate.CertificateData ?? string.Empty);
        string password = DecryptHelper.DecryptValue(certificate.Password ?? string.Empty);
        byte[] certificateBytes = Convert.FromBase64String(base64);
        X509Certificate2 x509Certificate2 = new(certificateBytes, password);

        try
        {
            InstallCertificateStore(x509Certificate2);
            MessageBox.Show("Certificado instalado com sucesso!",
                            "Successo!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            return true;
        }
        catch (Exception ex)
        {
            Log.Error($"Error ocurred to install certificate: {ex.Message}");
            MessageBox.Show("Falha na instalação do certificado.",
                            "Erro!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }
        return false;
    }

    private static void InstallCertificateStore(X509Certificate2 certificate)
    {
        X509Store store = new(StoreName.My, StoreLocation.CurrentUser);
        store.Open(OpenFlags.ReadWrite);
        store.Add(certificate);
        store.Close();
    }
}
