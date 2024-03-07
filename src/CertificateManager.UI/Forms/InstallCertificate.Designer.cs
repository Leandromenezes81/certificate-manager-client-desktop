using System.Drawing;
using System.Windows.Forms;

namespace CertificateManager.UI.Forms;

partial class InstallCertificate
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstallCertificate));
        lblValidUntil = new Label();
        lblCompanyType = new Label();
        lblCreatedAt = new Label();
        lblIssuer = new Label();
        lblFederalTaxNumber = new Label();
        lblCompanyName = new Label();
        lblCompanyNameResult = new Label();
        lblFederalTaxNumberResult = new Label();
        lblCompanyTypeResult = new Label();
        lblIssuerResult = new Label();
        lblCreatedAtResult = new Label();
        lblValidUntilResult = new Label();
        pnlfederalTaxNumberInfo = new Panel();
        btnNewSearch = new Button();
        btnInstallCertificate = new Button();
        progressBarInstall = new ProgressBar();
        pictureBoxLogo = new PictureBox();
        btnDownloadCertificate = new Button();
        pnlfederalTaxNumberInfo.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
        SuspendLayout();
        // 
        // lblValidUntil
        // 
        lblValidUntil.AutoSize = true;
        lblValidUntil.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
        lblValidUntil.Location = new Point(10, 209);
        lblValidUntil.Name = "lblValidUntil";
        lblValidUntil.Size = new Size(67, 18);
        lblValidUntil.TabIndex = 6;
        lblValidUntil.Text = "Validade:";
        // 
        // lblCompanyType
        // 
        lblCompanyType.AutoSize = true;
        lblCompanyType.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
        lblCompanyType.Location = new Point(10, 99);
        lblCompanyType.Name = "lblCompanyType";
        lblCompanyType.Size = new Size(41, 18);
        lblCompanyType.TabIndex = 5;
        lblCompanyType.Text = "Tipo:";
        // 
        // lblCreatedAt
        // 
        lblCreatedAt.AutoSize = true;
        lblCreatedAt.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
        lblCreatedAt.Location = new Point(10, 172);
        lblCreatedAt.Name = "lblCreatedAt";
        lblCreatedAt.Size = new Size(126, 18);
        lblCreatedAt.TabIndex = 4;
        lblCreatedAt.Text = "Data de Emissão:";
        // 
        // lblIssuer
        // 
        lblIssuer.AutoSize = true;
        lblIssuer.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
        lblIssuer.Location = new Point(10, 135);
        lblIssuer.Name = "lblIssuer";
        lblIssuer.Size = new Size(68, 18);
        lblIssuer.TabIndex = 3;
        lblIssuer.Text = "Emissor:";
        // 
        // lblFederalTaxNumber
        // 
        lblFederalTaxNumber.AutoSize = true;
        lblFederalTaxNumber.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
        lblFederalTaxNumber.Location = new Point(10, 62);
        lblFederalTaxNumber.Name = "lblFederalTaxNumber";
        lblFederalTaxNumber.Size = new Size(86, 18);
        lblFederalTaxNumber.TabIndex = 2;
        lblFederalTaxNumber.Text = "CNPJ/CPF:";
        // 
        // lblCompanyName
        // 
        lblCompanyName.AutoSize = true;
        lblCompanyName.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
        lblCompanyName.Location = new Point(10, 24);
        lblCompanyName.Name = "lblCompanyName";
        lblCompanyName.Size = new Size(53, 18);
        lblCompanyName.TabIndex = 1;
        lblCompanyName.Text = "Nome:";
        // 
        // lblCompanyNameResult
        // 
        lblCompanyNameResult.AutoSize = true;
        lblCompanyNameResult.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
        lblCompanyNameResult.Location = new Point(69, 24);
        lblCompanyNameResult.Name = "lblCompanyNameResult";
        lblCompanyNameResult.Size = new Size(53, 18);
        lblCompanyNameResult.TabIndex = 15;
        lblCompanyNameResult.Text = "Nome";
        // 
        // lblFederalTaxNumberResult
        // 
        lblFederalTaxNumberResult.AutoSize = true;
        lblFederalTaxNumberResult.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
        lblFederalTaxNumberResult.Location = new Point(102, 62);
        lblFederalTaxNumberResult.Name = "lblFederalTaxNumberResult";
        lblFederalTaxNumberResult.Size = new Size(90, 18);
        lblFederalTaxNumberResult.TabIndex = 16;
        lblFederalTaxNumberResult.Text = "CNPJ/CPF";
        // 
        // lblCompanyTypeResult
        // 
        lblCompanyTypeResult.AutoSize = true;
        lblCompanyTypeResult.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
        lblCompanyTypeResult.Location = new Point(57, 99);
        lblCompanyTypeResult.Name = "lblCompanyTypeResult";
        lblCompanyTypeResult.Size = new Size(41, 18);
        lblCompanyTypeResult.TabIndex = 17;
        lblCompanyTypeResult.Text = "Tipo";
        // 
        // lblIssuerResult
        // 
        lblIssuerResult.AutoSize = true;
        lblIssuerResult.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
        lblIssuerResult.Location = new Point(84, 135);
        lblIssuerResult.Name = "lblIssuerResult";
        lblIssuerResult.Size = new Size(71, 18);
        lblIssuerResult.TabIndex = 18;
        lblIssuerResult.Text = "Emissor";
        // 
        // lblCreatedAtResult
        // 
        lblCreatedAtResult.AutoSize = true;
        lblCreatedAtResult.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
        lblCreatedAtResult.Location = new Point(142, 172);
        lblCreatedAtResult.Name = "lblCreatedAtResult";
        lblCreatedAtResult.Size = new Size(137, 18);
        lblCreatedAtResult.TabIndex = 19;
        lblCreatedAtResult.Text = "Data de Emissão";
        // 
        // lblValidUntilResult
        // 
        lblValidUntilResult.AutoSize = true;
        lblValidUntilResult.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
        lblValidUntilResult.Location = new Point(83, 209);
        lblValidUntilResult.Name = "lblValidUntilResult";
        lblValidUntilResult.Size = new Size(71, 18);
        lblValidUntilResult.TabIndex = 20;
        lblValidUntilResult.Text = "Validade";
        // 
        // pnlfederalTaxNumberInfo
        // 
        pnlfederalTaxNumberInfo.BackColor = Color.White;
        pnlfederalTaxNumberInfo.Controls.Add(btnNewSearch);
        pnlfederalTaxNumberInfo.Controls.Add(btnInstallCertificate);
        pnlfederalTaxNumberInfo.Controls.Add(lblFederalTaxNumberResult);
        pnlfederalTaxNumberInfo.Controls.Add(lblValidUntilResult);
        pnlfederalTaxNumberInfo.Controls.Add(lblValidUntil);
        pnlfederalTaxNumberInfo.Controls.Add(lblCreatedAtResult);
        pnlfederalTaxNumberInfo.Controls.Add(lblCompanyType);
        pnlfederalTaxNumberInfo.Controls.Add(lblIssuerResult);
        pnlfederalTaxNumberInfo.Controls.Add(lblCreatedAt);
        pnlfederalTaxNumberInfo.Controls.Add(lblCompanyTypeResult);
        pnlfederalTaxNumberInfo.Controls.Add(lblIssuer);
        pnlfederalTaxNumberInfo.Controls.Add(lblFederalTaxNumber);
        pnlfederalTaxNumberInfo.Controls.Add(lblCompanyNameResult);
        pnlfederalTaxNumberInfo.Controls.Add(lblCompanyName);
        pnlfederalTaxNumberInfo.Location = new Point(0, 237);
        pnlfederalTaxNumberInfo.Name = "pnlfederalTaxNumberInfo";
        pnlfederalTaxNumberInfo.Size = new Size(646, 351);
        pnlfederalTaxNumberInfo.TabIndex = 21;
        // 
        // btnNewSearch
        // 
        btnNewSearch.BackColor = SystemColors.Highlight;
        btnNewSearch.FlatAppearance.BorderColor = SystemColors.Highlight;
        btnNewSearch.FlatStyle = FlatStyle.Flat;
        btnNewSearch.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
        btnNewSearch.ForeColor = SystemColors.ButtonHighlight;
        btnNewSearch.Location = new Point(187, 306);
        btnNewSearch.Name = "btnNewSearch";
        btnNewSearch.Size = new Size(290, 33);
        btnNewSearch.TabIndex = 29;
        btnNewSearch.Text = "Nova consulta";
        btnNewSearch.UseVisualStyleBackColor = false;
        btnNewSearch.Click += BtnNewSearch_Click;
        // 
        // btnInstallCertificate
        // 
        btnInstallCertificate.BackColor = SystemColors.Highlight;
        btnInstallCertificate.FlatAppearance.BorderColor = SystemColors.Highlight;
        btnInstallCertificate.FlatStyle = FlatStyle.Flat;
        btnInstallCertificate.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
        btnInstallCertificate.ForeColor = SystemColors.ButtonHighlight;
        btnInstallCertificate.Location = new Point(187, 255);
        btnInstallCertificate.Name = "btnInstallCertificate";
        btnInstallCertificate.Size = new Size(290, 33);
        btnInstallCertificate.TabIndex = 28;
        btnInstallCertificate.Text = "Instalar certificado";
        btnInstallCertificate.UseVisualStyleBackColor = false;
        btnInstallCertificate.Click += BtnInstallCertificate_Click;
        // 
        // progressBarInstall
        // 
        progressBarInstall.Location = new Point(187, 633);
        progressBarInstall.Name = "progressBarInstall";
        progressBarInstall.Size = new Size(290, 10);
        progressBarInstall.Style = ProgressBarStyle.Marquee;
        progressBarInstall.TabIndex = 30;
        progressBarInstall.UseWaitCursor = true;
        // 
        // pictureBoxLogo
        // 
        pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
        pictureBoxLogo.Location = new Point(187, 126);
        pictureBoxLogo.Name = "pictureBoxLogo";
        pictureBoxLogo.Size = new Size(290, 105);
        pictureBoxLogo.SizeMode = PictureBoxSizeMode.CenterImage;
        pictureBoxLogo.TabIndex = 23;
        pictureBoxLogo.TabStop = false;
        // 
        // btnDownloadCertificate
        // 
        btnDownloadCertificate.BackColor = SystemColors.Highlight;
        btnDownloadCertificate.FlatAppearance.BorderColor = SystemColors.Highlight;
        btnDownloadCertificate.FlatStyle = FlatStyle.Flat;
        btnDownloadCertificate.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
        btnDownloadCertificate.ForeColor = SystemColors.ButtonHighlight;
        btnDownloadCertificate.Location = new Point(187, 594);
        btnDownloadCertificate.Name = "btnDownloadCertificate";
        btnDownloadCertificate.Size = new Size(290, 33);
        btnDownloadCertificate.TabIndex = 31;
        btnDownloadCertificate.Text = "Baixar certificado";
        btnDownloadCertificate.UseVisualStyleBackColor = false;
        btnDownloadCertificate.Click += BtnDownloadCertificate_Click;
        // 
        // InstallCertificate
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoSize = true;
        BackColor = Color.White;
        ClientSize = new Size(647, 700);
        Controls.Add(btnDownloadCertificate);
        Controls.Add(progressBarInstall);
        Controls.Add(pictureBoxLogo);
        Controls.Add(pnlfederalTaxNumberInfo);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Name = "InstallCertificate";
        StartPosition = FormStartPosition.CenterScreen;
        Text = ":Dcifre - Instalar";
        Load += InstallCertificate_Load;
        pnlfederalTaxNumberInfo.ResumeLayout(false);
        pnlfederalTaxNumberInfo.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
        ResumeLayout(false);
    }

    #endregion
    private Label lblIssuer;
    private Label lblFederalTaxNumber;
    private Label lblCompanyName;
    private Label lblCreatedAt;
    private Label lblCompanyType;
    private Label lblValidUntil;
    private Label lblCompanyNameResult;
    private Label lblFederalTaxNumberResult;
    private Label lblCompanyTypeResult;
    private Label lblIssuerResult;
    private Label lblCreatedAtResult;
    private Label lblValidUntilResult;
    private Panel pnlfederalTaxNumberInfo;
    private PictureBox pictureBoxLogo;
    private Button btnInstallCertificate;
    private Button btnNewSearch;
    private Button btnDownloadCertificate;
    private ProgressBar progressBarInstall;
}