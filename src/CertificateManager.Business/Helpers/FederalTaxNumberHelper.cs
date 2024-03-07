using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CertificateManager.CertificateManager.Business.Helpers;

public static class FederalTaxNumberHelper
{
    public static bool IsValidFederalTaxNumber(string federalTaxNumber)
    {
        Regex cnpjRegex = new(@"^\d{14}$");
        Regex cpfRegex = new(@"^\d{11}$");

        if (federalTaxNumber == string.Empty ||
           (!cnpjRegex.IsMatch(federalTaxNumber) &&
            !cpfRegex.IsMatch(federalTaxNumber)))
        {
            MessageBox.Show("Erro: CNPJ/CPF deve ter 11 ou 14 dígitos numéricos.",
                "Erro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);            
            return false;
        }
        return true;
    }
}
