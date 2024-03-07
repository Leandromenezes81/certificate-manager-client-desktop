using CertificateManager.CertificateManager.Business.Helpers;
using CertificateManager.CertificateManager.Business.UseCases;
using CertificateManager.CertificateManager.Domain.Entities;
using System;
using System.Windows.Forms;

namespace CertificateManager.UI.Forms;

public partial class InstallCertificate : Form
{
    private readonly InstallCertificateUseCase _installCertificateUseCase;
    private readonly DownloadCertificateUseCase _downloadCertificateUseCase;
    private DigitalCertificate? _certificate;
    private readonly SearchCertificate _searchCertificate;
    private readonly bool isManager = false;

    public InstallCertificate()
    {
        InitializeComponent();
        _searchCertificate = new SearchCertificate();
        _installCertificateUseCase = new InstallCertificateUseCase();
        _downloadCertificateUseCase = new DownloadCertificateUseCase();
        isManager = AccessTokenHelper.IsManager();
    }

    public void LoadDigitalCertificate(DigitalCertificate certificate) => _certificate = certificate;

    private void InstallCertificate_Load(object sender, EventArgs e)
    {
        if (_certificate != null)
        {
            DisplayCertificateResult(_certificate);
            progressBarInstall.Visible = false;
            pnlfederalTaxNumberInfo.Visible = true;

            if (!isManager)
            {
                btnDownloadCertificate.Visible = false;
            }
        }
    }

    private void DisplayCertificateResult(DigitalCertificate _certificate)
    {
        pnlfederalTaxNumberInfo.Controls.Clear();

        lblCompanyNameResult.Text = _certificate.CompanyName;
        pnlfederalTaxNumberInfo.Controls.Add(lblCompanyName);
        pnlfederalTaxNumberInfo.Controls.Add(lblCompanyNameResult);

        lblFederalTaxNumberResult.Text = _certificate.FederalTaxNumber;
        pnlfederalTaxNumberInfo.Controls.Add(lblFederalTaxNumber);
        pnlfederalTaxNumberInfo.Controls.Add(lblFederalTaxNumberResult);

        var companyType = _certificate.CompanyType?.ToString();
        lblCompanyTypeResult.Text = companyType switch
        {
            "J" => "Pessoa Jurídica",
            "F" => "Pessoa Física",
            _ => string.Empty
        };
        pnlfederalTaxNumberInfo.Controls.Add(lblCompanyType);
        pnlfederalTaxNumberInfo.Controls.Add(lblCompanyTypeResult);

        lblIssuerResult.Text = _certificate.Issuer;
        pnlfederalTaxNumberInfo.Controls.Add(lblIssuer);
        pnlfederalTaxNumberInfo.Controls.Add(lblIssuerResult);

        lblCreatedAtResult.Text = _certificate.CreatedAt.ToString();
        pnlfederalTaxNumberInfo.Controls.Add(lblCreatedAt);
        pnlfederalTaxNumberInfo.Controls.Add(lblCreatedAtResult);

        lblValidUntilResult.Text = _certificate.ValidUntil.ToString();
        pnlfederalTaxNumberInfo.Controls.Add(lblValidUntil);
        pnlfederalTaxNumberInfo.Controls.Add(lblValidUntilResult);

        pnlfederalTaxNumberInfo.Controls.Add(btnNewSearch);
        pnlfederalTaxNumberInfo.Controls.Add(btnInstallCertificate);
    }

    private void BtnInstallCertificate_Click(object sender, EventArgs e)
    {
        btnInstallCertificate.Enabled = false;

        ValidateAuthentication();

        progressBarInstall.Visible = true;

        bool certificateInstalled = false;

        if (_certificate != null)
            certificateInstalled = InstallCertificateUseCase.InstallCertificate(_certificate);

        if (certificateInstalled)
        {
            progressBarInstall.Value = progressBarInstall.Maximum;
            progressBarInstall.Visible = false;
            progressBarInstall.Value = 0;
            pnlfederalTaxNumberInfo.Controls.Clear();
            Visible = false;
            _searchCertificate.Show();
        }
        else
        {
            progressBarInstall.Value = progressBarInstall.Maximum;
            progressBarInstall.Visible = false;
            pnlfederalTaxNumberInfo.Controls.Clear();
            Visible = false;
            _searchCertificate.Show();
        }
    }

    private void BtnNewSearch_Click(object sender, EventArgs e)
    {
        pnlfederalTaxNumberInfo.Controls.Clear();
        _searchCertificate.Show();
        this.Close();
    }

    private async void BtnDownloadCertificate_Click(object sender, EventArgs e)
    {
        btnDownloadCertificate.Enabled = false;

        ValidateAuthentication();

        progressBarInstall.Visible = true;

        bool downloadedCertificate = false;

        if (_certificate != null)
        {
            progressBarInstall.Value = progressBarInstall.Maximum;
            downloadedCertificate = await _downloadCertificateUseCase.DownloadCertificate(_certificate.FederalTaxNumber ?? string.Empty,
                _certificate?.CompanyName ?? string.Empty);
        }

        if (downloadedCertificate)
        {
            progressBarInstall.Visible = false;
            progressBarInstall.Value = 0;
            btnDownloadCertificate.Enabled = true;
        }
        else
        {
            progressBarInstall.Visible = false;
            progressBarInstall.Value = 0;
            btnDownloadCertificate.Enabled = true;
        }
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