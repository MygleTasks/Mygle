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
using Mygle.Negocio.Persistencia;
using Mygle.Negocio.Models;
using Mygle.Negocio;

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

        private void Logar()
        {
            var usuario = tbUsuario.Text;
            var senha = tbSenha.Text;

            TelaGerenteResumo tela = new TelaGerenteResumo();
            TelaUsuarioResumo tela2 = new TelaUsuarioResumo();

            if (Program.Gerenciador.ValidaUsuarioSenha(usuario, senha))
            {
                if (tbUsuario.Text == "admin")
                {
                    tela.Show();
                }
                else
                {
                    tela2.Show();
                }

            }
            else
            {
                MessageBox.Show("Usuário e senha incorretos");
            }
        }

        private void TelaLoginMygle_Load(object sender, EventArgs e)
        {
            if (BuscaUsuarioPorId(0) == null)
            {
                CriarAdministrador();
            }
        }
        //Criar Usuário Administrador
        public void CriarAdministrador()
        {
            Usuario novoUsuario = new Usuario();
            novoUsuario.Id = Convert.ToInt64("0");
            novoUsuario.Nome = Convert.ToString("Administrador");
            novoUsuario.NomeUsuario = Convert.ToString("admin");
            novoUsuario.Senha = Convert.ToString("admin");
            novoUsuario.Senha2 = Convert.ToString("admin");
            Validacao validacao = Program.Gerenciador.AdicionarUsuario(novoUsuario);
        }
        private Banco banco = new Banco();
        public Usuario BuscaUsuarioPorId(long id)
        {
            return this.banco.Usuarios.Where(c => c.Id == id).FirstOrDefault();
        }

        private void llbRecuperarSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Entre em contato com o seu Gerente.");
        }
    }
}
