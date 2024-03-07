using CertificateManager.CertificateManager.Domain.Interfaces;
using System;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace CertificateManager.CertificateManager.Infrastructure.Services;

public class HttpClientService : IHttpClientService
{
    private readonly HttpClient _httpClient;
    private readonly string? _apiUrl;

    public HttpClientService()
    {
        _apiUrl = ConfigurationManager.AppSettings["UrlApi:CertificateManager"] ?? "";
        _httpClient = new HttpClient
        {
            BaseAddress = new Uri(_apiUrl)
        };
    }

    public async Task<HttpResponseMessage> GetAsync(string path)
    {
        return await _httpClient.GetAsync(path);
    }

    public void SetAuthorization(string acessToken)
    {
        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
            "Bearer",
            acessToken);
    }
}
