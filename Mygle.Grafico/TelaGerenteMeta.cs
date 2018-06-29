using Mygle.Negocio.Models;
using Mygle.Negocio;
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
            var meta = Program.Gerenciador.BuscaMetaPorId();
            if (meta == null)
            {
                novaMeta.Id = Convert.ToInt64("1");
            }
            else
            {
                novaMeta.Id = Convert.ToInt64(tbId.Text);
            }
            novaMeta.ValorMeta = Convert.ToDouble(tbValor.Text);
            novaMeta.PercComissao = Convert.ToInt32(tbComissao.Text);
            
            Validacao validacao;
            if (meta == null)
            {
                validacao = Program.Gerenciador.AdicionarMeta(novaMeta);
            }
            else
            {
                validacao = Program.Gerenciador.AlterarMeta(novaMeta);
            }

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

        private void TelaGerenteMeta_Shown(object sender, EventArgs e)
        {
            var meta = Program.Gerenciador.BuscaMetaPorId();
            if (meta != null)
            {
                this.tbId.Text =meta.Id.ToString();
                this.tbValor.Text = meta.ValorMeta.ToString();
                this.tbComissao.Text = meta.PercComissao.ToString();
            }
        }
    }
}
