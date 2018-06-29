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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastroVenda));
            this.tbQuantidade = new System.Windows.Forms.TextBox();
            this.lbQuantidade = new System.Windows.Forms.Label();
            this.lbCadastro = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.lbValor = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.telaCadastroCategoriasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.telaCadastroCategoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.telaCadastroCategoriasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.telaCadastroCategoriasBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telaCadastroCategoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telaCadastroCategoriasBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbQuantidade
            // 
            this.tbQuantidade.Location = new System.Drawing.Point(13, 216);
            this.tbQuantidade.Name = "tbQuantidade";
            this.tbQuantidade.Size = new System.Drawing.Size(244, 20);
            this.tbQuantidade.TabIndex = 4;
            // 
            // lbQuantidade
            // 
            this.lbQuantidade.AutoSize = true;
            this.lbQuantidade.Location = new System.Drawing.Point(10, 200);
            this.lbQuantidade.Name = "lbQuantidade";
            this.lbQuantidade.Size = new System.Drawing.Size(65, 13);
            this.lbQuantidade.TabIndex = 72;
            this.lbQuantidade.Text = "Quantidade:";
            // 
            // lbCadastro
            // 
            this.lbCadastro.AutoSize = true;
            this.lbCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lbCadastro.Location = new System.Drawing.Point(10, 10);
            this.lbCadastro.Name = "lbCadastro";
            this.lbCadastro.Size = new System.Drawing.Size(199, 25);
            this.lbCadastro.TabIndex = 71;
            this.lbCadastro.Text = "Cadastro de Venda";
            this.lbCadastro.Click += new System.EventHandler(this.lbCadastro_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(115, 266);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(71, 34);
            this.btCancelar.TabIndex = 5;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(192, 266);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(71, 34);
            this.btSalvar.TabIndex = 6;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Location = new System.Drawing.Point(10, 100);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(55, 13);
            this.lbCategoria.TabIndex = 67;
            this.lbCategoria.Text = "Categoria:";
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(13, 166);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(244, 20);
            this.tbValor.TabIndex = 3;
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Location = new System.Drawing.Point(10, 150);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(34, 13);
            this.lbValor.TabIndex = 64;
            this.lbValor.Text = "Valor:";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Enabled = false;
            this.tbCodigo.Location = new System.Drawing.Point(13, 66);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(244, 20);
            this.tbCodigo.TabIndex = 1;
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Location = new System.Drawing.Point(10, 50);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(43, 13);
            this.lbCodigo.TabIndex = 61;
            this.lbCodigo.Text = "Código:";
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(13, 115);
            this.cbCategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(244, 21);
            this.cbCategoria.TabIndex = 73;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(277, 313);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.tbQuantidade);
            this.Controls.Add(this.lbQuantidade);
            this.Controls.Add(this.lbCadastro);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.lbValor);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.lbCodigo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaCadastroVenda";
            this.Text = "TelaCadastroVenda";
            this.Load += new System.EventHandler(this.TelaCadastroVenda_Load);
            this.Shown += new System.EventHandler(this.TelaCadastroVenda_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.telaCadastroCategoriasBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telaCadastroCategoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telaCadastroCategoriasBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbQuantidade;
        private System.Windows.Forms.Label lbQuantidade;
        private System.Windows.Forms.Label lbCadastro;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.BindingSource telaCadastroCategoriasBindingSource;
        private System.Windows.Forms.BindingSource telaCadastroCategoriasBindingSource2;
        private System.Windows.Forms.BindingSource telaCadastroCategoriasBindingSource1;
        private System.Windows.Forms.ComboBox cbCategoria;
    }
}