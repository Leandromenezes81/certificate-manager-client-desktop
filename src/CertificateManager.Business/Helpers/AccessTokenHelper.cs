using System;
using System.Configuration;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Windows.Forms;

namespace CertificateManager.CertificateManager.Business.Helpers;

public static class AccessTokenHelper
{
    private static readonly string _urlRoleClaims =
        ConfigurationManager.AppSettings["UrlRoleClaims:CertificateManager"] ?? string.Empty;
    private static readonly string _issuer = 
        ConfigurationManager.AppSettings["Auth0:Domain"] ?? string.Empty;
    private static string? _accessToken;

    public static bool IsManager()
    {
        _accessToken = GetAccessTokenFromRegistry();

        JwtSecurityTokenHandler securityTokenHandler = new();
        var jwtToken = securityTokenHandler.ReadJwtToken(_accessToken);

        var rolesClaim = jwtToken.Claims?.FirstOrDefault(c => c.Type == _urlRoleClaims);

        if (rolesClaim != null)
        {
            var rolesValue = rolesClaim.Value;
            if (!string.IsNullOrEmpty(rolesValue))
            {
                var roles = rolesValue.ToLower().Split(',');
                if (roles.Contains("certificate_manager_admin"))
                {
                    return true;
                }
            }
        }
        return false;
    }

    public static bool IsValidToken()
    {
        _accessToken = GetAccessTokenFromRegistry();

        if (string.IsNullOrEmpty(_accessToken))
        {
            return false;
        }

        JwtSecurityTokenHandler securityTokenHandler = new();
        var jwtToken = securityTokenHandler.ReadJwtToken(_accessToken);

        var jwtTokenIssuer = jwtToken.Issuer;
        if (jwtTokenIssuer.StartsWith("https://"))
        {
            jwtTokenIssuer = jwtTokenIssuer.Substring(8);
        }
        jwtTokenIssuer = jwtTokenIssuer.TrimEnd('/');

        if (!(jwtToken.ValidTo > DateTime.Now) || !jwtTokenIssuer.Equals(_issuer))
        {
            SetAccessTokenInRegistry(string.Empty);
            return false;
        }
        return true;
    }

    public static string GetAccessTokenFromRegistry()
    {
        return Application.UserAppDataRegistry.GetValue("AccessToken") as string ?? string.Empty;
    }

    public static void SetAccessTokenInRegistry(string accessToken)
    {
        Application.UserAppDataRegistry.SetValue("AccessToken", accessToken);
    }

    public static void IsInvalidTokenMessage()
    {
        MessageBox.Show("Sessão expirada. Realize um novo login.",
            "Atenção",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning);
    }
}
