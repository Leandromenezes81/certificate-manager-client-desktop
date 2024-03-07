using System.Drawing;
using System.Windows.Forms;

namespace CertificateManager.UI.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBoxLogo = new PictureBox();
            lblLogin = new Label();
            lblVersion = new Label();
            btnLogin = new Button();
            progressBarLogin = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(109, 159);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(290, 105);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxLogo.TabIndex = 22;
            pictureBoxLogo.TabStop = false;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Microsoft Sans Serif", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogin.Location = new Point(147, 324);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(222, 29);
            lblLogin.TabIndex = 25;
            lblLogin.Text = "Certificate Manager";
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblVersion.Location = new Point(223, 599);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(47, 16);
            lblVersion.TabIndex = 26;
            lblVersion.Text = "v1.0.1";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.Highlight;
            btnLogin.FlatAppearance.BorderColor = SystemColors.Highlight;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = SystemColors.ButtonHighlight;
            btnLogin.Location = new Point(109, 415);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(290, 33);
            btnLogin.TabIndex = 27;
            btnLogin.Text = "Fazer login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += BtnLogin_Click;
            // 
            // progressBarLogin
            // 
            progressBarLogin.Location = new Point(109, 475);
            progressBarLogin.Name = "progressBarLogin";
            progressBarLogin.Size = new Size(290, 10);
            progressBarLogin.Style = ProgressBarStyle.Marquee;
            progressBarLogin.TabIndex = 28;
            progressBarLogin.UseWaitCursor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(500, 700);
            Controls.Add(progressBarLogin);
            Controls.Add(btnLogin);
            Controls.Add(lblVersion);
            Controls.Add(lblLogin);
            Controls.Add(pictureBoxLogo);
            Font = new Font("Cascadia Code PL Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = ":Dcifre - Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBoxLogo;
        private Label lblLogin;
        private Label lblVersion;
        private Button btnLogin;
        private ProgressBar progressBarLogin;
    }
}