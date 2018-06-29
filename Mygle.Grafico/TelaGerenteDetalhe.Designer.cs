namespace Mygle.Grafico
{
    partial class TelaGerenteDetalhe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaGerenteDetalhe));
            this.lbDetalhe = new System.Windows.Forms.Label();
            this.dgDetalhes = new System.Windows.Forms.DataGridView();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoriaItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalhes)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDetalhe
            // 
            this.lbDetalhe.AutoSize = true;
            this.lbDetalhe.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lbDetalhe.Location = new System.Drawing.Point(12, 9);
            this.lbDetalhe.Name = "lbDetalhe";
            this.lbDetalhe.Size = new System.Drawing.Size(115, 31);
            this.lbDetalhe.TabIndex = 50;
            this.lbDetalhe.Text = "Detalhe";
            // 
            // dgDetalhes
            // 
            this.dgDetalhes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgDetalhes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetalhes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data,
            this.Vendedor,
            this.CategoriaItem,
            this.Valor,
            this.Quantidade});
            this.dgDetalhes.Location = new System.Drawing.Point(10, 65);
            this.dgDetalhes.Name = "dgDetalhes";
            this.dgDetalhes.Size = new System.Drawing.Size(577, 252);
            this.dgDetalhes.TabIndex = 51;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            // 
            // Vendedor
            // 
            this.Vendedor.DataPropertyName = "Usuario";
            this.Vendedor.HeaderText = "Vendedor";
            this.Vendedor.Name = "Vendedor";
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
            // TelaGerenteDetalhe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(599, 329);
            this.Controls.Add(this.dgDetalhes);
            this.Controls.Add(this.lbDetalhe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "TelaGerenteDetalhe";
            this.Text = "TelaGerenteDetalhe";
            this.Load += new System.EventHandler(this.TelaGerenteDetalhe_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TelaGerenteDetalhe_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalhes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDetalhe;
        private System.Windows.Forms.DataGridView dgDetalhes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoriaItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
    }
}