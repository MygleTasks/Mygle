﻿namespace Mygle.Grafico
{
    partial class TelaCadastrarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastrarUsuario));
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.lbCadastro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.tbSenha2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(26, 319);
            this.tbUsuario.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(692, 31);
            this.tbUsuario.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 288);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuário:";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(26, 223);
            this.tbNome.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(692, 31);
            this.tbNome.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 192);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome:";
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(426, 608);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(142, 65);
            this.btCancelar.TabIndex = 6;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(580, 608);
            this.btSalvar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(142, 65);
            this.btSalvar.TabIndex = 7;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // lbCadastro
            // 
            this.lbCadastro.AutoSize = true;
            this.lbCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lbCadastro.Location = new System.Drawing.Point(20, 19);
            this.lbCadastro.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbCadastro.Name = "lbCadastro";
            this.lbCadastro.Size = new System.Drawing.Size(405, 46);
            this.lbCadastro.TabIndex = 57;
            this.lbCadastro.Text = "Cadastro de Usuário";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Enabled = false;
            this.tbCodigo.Location = new System.Drawing.Point(26, 127);
            this.tbCodigo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(692, 31);
            this.tbCodigo.TabIndex = 1;
            this.tbCodigo.TextChanged += new System.EventHandler(this.tbCodigo_TextChanged);
            // 
            // tbSenha2
            // 
            this.tbSenha2.Location = new System.Drawing.Point(26, 512);
            this.tbSenha2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbSenha2.Name = "tbSenha2";
            this.tbSenha2.PasswordChar = '*';
            this.tbSenha2.Size = new System.Drawing.Size(692, 31);
            this.tbSenha2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 385);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 58;
            this.label4.Text = "Senha:";
            // 
            // tbSenha
            // 
            this.tbSenha.Location = new System.Drawing.Point(26, 415);
            this.tbSenha.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.PasswordChar = '*';
            this.tbSenha.Size = new System.Drawing.Size(692, 31);
            this.tbSenha.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 481);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 25);
            this.label5.TabIndex = 60;
            this.label5.Text = "Confirmação da Senha:";
            // 
            // TelaCadastrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(744, 694);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbSenha2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbCadastro);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "TelaCadastrarUsuario";
            this.Text = "TelaCadastrarUsuario";
            this.Load += new System.EventHandler(this.TelaCadastrarUsuario_Load);
            this.Shown += new System.EventHandler(this.TelaCadastrarUsuario_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TelaCadastrarUsuario_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Label lbCadastro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.TextBox tbSenha2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.Label label5;
    }
}