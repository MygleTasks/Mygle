namespace Mygle.Grafico
{
    partial class TelaUsuarioDetalhe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaUsuarioDetalhe));
            this.dgVendas = new System.Windows.Forms.DataGridView();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoriaItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lbDetalhe = new System.Windows.Forms.Label();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgVendas
            // 
            this.dgVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data,
            this.CategoriaItem,
            this.Valor,
            this.Quantidade,
            this.Check});
            this.dgVendas.Location = new System.Drawing.Point(18, 65);
            this.dgVendas.Name = "dgVendas";
            this.dgVendas.Size = new System.Drawing.Size(545, 268);
            this.dgVendas.TabIndex = 53;
            this.dgVendas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVendas_CellContentClick);
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            // 
            // CategoriaItem
            // 
            this.CategoriaItem.DataPropertyName = "Categoria";
            this.CategoriaItem.HeaderText = "Cat. Item";
            this.CategoriaItem.Name = "CategoriaItem";
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "ValorTotal";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // Quantidade
            // 
            this.Quantidade.DataPropertyName = "Quantidade";
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            // 
            // Check
            // 
            this.Check.HeaderText = "Check";
            this.Check.Name = "Check";
            // 
            // lbDetalhe
            // 
            this.lbDetalhe.AutoSize = true;
            this.lbDetalhe.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lbDetalhe.Location = new System.Drawing.Point(12, 9);
            this.lbDetalhe.Name = "lbDetalhe";
            this.lbDetalhe.Size = new System.Drawing.Size(115, 31);
            this.lbDetalhe.TabIndex = 52;
            this.lbDetalhe.Text = "Detalhe";
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(495, 17);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(68, 27);
            this.btExcluir.TabIndex = 57;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(421, 17);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(68, 27);
            this.btAlterar.TabIndex = 58;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // TelaUsuarioDetalhe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 348);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.dgVendas);
            this.Controls.Add(this.lbDetalhe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "TelaUsuarioDetalhe";
            this.Text = "TelaUsuarioDetalhe";
            this.Load += new System.EventHandler(this.TelaUsuarioDetalhe_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TelaUsuarioDetalhe_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgVendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgVendas;
        private System.Windows.Forms.Label lbDetalhe;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoriaItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
    }
}