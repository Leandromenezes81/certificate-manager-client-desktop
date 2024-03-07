using System.Drawing;
using System.Windows.Forms;

namespace CertificateManager.UI.Forms
{
    partial class SearchCertificate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchCertificate));
            lblFederalTaxNumberSearch = new Label();
            txtFederalTaxNumberSearch = new TextBox();
            pictureBoxLogo = new PictureBox();
            btnTaxNumberSearch = new Button();
            btnLogout = new Button();
            progressBarSearch = new ProgressBar();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // lblFederalTaxNumberSearch
            // 
            lblFederalTaxNumberSearch.AutoSize = true;
            lblFederalTaxNumberSearch.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblFederalTaxNumberSearch.Location = new Point(111, 331);
            lblFederalTaxNumberSearch.Name = "lblFederalTaxNumberSearch";
            lblFederalTaxNumberSearch.Size = new Size(90, 18);
            lblFederalTaxNumberSearch.TabIndex = 0;
            lblFederalTaxNumberSearch.Text = "CNPJ/CPF";
            // 
            // txtFederalTaxNumberSearch
            // 
            txtFederalTaxNumberSearch.BackColor = SystemColors.Window;
            txtFederalTaxNumberSearch.BorderStyle = BorderStyle.None;
            txtFederalTaxNumberSearch.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtFederalTaxNumberSearch.ForeColor = SystemColors.ControlDarkDark;
            txtFederalTaxNumberSearch.Location = new Point(111, 370);
            txtFederalTaxNumberSearch.Name = "txtFederalTaxNumberSearch";
            txtFederalTaxNumberSearch.Size = new Size(290, 20);
            txtFederalTaxNumberSearch.TabIndex = 1;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(111, 182);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(290, 105);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxLogo.TabIndex = 24;
            pictureBoxLogo.TabStop = false;
            // 
            // btnTaxNumberSearch
            // 
            btnTaxNumberSearch.BackColor = SystemColors.Highlight;
            btnTaxNumberSearch.FlatAppearance.BorderColor = SystemColors.Highlight;
            btnTaxNumberSearch.FlatStyle = FlatStyle.Flat;
            btnTaxNumberSearch.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnTaxNumberSearch.ForeColor = SystemColors.ControlLightLight;
            btnTaxNumberSearch.Location = new Point(111, 429);
            btnTaxNumberSearch.Name = "btnTaxNumberSearch";
            btnTaxNumberSearch.Size = new Size(290, 33);
            btnTaxNumberSearch.TabIndex = 27;
            btnTaxNumberSearch.Text = "Buscar certificado";
            btnTaxNumberSearch.UseVisualStyleBackColor = false;
            btnTaxNumberSearch.Click += BtnFederalTaxNumberSearch_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = SystemColors.Highlight;
            btnLogout.FlatAppearance.BorderColor = SystemColors.Highlight;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = SystemColors.HighlightText;
            btnLogout.Location = new Point(308, 499);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(93, 29);
            btnLogout.TabIndex = 28;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += BtnLogout_Click;
            // 
            // progressBarSearch
            // 
            progressBarSearch.Location = new Point(111, 483);
            progressBarSearch.Name = "progressBarSearch";
            progressBarSearch.Size = new Size(290, 10);
            progressBarSearch.Style = ProgressBarStyle.Marquee;
            progressBarSearch.TabIndex = 29;
            progressBarSearch.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(111, 386);
            label1.Name = "label1";
            label1.Size = new Size(292, 15);
            label1.TabIndex = 32;
            label1.Text = "_________________________________________________________";
            // 
            // SearchCertificate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(500, 700);
            Controls.Add(label1);
            Controls.Add(progressBarSearch);
            Controls.Add(btnLogout);
            Controls.Add(btnTaxNumberSearch);
            Controls.Add(pictureBoxLogo);
            Controls.Add(txtFederalTaxNumberSearch);
            Controls.Add(lblFederalTaxNumberSearch);
            ForeColor = SystemColors.ControlDarkDark;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SearchCertificate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = ":Dcifre - Buscar";
            Load += SearchCertificate_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFederalTaxNumberSearch;
        private TextBox txtFederalTaxNumberSearch;
        private PictureBox pictureBoxLogo;
        private Button btnTaxNumberSearch;
        private Button btnLogout;
        private ProgressBar progressBarSearch;
        private Label label1;
    }
}