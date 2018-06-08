namespace Mygle.Grafico
{
    partial class TelaLoginMygle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLoginMygle));
            this.pbxLogoTela = new System.Windows.Forms.PictureBox();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.llbRecuperarSenha = new System.Windows.Forms.LinkLabel();
            this.btLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoTela)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxLogoTela
            // 
            this.pbxLogoTela.BackColor = System.Drawing.Color.Transparent;
            this.pbxLogoTela.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxLogoTela.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbxLogoTela.ErrorImage")));
            this.pbxLogoTela.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogoTela.Image")));
            this.pbxLogoTela.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbxLogoTela.InitialImage")));
            this.pbxLogoTela.Location = new System.Drawing.Point(308, 12);
            this.pbxLogoTela.Name = "pbxLogoTela";
            this.pbxLogoTela.Size = new System.Drawing.Size(415, 312);
            this.pbxLogoTela.TabIndex = 0;
            this.pbxLogoTela.TabStop = false;
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(395, 421);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(242, 20);
            this.tbUsuario.TabIndex = 1;
            this.tbUsuario.Text = "Usuário";
            this.tbUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbSenha
            // 
            this.tbSenha.Location = new System.Drawing.Point(395, 447);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.Size = new System.Drawing.Size(242, 20);
            this.tbSenha.TabIndex = 2;
            this.tbSenha.Text = "Senha";
            this.tbSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // llbRecuperarSenha
            // 
            this.llbRecuperarSenha.AutoSize = true;
            this.llbRecuperarSenha.Location = new System.Drawing.Point(392, 470);
            this.llbRecuperarSenha.Name = "llbRecuperarSenha";
            this.llbRecuperarSenha.Size = new System.Drawing.Size(91, 13);
            this.llbRecuperarSenha.TabIndex = 3;
            this.llbRecuperarSenha.TabStop = true;
            this.llbRecuperarSenha.Text = "Recuperar Senha";
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.Color.Transparent;
            this.btLogin.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btLogin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btLogin.Location = new System.Drawing.Point(480, 514);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(75, 23);
            this.btLogin.TabIndex = 4;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = false;
            // 
            // TelaLoginMygle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 661);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.llbRecuperarSenha);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.pbxLogoTela);
            this.Name = "TelaLoginMygle";
            this.Text = "Mygle";
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoTela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxLogoTela;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.LinkLabel llbRecuperarSenha;
        private System.Windows.Forms.Button btLogin;
    }
}