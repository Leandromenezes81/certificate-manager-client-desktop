using CertificateManager.CertificateManager.Business.DTOs;
using CertificateManager.CertificateManager.Domain.Entities;
using System.Threading.Tasks;

namespace CertificateManager.CertificateManager.Domain.Interfaces;

public interface ICertificateManagerApiRepository
{
    Task<HttpResponseResultDTO<DigitalCertificate?>> FindCertificate(string federalTaxNumber);
    Task<HttpResponseResultDTO<byte[]?>> DownloadCertificateBytes(string federalTaxNumber);
}
