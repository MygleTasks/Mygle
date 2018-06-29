namespace Mygle.Grafico
{
    partial class TelaGerenteMeta
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
            this.btCancelar = new System.Windows.Forms.Button();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbCodigo = new System.Windows.Forms.Label();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btSalvar = new System.Windows.Forms.Button();
            this.lbCategorias = new System.Windows.Forms.Label();
            this.tbComissao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(109, 149);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(71, 34);
            this.btCancelar.TabIndex = 4;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(58, 47);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(199, 20);
            this.tbId.TabIndex = 1;
            // 
            // tbCodigo
            // 
            this.tbCodigo.AutoSize = true;
            this.tbCodigo.Location = new System.Drawing.Point(10, 50);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(43, 13);
            this.tbCodigo.TabIndex = 69;
            this.tbCodigo.Text = "Código:";
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(58, 73);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(199, 20);
            this.tbValor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 67;
            this.label1.Text = "Valor:";
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(186, 149);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(71, 34);
            this.btSalvar.TabIndex = 3;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // lbCategorias
            // 
            this.lbCategorias.AutoSize = true;
            this.lbCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbCategorias.Location = new System.Drawing.Point(10, 10);
            this.lbCategorias.Name = "lbCategorias";
            this.lbCategorias.Size = new System.Drawing.Size(152, 20);
            this.lbCategorias.TabIndex = 72;
            this.lbCategorias.Text = "Cadastro de Meta";
            this.lbCategorias.Click += new System.EventHandler(this.lbCategorias_Click);
            // 
            // tbComissao
            // 
            this.tbComissao.Location = new System.Drawing.Point(140, 99);
            this.tbComissao.Name = "tbComissao";
            this.tbComissao.Size = new System.Drawing.Size(117, 20);
            this.tbComissao.TabIndex = 73;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 74;
            this.label2.Text = "Percentual de Comissão:";
            // 
            // TelaGerenteMeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(269, 194);
            this.Controls.Add(this.tbComissao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbCategorias);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSalvar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TelaGerenteMeta";
            this.Text = "TelaGerenteMeta";
            this.Shown += new System.EventHandler(this.TelaGerenteMeta_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label tbCodigo;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Label lbCategorias;
        private System.Windows.Forms.TextBox tbComissao;
        private System.Windows.Forms.Label label2;
    }
}