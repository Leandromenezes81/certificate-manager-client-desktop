using CertificateManager.CertificateManager.Business.UseCases;
using System;
using System.Windows.Forms;

namespace CertificateManager.UI.Forms;

public partial class Login : Form
{
    private readonly LoginUserUseCase _loginUserUseCase;

    public Login()
    {
        InitializeComponent();
        _loginUserUseCase = new LoginUserUseCase();
    }

    private void Login_Load(object sender, EventArgs e)
    {
        progressBarLogin.Visible = false;
    }

    private async void BtnLogin_Click(object sender, EventArgs e)
    {
        btnLogin.Enabled = false;
        progressBarLogin.Visible = true;

        var userLogged = await _loginUserUseCase.GetAuthZeroAccess();

        if (userLogged)
        {
            SearchCertificate searchCertificate = new();
            searchCertificate.Show();
            Visible = false;
        }
        else
        {
            progressBarLogin.Visible = false;
            progressBarLogin.Value = 0;
            btnLogin.Enabled = true;
            Show();
        }
    }        
}
