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
            this.label2 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbCodigo = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCategorias
            // 
            this.lbCategorias.AutoSize = true;
            this.lbCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbCategorias.Location = new System.Drawing.Point(8, 9);
            this.lbCategorias.Name = "lbCategorias";
            this.lbCategorias.Size = new System.Drawing.Size(190, 20);
            this.lbCategorias.TabIndex = 53;
            this.lbCategorias.Text = "Cadastro de Categoria";
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(174, 170);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(71, 34);
            this.btSalvar.TabIndex = 58;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Tipo:";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(61, 92);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(184, 20);
            this.tbNome.TabIndex = 61;
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Valor",
            "Quantidade"});
            this.cbTipo.Location = new System.Drawing.Point(61, 116);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(184, 21);
            this.cbTipo.TabIndex = 62;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(61, 66);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(184, 20);
            this.tbId.TabIndex = 64;
            // 
            // tbCodigo
            // 
            this.tbCodigo.AutoSize = true;
            this.tbCodigo.Location = new System.Drawing.Point(17, 69);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(43, 13);
            this.tbCodigo.TabIndex = 63;
            this.tbCodigo.Text = "Código:";
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(97, 170);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(71, 34);
            this.btCancelar.TabIndex = 65;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // TelaCadastroCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 216);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label tbCodigo;
        private System.Windows.Forms.Button btCancelar;
    }
}