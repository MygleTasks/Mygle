using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mygle.Negocio.Models;

namespace Mygle.Grafico
{
    public partial class TelaGerenteResumo : Form
    {
        public TelaGerenteResumo()
        {
            InitializeComponent();
        }

        private void btDetalhe_Click(object sender, EventArgs e)
        {
            TelaGerenteDetalhe tela = new TelaGerenteDetalhe();
            tela.Show();
        }

        private void btUsuarios_Click(object sender, EventArgs e)
        {
            TelaGerenteUsuarios tela = new TelaGerenteUsuarios();
            tela.Show();
        }

        private void btCategorias_Click(object sender, EventArgs e)
        {
            TelaGerenteCategorias tela = new TelaGerenteCategorias();
            tela.Show();
        }

        private void TelaGerenteResumo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void Logout()
        {
            TelaGerenteResumo tela = new TelaGerenteResumo();
            this.Close();
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void lbValorVendido_Click(object sender, EventArgs e)
        {
            CalculoTotal();
        }

        public double CalculoTotal()
        {
            Double Total = 0;
            foreach (Venda venda in Program.Gerenciador.TodasAsVendas())
            {
                Total += venda.ValorTotal;
            }
            this.lbValorVendido.Text = Total.ToString();
            return Total;
        }

        private void TelaGerenteResumo_Load(object sender, EventArgs e)
        {
            var meta = Program.Gerenciador.BuscaMetaPorId();
            if(meta != null)
            {
                double valorMeta = meta.ValorMeta;
                graGerenteDia.Series["Vendas"].Points.AddY(CalculoTotal());
                graGerenteDia.Series["Vendas"].Points.AddY(valorMeta - CalculoTotal());
            }
            
        }
    }
}
