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
    public partial class TelaCadastroCategorias : Form
    {
        public TelaCadastroCategorias()
        {
            InitializeComponent();
        }

        private void TelaCadastroCategorias_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Categoria novaCategoria = new Categoria();
            novaCategoria.Id = Convert.ToInt64("1");
            novaCategoria.Nome = Convert.ToString(tbNome.Text);
            Validacao validacao = Program.Gerenciador.AdicionarCategoria(novaCategoria);

            String mensagemValidacao = "";
            if (!validacao.Valido)
            {
                foreach (var chave in validacao.Mensagens.Keys)
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

        private void tbId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
