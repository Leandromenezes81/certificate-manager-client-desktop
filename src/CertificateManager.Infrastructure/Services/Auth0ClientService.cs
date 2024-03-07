using Auth0.OidcClient;
using CertificateManager.CertificateManager.Business.Helpers;
using CertificateManager.CertificateManager.Domain.Interfaces;
using Serilog;
using System;
using System.Configuration;
using System.Threading.Tasks;

namespace CertificateManager.CertificateManager.Infrastructure.Services;

public class Auth0ClientService : IAuth0ClientService
{
    private readonly Auth0Client _auth0Client;
    private string _accessToken = string.Empty;

    public Auth0ClientService()
    {
        Auth0ClientOptions auth0ClientOptions = new()
        {
            Domain = ConfigurationManager.AppSettings["Auth0:Domain"],
            ClientId = ConfigurationManager.AppSettings["Auth0:ClientId"],
            RedirectUri = ConfigurationManager.AppSettings["Auth0:RedirectUri"]
        };
        _auth0Client = new Auth0Client(auth0ClientOptions);
        auth0ClientOptions.PostLogoutRedirectUri = auth0ClientOptions.RedirectUri;        
    }

    public async Task<string> GenerateAccessTokenAsync()
    {
        _accessToken = AccessTokenHelper.GetAccessTokenFromRegistry();

        if (!string.IsNullOrEmpty(_accessToken))
        {
            return _accessToken;
        }

        try
        {
            var loginResult = await _auth0Client.LoginAsync();
            if (!loginResult.IsError)
            {
                _accessToken = loginResult.IdentityToken;
                AccessTokenHelper.SetAccessTokenInRegistry(_accessToken);
            }
        }
        catch (Exception ex)
        {
            Log.Error($"Error ocurred to get token: {ex.Message}");
        }
        return _accessToken;
    }

    public async void LogoutAsync()
    {
        try
        {
            await _auth0Client.LogoutAsync(true);

            AccessTokenHelper.SetAccessTokenInRegistry(string.Empty);
        }
        catch (Exception ex)
        {
            Log.Error($"Error ocurred to logout: {ex.Message}");
        }
    }
}
