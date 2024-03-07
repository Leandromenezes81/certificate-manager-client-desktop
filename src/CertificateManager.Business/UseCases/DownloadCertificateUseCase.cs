using CertificateManager.CertificateManager.Business.DTOs;
using CertificateManager.CertificateManager.Business.Helpers;
using CertificateManager.CertificateManager.Domain.Interfaces;
using CertificateManager.CertificateManager.Infrastructure.Repositories;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CertificateManager.CertificateManager.Business.UseCases;

public class DownloadCertificateUseCase
{
    private readonly ICertificateManagerApiRepository _certificateManagerApiRepository;

    public DownloadCertificateUseCase()
    {
        _certificateManagerApiRepository = new CertificateManagerApiRepository();
    }

    public async Task<bool> DownloadCertificate(string federalTaxNumber, string companyName)
    {
        HttpResponseResultDTO<byte[]?> httpResponseResult = await _certificateManagerApiRepository
            .DownloadCertificateBytes(
            federalTaxNumber);

        if (httpResponseResult.Data != Array.Empty<byte>())
        {
            byte[] zipFileBytes = DecryptHelper.DecryptValue(httpResponseResult.Data
                ?? Array.Empty<byte>());

            string userDownloadsFolder = $"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\\Downloads";
            string zipFileName = $"{companyName}_{federalTaxNumber}.zip";
            string zipFilePath = Path.Combine(userDownloadsFolder, zipFileName);

            File.WriteAllBytes(zipFilePath, zipFileBytes);
            MessageBox.Show($"O arquivo {zipFileName} foi salvo em: {userDownloadsFolder}.",
                       "Successo!",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
            return true;
        }
        else
        {
            if (!string.IsNullOrEmpty(httpResponseResult.Message))
            {
                MessageBoxHelper.ShowErrorMessageBox(httpResponseResult.Message);
            }
            else
            {
                var path = "/public/certificate/v1/download";
                var errorMessage = MessageBoxHelper.CreateGenericErrorMessage(path, federalTaxNumber);
                MessageBoxHelper.ShowErrorMessageBox(errorMessage);
            }
        }

        return false;
    }
}
