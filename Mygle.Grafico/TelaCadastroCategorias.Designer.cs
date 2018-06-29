namespace Mygle.Grafico
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
            this.lbCategorias.Location = new System.Drawing.Point(10, 10);
            this.lbCategorias.Name = "lbCategorias";
            this.lbCategorias.Size = new System.Drawing.Size(230, 25);
            this.lbCategorias.TabIndex = 53;
            this.lbCategorias.Text = "Cadastro de Categoria";
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(182, 123);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(71, 34);
            this.btSalvar.TabIndex = 5;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Nome:";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(53, 73);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(200, 20);
            this.tbNome.TabIndex = 61;
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(53, 47);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(100, 20);
            this.tbId.TabIndex = 1;
            this.tbId.TextChanged += new System.EventHandler(this.tbId_TextChanged);
            // 
            // tbCodigo
            // 
            this.tbCodigo.AutoSize = true;
            this.tbCodigo.Location = new System.Drawing.Point(10, 50);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(43, 13);
            this.tbCodigo.TabIndex = 63;
            this.tbCodigo.Text = "Código:";
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(105, 123);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(71, 34);
            this.btCancelar.TabIndex = 4;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // TelaCadastroCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(269, 171);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.lbCategorias);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
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