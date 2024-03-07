using System.Net.Http;
using System.Threading.Tasks;

namespace CertificateManager.CertificateManager.Domain.Interfaces;

public interface IHttpClientService
{
    Task<HttpResponseMessage> GetAsync(string path);
    void SetAuthorization(string acessToken);
}
