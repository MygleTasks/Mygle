namespace Mygle.Grafico
{
    partial class TelaGerenteUsuarios
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
            this.btNovoUsuario = new System.Windows.Forms.Button();
            this.lbResumo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Matrícula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuário = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btRemoverUsuario = new System.Windows.Forms.Button();
            this.btAlterarMeta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btNovoUsuario
            // 
            this.btNovoUsuario.Location = new System.Drawing.Point(18, 65);
            this.btNovoUsuario.Name = "btNovoUsuario";
            this.btNovoUsuario.Size = new System.Drawing.Size(124, 35);
            this.btNovoUsuario.TabIndex = 51;
            this.btNovoUsuario.Text = "Cadastrar Usuário";
            this.btNovoUsuario.UseVisualStyleBackColor = true;
            this.btNovoUsuario.Click += new System.EventHandler(this.btNovoUsuario_Click);
            // 
            // lbResumo
            // 
            this.lbResumo.AutoSize = true;
            this.lbResumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lbResumo.Location = new System.Drawing.Point(12, 9);
            this.lbResumo.Name = "lbResumo";
            this.lbResumo.Size = new System.Drawing.Size(130, 31);
            this.lbResumo.TabIndex = 49;
            this.lbResumo.Text = "Usuários";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Matrícula,
            this.Usuário});
            this.dataGridView1.Location = new System.Drawing.Point(18, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(357, 271);
            this.dataGridView1.TabIndex = 52;
            // 
            // Matrícula
            // 
            this.Matrícula.HeaderText = "Matrícula";
            this.Matrícula.Name = "Matrícula";
            // 
            // Usuário
            // 
            this.Usuário.HeaderText = "Usuário";
            this.Usuário.Name = "Usuário";
            // 
            // btRemoverUsuario
            // 
            this.btRemoverUsuario.Location = new System.Drawing.Point(304, 66);
            this.btRemoverUsuario.Name = "btRemoverUsuario";
            this.btRemoverUsuario.Size = new System.Drawing.Size(71, 34);
            this.btRemoverUsuario.TabIndex = 53;
            this.btRemoverUsuario.Text = "Remover Usuário";
            this.btRemoverUsuario.UseVisualStyleBackColor = true;
            // 
            // btAlterarMeta
            // 
            this.btAlterarMeta.Location = new System.Drawing.Point(227, 65);
            this.btAlterarMeta.Name = "btAlterarMeta";
            this.btAlterarMeta.Size = new System.Drawing.Size(71, 34);
            this.btAlterarMeta.TabIndex = 54;
            this.btAlterarMeta.Text = "Alterar Meta";
            this.btAlterarMeta.UseVisualStyleBackColor = true;
            // 
            // TelaGerenteUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 420);
            this.Controls.Add(this.btAlterarMeta);
            this.Controls.Add(this.btRemoverUsuario);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btNovoUsuario);
            this.Controls.Add(this.lbResumo);
            this.KeyPreview = true;
            this.Name = "TelaGerenteUsuarios";
            this.Text = "TelaGerenteUsuarios";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TelaGerenteUsuarios_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btNovoUsuario;
        private System.Windows.Forms.Label lbResumo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matrícula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuário;
        private System.Windows.Forms.Button btRemoverUsuario;
        private System.Windows.Forms.Button btAlterarMeta;
    }
}