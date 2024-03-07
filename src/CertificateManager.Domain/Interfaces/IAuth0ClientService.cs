using System.Threading.Tasks;

namespace CertificateManager.CertificateManager.Domain.Interfaces;

public interface IAuth0ClientService
{
    Task<string> GenerateAccessTokenAsync();
    void LogoutAsync();
}
