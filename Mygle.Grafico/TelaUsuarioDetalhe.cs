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
    public partial class TelaUsuarioDetalhe : Form
    {
        public TelaUsuarioDetalhe()
        {
            InitializeComponent();
        }

        private void TelaUsuarioDetalhe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void AbreTelaInclusaoAlteracao(Venda vendaSelecionada)
        {
            TelaCadastroVenda tela = new TelaCadastroVenda();
            tela.MdiParent = this.MdiParent;
            tela.VendaSelecionada = vendaSelecionada;
            tela.FormClosed += Tela_FormClosed;
            tela.Show();
        }

        private void CarregarVendas()
        {
            dgVendas.AutoGenerateColumns = false;
            dgVendas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgVendas.MultiSelect = false;
            List<Venda> categorias = Program.Gerenciador.TodasAsVendas();
            dgVendas.DataSource = categorias;
        }

        private bool VerificarSelecao()
        {
            if (dgVendas.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma linha");
                return false;
            }
            return true;
        }

        private void Tela_FormClosed(object sender, FormClosedEventArgs e)
        {
            CarregarVendas();
        }

        private void TelaUsuarioDetalhe_Load(object sender, EventArgs e)
        {
            CarregarVendas();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (VerificarSelecao())
            {
                DialogResult resultado = MessageBox.Show("Tem certeza?", "Quer remover?", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    Venda vendaSelecionada = (Venda)dgVendas.SelectedRows[0].DataBoundItem;
                    var validacao = Program.Gerenciador.RemoverVenda(vendaSelecionada);
                    if (validacao.Valido)
                    {
                        MessageBox.Show("Venda removida com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro, contate o administrador.");

                    }
                    CarregarVendas();
                }
            }
        }

        private void dgVendas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (VerificarSelecao())
            {
                Venda vendaSelecionada = (Venda)dgVendas.SelectedRows[0].DataBoundItem;
                AbreTelaInclusaoAlteracao(vendaSelecionada);
            }
        }


    }
}
