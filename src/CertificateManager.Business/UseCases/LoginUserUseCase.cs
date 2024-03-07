using CertificateManager.CertificateManager.Domain.Interfaces;
using CertificateManager.CertificateManager.Infrastructure.Services;
using Serilog;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CertificateManager.CertificateManager.Business.UseCases;

public class LoginUserUseCase
{
    private readonly IAuth0ClientService _auth0ClientService;

    public LoginUserUseCase()
    {
        _auth0ClientService = new Auth0ClientService();
    }

    public async Task<bool> GetAuthZeroAccess()
    {
        try
        {
            await _auth0ClientService.GenerateAccessTokenAsync();
            return true;
        }
        catch (Exception ex)
        {
            Log.Error($"Error ocurred to get token: {ex.Message}");
            MessageBox.Show("Falha ao fazer login.",
                "Erro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
        return false;
    }
}
