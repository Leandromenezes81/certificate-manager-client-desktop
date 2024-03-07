using CertificateManager.CertificateManager.Business.Helpers;
using CertificateManager.CertificateManager.Business.UseCases;
using CertificateManager.CertificateManager.Domain.Entities;
using CertificateManager.CertificateManager.Domain.Interfaces;
using CertificateManager.CertificateManager.Infrastructure.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CertificateManager.UI.Forms;

public partial class SearchCertificate : Form
{
    private readonly IAuth0ClientService _auth0ClientService;
    private DigitalCertificate? _certificate;
    private readonly FindCertificateUseCase _findCertificateUseCase;

    public SearchCertificate()
    {
        InitializeComponent();
        _auth0ClientService = new Auth0ClientService();
        _findCertificateUseCase = new FindCertificateUseCase();
    }

    private void SearchCertificate_Load(object sender, EventArgs e)
    {
        progressBarSearch.Visible = false;
    }

    private async void BtnFederalTaxNumberSearch_Click(object sender, EventArgs e)
    {
        btnTaxNumberSearch.Enabled = false;

        ValidateAuthentication();

        progressBarSearch.Visible = true;

        string cleanedNumber = new(txtFederalTaxNumberSearch.Text.Where(char.IsDigit).ToArray());

        if (!FederalTaxNumberHelper.IsValidFederalTaxNumber(cleanedNumber))
        {
            Show();
            progressBarSearch.Visible = false;
            btnTaxNumberSearch.Enabled = true;
            return;
        }

        _certificate = await _findCertificateUseCase.FindDigitalCerticate(cleanedNumber);

        if (!string.IsNullOrEmpty(_certificate?.FederalTaxNumber))
        {
            progressBarSearch.Value = progressBarSearch.Maximum;
            InstallCertificate installCertificate = new();
            installCertificate.LoadDigitalCertificate(_certificate);
            installCertificate.Show();
            Visible = false;
        }
        else
        {
            progressBarSearch.Visible = false;
            progressBarSearch.Value = 0;
            Show();
        }
        progressBarSearch.Visible = false;
        progressBarSearch.Value = 0;

        btnTaxNumberSearch.Enabled = true;
    }

    private void BtnLogout_Click(object sender, EventArgs e)
    {
        _auth0ClientService.LogoutAsync();
        Visible = false;
        Login login = new();
        login.Show();
    }

    private void ValidateAuthentication()
    {
        if (!AccessTokenHelper.IsValidToken())
        {
            AccessTokenHelper.IsInvalidTokenMessage();
            Visible = false;
            Login login = new();
            login.Show();
        }
    }
}
