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
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.llbRecuperarSenha = new System.Windows.Forms.LinkLabel();
            this.btLogin = new System.Windows.Forms.Button();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.pbxLogoTela.Location = new System.Drawing.Point(40, 40);
            this.pbxLogoTela.Name = "pbxLogoTela";
            this.pbxLogoTela.Size = new System.Drawing.Size(328, 220);
            this.pbxLogoTela.TabIndex = 0;
            this.pbxLogoTela.TabStop = false;
            // 
            // tbSenha
            // 
            this.tbSenha.Location = new System.Drawing.Point(413, 146);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.PasswordChar = '*';
            this.tbSenha.Size = new System.Drawing.Size(160, 20);
            this.tbSenha.TabIndex = 2;
            this.tbSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSenha_KeyPress);
            // 
            // llbRecuperarSenha
            // 
            this.llbRecuperarSenha.AutoSize = true;
            this.llbRecuperarSenha.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(109)))), ((int)(((byte)(178)))));
            this.llbRecuperarSenha.Location = new System.Drawing.Point(410, 169);
            this.llbRecuperarSenha.Name = "llbRecuperarSenha";
            this.llbRecuperarSenha.Size = new System.Drawing.Size(91, 13);
            this.llbRecuperarSenha.TabIndex = 4;
            this.llbRecuperarSenha.TabStop = true;
            this.llbRecuperarSenha.Text = "Recuperar Senha";
            this.llbRecuperarSenha.VisitedLinkColor = System.Drawing.Color.Red;
            this.llbRecuperarSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbRecuperarSenha_LinkClicked);
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.Color.Transparent;
            this.btLogin.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btLogin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btLogin.Location = new System.Drawing.Point(458, 226);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(71, 34);
            this.btLogin.TabIndex = 3;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(413, 86);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(160, 20);
            this.tbUsuario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(410, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(410, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Senha";
            // 
            // TelaLoginMygle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(611, 303);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.llbRecuperarSenha);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.pbxLogoTela);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "TelaLoginMygle";
            this.Text = "Mygle";
            this.Load += new System.EventHandler(this.TelaLoginMygle_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TelaLoginMygle_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoTela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxLogoTela;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.LinkLabel llbRecuperarSenha;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}