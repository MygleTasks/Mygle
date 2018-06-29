namespace Mygle.Grafico
{
    partial class TelaGerenteCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaGerenteCategorias));
            this.dgCategorias = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.telaCadastroCategoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbCategorias = new System.Windows.Forms.Label();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.btRemover = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telaCadastroCategoriasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCategorias
            // 
            this.dgCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Item,
            this.Check});
            this.dgCategorias.Location = new System.Drawing.Point(36, 125);
            this.dgCategorias.Margin = new System.Windows.Forms.Padding(6);
            this.dgCategorias.Name = "dgCategorias";
            this.dgCategorias.Size = new System.Drawing.Size(924, 515);
            this.dgCategorias.TabIndex = 53;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "id";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Item
            // 
            this.Item.DataPropertyName = "Nome";
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            // 
            // Check
            // 
            this.Check.HeaderText = "Check";
            this.Check.Name = "Check";
            // 
            // telaCadastroCategoriasBindingSource
            // 
            this.telaCadastroCategoriasBindingSource.DataSource = typeof(Mygle.Grafico.TelaCadastroCategorias);
            // 
            // lbCategorias
            // 
            this.lbCategorias.AutoSize = true;
            this.lbCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lbCategorias.Location = new System.Drawing.Point(24, 17);
            this.lbCategorias.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbCategorias.Name = "lbCategorias";
            this.lbCategorias.Size = new System.Drawing.Size(299, 63);
            this.lbCategorias.TabIndex = 52;
            this.lbCategorias.Text = "Categorias";
            // 
            // btAdicionar
            // 
            this.btAdicionar.Location = new System.Drawing.Point(818, 33);
            this.btAdicionar.Margin = new System.Windows.Forms.Padding(6);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(142, 65);
            this.btAdicionar.TabIndex = 2;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // btRemover
            // 
            this.btRemover.Location = new System.Drawing.Point(652, 33);
            this.btRemover.Margin = new System.Windows.Forms.Padding(6);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(142, 65);
            this.btRemover.TabIndex = 1;
            this.btRemover.Text = "Remover";
            this.btRemover.UseVisualStyleBackColor = true;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // TelaGerenteCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 660);
            this.Controls.Add(this.btRemover);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.dgCategorias);
            this.Controls.Add(this.lbCategorias);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "TelaGerenteCategorias";
            this.Text = "TelaGerenteCategorias";
            this.Load += new System.EventHandler(this.TelaGerenteCategorias_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TelaGerenteCategorias_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telaCadastroCategoriasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCategorias;
        private System.Windows.Forms.Label lbCategorias;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.BindingSource telaCadastroCategoriasBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
    }
}