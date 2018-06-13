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

        private void CarregarVendas()
        {
            dgVendas.AutoGenerateColumns = false;
            dgVendas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgVendas.MultiSelect = false;
            List<Venda> categorias = Program.Gerenciador.TodasAsVendas();
            dgVendas.DataSource = categorias;
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
            if (dgVendas.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma linha.");
                return;
            }
            else
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
}
