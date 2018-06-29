using Mygle.Negocio;
using Mygle.Negocio.Models;
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
        public Usuario UsuarioSelecionado { get; set; }

        public TelaCadastrarUsuario()
        {
            InitializeComponent();
        }

        private void TelaCadastrarUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Usuario novoUsuario = new Usuario();
            if (UsuarioSelecionado == null)
            {
                novoUsuario.Id = Convert.ToInt64("1");
            }
            else
            {
                novoUsuario.Id = Convert.ToInt64(tbCodigo.Text);
            }          
            novoUsuario.Nome = Convert.ToString(tbNome.Text);
            novoUsuario.NomeUsuario = Convert.ToString(tbUsuario.Text);
            novoUsuario.Senha = Convert.ToString(tbSenha.Text);
;           novoUsuario.Senha2 = Convert.ToString(tbSenha2.Text);

            Validacao validacao;
            if (UsuarioSelecionado == null)
            {
                validacao = Program.Gerenciador.AdicionarUsuario(novoUsuario);
            }
            else
            {
                validacao = Program.Gerenciador.AlterarUsuario(novoUsuario);
            }

            String mensagemValidacao = "";
            if (!validacao.Valido)
            {
                foreach(var chave in validacao.Mensagens.Keys)
                {
                    String msg = validacao.Mensagens[chave];
                    mensagemValidacao += msg;
                    mensagemValidacao += Environment.NewLine;
                }
                MessageBox.Show(mensagemValidacao);
            }
            else
            {
                MessageBox.Show("Cadastrado com sucesso!");
            }
            this.Close();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TelaCadastrarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void TelaCadastrarUsuario_Shown(object sender, EventArgs e)
        {
            if (UsuarioSelecionado != null)
            {
                this.tbCodigo.Text = UsuarioSelecionado.Id.ToString();
                this.tbNome.Text = UsuarioSelecionado.Nome.ToString();
                this.tbUsuario.Text = UsuarioSelecionado.NomeUsuario.ToString();
            }
        }

        private void tbCodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}