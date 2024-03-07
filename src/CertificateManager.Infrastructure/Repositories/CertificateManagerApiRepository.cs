using CertificateManager.CertificateManager.Business.DTOs;
using CertificateManager.CertificateManager.Domain.Entities;
using CertificateManager.CertificateManager.Domain.Interfaces;
using CertificateManager.CertificateManager.Infrastructure.Services;
using Serilog;
using System;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace CertificateManager.CertificateManager.Infrastructure.Repositories;

public class CertificateManagerApiRepository : ICertificateManagerApiRepository
{
    private readonly IHttpClientService _httpClient;
    private readonly IAuth0ClientService _auth0Client;

    public CertificateManagerApiRepository()
    {
        _httpClient = new HttpClientService();
        _auth0Client = new Auth0ClientService();
    }

    public async Task<HttpResponseResultDTO<DigitalCertificate?>> FindCertificate(string federalTaxNumber)
    {
        HttpResponseResultDTO<DigitalCertificate?> httpResponseResult = new();
        DigitalCertificate digitalCertificate = new();

        _httpClient.SetAuthorization(
                await _auth0Client.GenerateAccessTokenAsync());

        HttpResponseMessage response = await _httpClient.GetAsync($"certificate/v1/info/{federalTaxNumber}");
        string responseContent = await response.Content.ReadAsStringAsync();

        if (response.StatusCode != HttpStatusCode.OK)
        {
            Log.Error($"{(int)response.StatusCode} - {responseContent}");
            httpResponseResult.Data = digitalCertificate;
            if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                httpResponseResult.Message = responseContent;
            }
        }
        else
        {
            httpResponseResult.Data = JsonSerializer.Deserialize<DigitalCertificate>(responseContent);
        }

        return httpResponseResult;
    }

    public async Task<HttpResponseResultDTO<byte[]?>> DownloadCertificateBytes(string federalTaxNumber)
    {
        HttpResponseResultDTO<byte[]?> httpResponseResult = new();
        byte[]? certificateBytes = Array.Empty<byte>();
        _httpClient.SetAuthorization(
                await _auth0Client.GenerateAccessTokenAsync());

        HttpResponseMessage response = await _httpClient.GetAsync($"certificate/v1/download/{federalTaxNumber}");

        if (response.StatusCode != HttpStatusCode.OK)
        {
            string responseContent = await response.Content.ReadAsStringAsync();
            Log.Error($"{(int)response.StatusCode} - {responseContent}");
            httpResponseResult.Data = certificateBytes;
            if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                httpResponseResult.Message = responseContent;
            }
        }
        else
        {
            certificateBytes = await response.Content.ReadAsByteArrayAsync();
            httpResponseResult.Data = certificateBytes;
        }

        return httpResponseResult;
    }
}
