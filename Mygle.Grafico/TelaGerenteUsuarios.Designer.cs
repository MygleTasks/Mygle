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
            this.dgUsuarios = new System.Windows.Forms.DataGridView();
            this.Matrícula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuário = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btRemoverUsuario = new System.Windows.Forms.Button();
            this.btAlterarMeta = new System.Windows.Forms.Button();
            this.btAlterarUsuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btNovoUsuario
            // 
            this.btNovoUsuario.Location = new System.Drawing.Point(18, 65);
            this.btNovoUsuario.Name = "btNovoUsuario";
            this.btNovoUsuario.Size = new System.Drawing.Size(79, 35);
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
            // dgUsuarios
            // 
            this.dgUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Matrícula,
            this.Usuário,
            this.Usuario});
            this.dgUsuarios.Location = new System.Drawing.Point(18, 130);
            this.dgUsuarios.Name = "dgUsuarios";
            this.dgUsuarios.Size = new System.Drawing.Size(366, 278);
            this.dgUsuarios.TabIndex = 52;
            // 
            // Matrícula
            // 
            this.Matrícula.DataPropertyName = "Id";
            this.Matrícula.HeaderText = "ID";
            this.Matrícula.Name = "Matrícula";
            // 
            // Usuário
            // 
            this.Usuário.DataPropertyName = "Nome";
            this.Usuário.HeaderText = "Nome";
            this.Usuário.Name = "Usuário";
            // 
            // Usuario
            // 
            this.Usuario.DataPropertyName = "NomeUsuario";
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            // 
            // btRemoverUsuario
            // 
            this.btRemoverUsuario.Location = new System.Drawing.Point(313, 66);
            this.btRemoverUsuario.Name = "btRemoverUsuario";
            this.btRemoverUsuario.Size = new System.Drawing.Size(71, 34);
            this.btRemoverUsuario.TabIndex = 53;
            this.btRemoverUsuario.Text = "Remover Usuário";
            this.btRemoverUsuario.UseVisualStyleBackColor = true;
            this.btRemoverUsuario.Click += new System.EventHandler(this.btRemoverUsuario_Click);
            // 
            // btAlterarMeta
            // 
            this.btAlterarMeta.Location = new System.Drawing.Point(236, 65);
            this.btAlterarMeta.Name = "btAlterarMeta";
            this.btAlterarMeta.Size = new System.Drawing.Size(71, 34);
            this.btAlterarMeta.TabIndex = 54;
            this.btAlterarMeta.Text = "Alterar Meta";
            this.btAlterarMeta.UseVisualStyleBackColor = true;
            // 
            // btAlterarUsuario
            // 
            this.btAlterarUsuario.Location = new System.Drawing.Point(114, 64);
            this.btAlterarUsuario.Name = "btAlterarUsuario";
            this.btAlterarUsuario.Size = new System.Drawing.Size(76, 36);
            this.btAlterarUsuario.TabIndex = 55;
            this.btAlterarUsuario.Text = "Alterar Usuario";
            this.btAlterarUsuario.UseVisualStyleBackColor = true;
            this.btAlterarUsuario.Click += new System.EventHandler(this.btAlterarUsuario_Click);
            // 
            // TelaGerenteUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 420);
            this.Controls.Add(this.btAlterarUsuario);
            this.Controls.Add(this.btAlterarMeta);
            this.Controls.Add(this.btRemoverUsuario);
            this.Controls.Add(this.dgUsuarios);
            this.Controls.Add(this.btNovoUsuario);
            this.Controls.Add(this.lbResumo);
            this.KeyPreview = true;
            this.Name = "TelaGerenteUsuarios";
            this.Text = "TelaGerenteUsuarios";
            this.Load += new System.EventHandler(this.TelaGerenteUsuarios_Load);
            this.Shown += new System.EventHandler(this.TelaGerenteUsuarios_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TelaGerenteUsuarios_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btNovoUsuario;
        private System.Windows.Forms.Label lbResumo;
        private System.Windows.Forms.DataGridView dgUsuarios;
        private System.Windows.Forms.Button btRemoverUsuario;
        private System.Windows.Forms.Button btAlterarMeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matrícula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuário;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.Button btAlterarUsuario;
    }
}