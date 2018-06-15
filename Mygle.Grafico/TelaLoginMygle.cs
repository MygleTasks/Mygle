using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Mygle.Grafico
{
    public partial class TelaLoginMygle : Form
    {
        private const string Usuario="Usuário";
        private const string Senha = "Senha";

        public TelaLoginMygle()
        {
            InitializeComponent();
        }

        private void Logar()
        {
            TelaGerenteResumo tela = new TelaGerenteResumo();
            // tela.MdiParent = this.MdiParent;
            tela.Show();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            Logar();
        }

        private void tbSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Logar();
            }
        }

        private void TelaLoginMygle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }



        private void Logar2()
        {
            var usuario = tbUsuario.Text;
            var senha = tbSenha.Text;
            TelaUsuarioResumo tela = new TelaUsuarioResumo();

            if (Program.Gerenciador.ValidaUsuarioSenha(usuario, senha))
            {
                //tela.Show();
            }
            else
            {
                MessageBox.Show("Usuário e senha incorretos");
            }            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  Logar2();
            TelaUsuarioResumo tela = new TelaUsuarioResumo();
            tela.Show();
        }

        private void TelaLoginMygle_Load(object sender, EventArgs e)
        {

        }
    }
}
