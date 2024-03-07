namespace CertificateManager.CertificateManager.Business.DTOs
{
    public class HttpResponseResultDTO<T>
    {
        public T? Data { get; set; }
        public string? Message { get; set; }
    }
}
