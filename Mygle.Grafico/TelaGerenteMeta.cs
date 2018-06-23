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
    public partial class TelaGerenteMeta : Form
    {
        public TelaGerenteMeta()
        {
            InitializeComponent();
        }

        private void lbCategorias_Click(object sender, EventArgs e)
        {

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Meta novaMeta = new Meta();
            novaMeta.Id = Convert.ToInt64(tbId.Text);
            novaMeta.ValorMeta = Convert.ToDouble(tbValor.Text);
            Negocio.Validacao validacao = Program.Gerenciador.AdicionarMeta(novaMeta);

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
    }
}
