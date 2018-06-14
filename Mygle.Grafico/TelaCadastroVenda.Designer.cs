namespace Mygle.Grafico
{
    partial class TelaCadastroVenda
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
            this.components = new System.ComponentModel.Container();
            this.tbQtd = new System.Windows.Forms.TextBox();
            this.tbQuantidade = new System.Windows.Forms.Label();
            this.lbCadastro = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.cbCategoria = new System.Windows.Forms.Label();
            this.tbValorVenda = new System.Windows.Forms.TextBox();
            this.tbValor = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCategoria = new System.Windows.Forms.TextBox();
            this.telaCadastroCategoriasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.telaCadastroCategoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.telaCadastroCategoriasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.telaCadastroCategoriasBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telaCadastroCategoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telaCadastroCategoriasBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbQtd
            // 
            this.tbQtd.Location = new System.Drawing.Point(38, 408);
            this.tbQtd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbQtd.Name = "tbQtd";
            this.tbQtd.Size = new System.Drawing.Size(484, 31);
            this.tbQtd.TabIndex = 66;
            // 
            // tbQuantidade
            // 
            this.tbQuantidade.AutoSize = true;
            this.tbQuantidade.Location = new System.Drawing.Point(38, 377);
            this.tbQuantidade.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.tbQuantidade.Name = "tbQuantidade";
            this.tbQuantidade.Size = new System.Drawing.Size(129, 25);
            this.tbQuantidade.TabIndex = 72;
            this.tbQuantidade.Text = "Quantidade:";
            // 
            // lbCadastro
            // 
            this.lbCadastro.AutoSize = true;
            this.lbCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lbCadastro.Location = new System.Drawing.Point(24, 17);
            this.lbCadastro.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbCadastro.Name = "lbCadastro";
            this.lbCadastro.Size = new System.Drawing.Size(380, 46);
            this.lbCadastro.TabIndex = 71;
            this.lbCadastro.Text = "Cadastro de Venda";
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(230, 542);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(142, 65);
            this.btCancelar.TabIndex = 70;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(384, 542);
            this.btSalvar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(142, 65);
            this.btSalvar.TabIndex = 69;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // cbCategoria
            // 
            this.cbCategoria.AutoSize = true;
            this.cbCategoria.Location = new System.Drawing.Point(38, 188);
            this.cbCategoria.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(111, 25);
            this.cbCategoria.TabIndex = 67;
            this.cbCategoria.Text = "Categoria:";
            // 
            // tbValorVenda
            // 
            this.tbValorVenda.Location = new System.Drawing.Point(38, 315);
            this.tbValorVenda.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbValorVenda.Name = "tbValorVenda";
            this.tbValorVenda.Size = new System.Drawing.Size(484, 31);
            this.tbValorVenda.TabIndex = 65;
            // 
            // tbValor
            // 
            this.tbValor.AutoSize = true;
            this.tbValor.Location = new System.Drawing.Point(38, 285);
            this.tbValor.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(68, 25);
            this.tbValor.TabIndex = 64;
            this.tbValor.Text = "Valor:";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(38, 129);
            this.tbCodigo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(484, 31);
            this.tbCodigo.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 61;
            this.label1.Text = "Código:";
            // 
            // tbCategoria
            // 
            this.tbCategoria.Location = new System.Drawing.Point(38, 219);
            this.tbCategoria.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbCategoria.Name = "tbCategoria";
            this.tbCategoria.Size = new System.Drawing.Size(484, 31);
            this.tbCategoria.TabIndex = 73;
            // 
            // telaCadastroCategoriasBindingSource2
            // 
            this.telaCadastroCategoriasBindingSource2.DataSource = typeof(Mygle.Grafico.TelaCadastroCategorias);
            // 
            // telaCadastroCategoriasBindingSource
            // 
            this.telaCadastroCategoriasBindingSource.DataSource = typeof(Mygle.Grafico.TelaCadastroCategorias);
            // 
            // telaCadastroCategoriasBindingSource1
            // 
            this.telaCadastroCategoriasBindingSource1.DataSource = typeof(Mygle.Grafico.TelaCadastroCategorias);
            // 
            // TelaCadastroVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 631);
            this.Controls.Add(this.tbCategoria);
            this.Controls.Add(this.tbQtd);
            this.Controls.Add(this.tbQuantidade);
            this.Controls.Add(this.lbCadastro);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.tbValorVenda);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "TelaCadastroVenda";
            this.Text = "TelaCadastroVenda";
            this.Load += new System.EventHandler(this.TelaCadastroVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.telaCadastroCategoriasBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telaCadastroCategoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telaCadastroCategoriasBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbQtd;
        private System.Windows.Forms.Label tbQuantidade;
        private System.Windows.Forms.Label lbCadastro;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Label cbCategoria;
        private System.Windows.Forms.TextBox tbValorVenda;
        private System.Windows.Forms.Label tbValor;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource telaCadastroCategoriasBindingSource;
        private System.Windows.Forms.BindingSource telaCadastroCategoriasBindingSource2;
        private System.Windows.Forms.BindingSource telaCadastroCategoriasBindingSource1;
        private System.Windows.Forms.TextBox tbCategoria;
    }
}