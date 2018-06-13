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
    public partial class TelaGerenteDetalhe : Form
    {
        public TelaGerenteDetalhe()
        {
            InitializeComponent();
        }

        private void TelaGerenteDetalhe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void CarregarDetalhes()
        {
            dgDetalhes.AutoGenerateColumns = false;
            dgDetalhes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgDetalhes.MultiSelect = false;
            List<Venda> vendas = Program.Gerenciador.TodasAsVendas();
            dgDetalhes.DataSource = vendas;
        }

        private void Tela_FormClosed(object sender, FormClosedEventArgs e)
        {
            CarregarDetalhes();
        }
        
        private void TelaGerenteDetalhe_Load(object sender, EventArgs e)
        {
            CarregarDetalhes();
        }
    }
}
