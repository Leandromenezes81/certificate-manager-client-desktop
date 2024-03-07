using System;
using System.Text.Json.Serialization;

namespace CertificateManager.CertificateManager.Domain.Entities;

public class DigitalCertificate
{
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("companyName")]
    public string? CompanyName { get; set; }

    [JsonPropertyName("federalTaxNumber")]
    public string? FederalTaxNumber { get; set; }

    [JsonPropertyName("companyType")]
    public char? CompanyType { get; set; }

    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    [JsonPropertyName("certificateData")]
    public string? CertificateData { get; set; }

    [JsonPropertyName("password")]
    public string? Password { get; set; }

    [JsonPropertyName("createdAt")]
    public DateTime? CreatedAt { get; set; }

    [JsonPropertyName("validUntil")]
    public DateTime? ValidUntil { get; set; }
}
