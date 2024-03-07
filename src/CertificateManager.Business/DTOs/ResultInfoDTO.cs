using System;
using System.Text.Json.Serialization;

namespace CertificateManager.CertificateManager.Business.DTOs;

public class ResultInfoDTO
{
    [JsonPropertyName("timestamp")]
    public DateTime? Timestamp { get; set; }

    [JsonPropertyName("status")]
    public int? Status { get; set; }

    [JsonPropertyName("error")]
    public string? Error { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }
}
