using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mygle.Grafico
{
    public partial class TelaCadastrarUsuario : Form
    {
        private TextBox tbNome;
        private Label label1;
        private Button btSalvar;
        private Label lbCadastroUsuario;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;

        public TelaCadastrarUsuario()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btSalvar = new System.Windows.Forms.Button();
            this.lbCadastroUsuario = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(77, 61);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(231, 20);
            this.tbNome.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "ID:";
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(240, 7);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(68, 27);
            this.btSalvar.TabIndex = 64;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            // 
            // lbCadastroUsuario
            // 
            this.lbCadastroUsuario.AutoSize = true;
            this.lbCadastroUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbCadastroUsuario.Location = new System.Drawing.Point(12, 9);
            this.lbCadastroUsuario.Name = "lbCadastroUsuario";
            this.lbCadastroUsuario.Size = new System.Drawing.Size(174, 20);
            this.lbCadastroUsuario.TabIndex = 63;
            this.lbCadastroUsuario.Text = "Cadastro de Usuário";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(231, 20);
            this.textBox1.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "Matrícula:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(77, 113);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(231, 20);
            this.textBox2.TabIndex = 71;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 70;
            this.label3.Text = "Nome:";
            // 
            // TelaCadastrarUsuario
            // 
            this.ClientSize = new System.Drawing.Size(322, 148);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.lbCadastroUsuario);
            this.Name = "TelaCadastrarUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
