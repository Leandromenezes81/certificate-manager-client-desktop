using CertificateManager.CertificateManager.Business.DTOs;
using System;
using System.Text.Json;
using System.Windows.Forms;

namespace CertificateManager.CertificateManager.Business.Helpers;

public static class MessageBoxHelper
{
    public static void ShowErrorMessageBox(string responseContent)
    {
        ResultInfoDTO? resultInfo = JsonSerializer.Deserialize<ResultInfoDTO>(responseContent);

        if (resultInfo?.Status == 400)
        {
            responseContent = $@"Erro: {resultInfo.Message} - StatusCode: {resultInfo.Status}";
            MessageBox.Show(
                responseContent,
                "Atenção",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
        }
        else
        {
            responseContent = $@"Erro: {resultInfo?.Message} - StatusCode: {resultInfo?.Status}";
            MessageBox.Show(
                responseContent,
                "Erro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
        }

    }

    public static string CreateGenericErrorMessage(string path, string target)
    {
        string currentTimestamp = DateTimeOffset.Now.ToString("yyyy-MM-ddTHH:mm:ss.fffzzz");
        return $@"{{""timestamp"":""{currentTimestamp}"",""status"":500,""error"":""InternalServerError"",""message"":""Erro Inesperado ao processar a requisição."",""path"":""{path}/{target}""}}";
    }
}
