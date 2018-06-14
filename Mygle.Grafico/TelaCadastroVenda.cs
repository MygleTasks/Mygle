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
    public partial class TelaCadastroVenda : Form
    {
        public TelaCadastroVenda()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Venda novaVenda = new Venda();
            novaVenda.Categoria = Convert.ToString(tbCategoria.Text);
            novaVenda.ValorUnitario = Convert.ToDecimal(tbValorVenda.Text);
            novaVenda.Quantidade = Convert.ToInt32(tbQtd.Text);
            Validacao validacao = Program.Gerenciador.AdicionarVenda(novaVenda);
            
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
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TelaCadastroVenda_Load(object sender, EventArgs e)
        {

        }
    }
}
