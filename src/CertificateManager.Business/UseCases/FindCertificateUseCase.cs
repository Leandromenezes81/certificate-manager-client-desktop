using CertificateManager.CertificateManager.Business.DTOs;
using CertificateManager.CertificateManager.Business.Helpers;
using CertificateManager.CertificateManager.Domain.Entities;
using CertificateManager.CertificateManager.Domain.Interfaces;
using CertificateManager.CertificateManager.Infrastructure.Repositories;
using System;
using System.Threading.Tasks;

namespace CertificateManager.CertificateManager.Business.UseCases;

public class FindCertificateUseCase
{
    private readonly ICertificateManagerApiRepository _certificateManagerApiRepository;

    public FindCertificateUseCase()
    {
        _certificateManagerApiRepository = new CertificateManagerApiRepository();
    }

    public async Task<DigitalCertificate> FindDigitalCerticate(string federalTaxNumber)
    {
        HttpResponseResultDTO<DigitalCertificate?> httpResponseResult = await _certificateManagerApiRepository
            .FindCertificate(federalTaxNumber);
        DigitalCertificate digitalCertificate = new();

        if (!string.IsNullOrEmpty(httpResponseResult.Data?.FederalTaxNumber))
        {
            digitalCertificate = httpResponseResult.Data;
        }
        else
        {
            if (!string.IsNullOrEmpty(httpResponseResult.Message))
            {
                MessageBoxHelper.ShowErrorMessageBox(httpResponseResult.Message);
            }
            else
            {
                var path = "/public/certificate/v1/info";
                var errorMessage = MessageBoxHelper.CreateGenericErrorMessage(path, federalTaxNumber);
                MessageBoxHelper.ShowErrorMessageBox(errorMessage);
            }
        }

        return digitalCertificate;
    }
}
