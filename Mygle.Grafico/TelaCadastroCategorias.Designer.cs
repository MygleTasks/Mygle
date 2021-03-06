﻿namespace Mygle.Grafico
{
    partial class TelaCadastroCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastroCategorias));
            this.lbCategorias = new System.Windows.Forms.Label();
            this.btSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbCodigo = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCategorias
            // 
            this.lbCategorias.AutoSize = true;
            this.lbCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lbCategorias.Location = new System.Drawing.Point(20, 19);
            this.lbCategorias.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbCategorias.Name = "lbCategorias";
            this.lbCategorias.Size = new System.Drawing.Size(442, 46);
            this.lbCategorias.TabIndex = 53;
            this.lbCategorias.Text = "Cadastro de Categoria";
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(364, 237);
            this.btSalvar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(142, 65);
            this.btSalvar.TabIndex = 4;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 146);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 59;
            this.label1.Text = "Nome:";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(106, 140);
            this.tbNome.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(396, 31);
            this.tbNome.TabIndex = 2;
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(106, 90);
            this.tbId.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(196, 31);
            this.tbId.TabIndex = 1;
            this.tbId.TextChanged += new System.EventHandler(this.tbId_TextChanged);
            // 
            // tbCodigo
            // 
            this.tbCodigo.AutoSize = true;
            this.tbCodigo.Location = new System.Drawing.Point(20, 96);
            this.tbCodigo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(86, 25);
            this.tbCodigo.TabIndex = 63;
            this.tbCodigo.Text = "Código:";
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(210, 237);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(142, 65);
            this.btCancelar.TabIndex = 3;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // TelaCadastroCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(538, 329);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.lbCategorias);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "TelaCadastroCategorias";
            this.Text = "TelaCadastroCategorias";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TelaCadastroCategorias_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCategorias;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label tbCodigo;
        private System.Windows.Forms.Button btCancelar;
    }
}