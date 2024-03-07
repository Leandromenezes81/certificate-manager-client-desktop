using System.Security.Cryptography;
using System.Text;
using System;
using System.Configuration;

namespace CertificateManager.CertificateManager.Business.Helpers;

public static class DecryptHelper
{
    private static readonly string? _secretKey = ConfigurationManager.AppSettings["Crypto:Key"];

    public static string DecryptValue(string encryptedData)
    {
        byte[] keyBytes = Encoding.UTF8.GetBytes(_secretKey ?? string.Empty);
        byte[] encryptedBytes = Convert.FromBase64String(encryptedData);

        using Aes aes = Aes.Create();
        aes.Mode = CipherMode.CBC;
        aes.Padding = PaddingMode.PKCS7;
        aes.Key = keyBytes;
        aes.IV = new byte[aes.BlockSize / 8];

        using ICryptoTransform decryptor = aes.CreateDecryptor();
        byte[] decryptedBytes = decryptor.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);

        return Encoding.UTF8.GetString(decryptedBytes);
    }

    public static byte[] DecryptValue(byte[] encryptedData)
    {
        byte[] keyBytes = Encoding.UTF8.GetBytes(_secretKey ?? string.Empty);

        using Aes aes = Aes.Create();
        aes.Mode = CipherMode.CBC;
        aes.Padding = PaddingMode.PKCS7;
        aes.Key = keyBytes;
        aes.IV = new byte[aes.BlockSize / 8];

        using ICryptoTransform decryptor = aes.CreateDecryptor();
        byte[] decryptedBytes = decryptor.TransformFinalBlock(encryptedData, 0, encryptedData.Length);

        return decryptedBytes;
    }
}
