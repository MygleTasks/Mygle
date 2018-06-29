using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
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
            ValorDia();
        }

        public double ValorDia()
        {
            Double Total = 0;
            foreach (Venda venda in Program.Gerenciador.TodasAsVendas())
            {
                if (DateTime.Now.Day == venda.Data.Day)
                {
                    Total += venda.ValorTotal;
                }
            }
            return Total;
        }

        public double ValorMes()
        {
            Double Total = 0;
            foreach (Venda venda in Program.Gerenciador.TodasAsVendas())
            {
                if(DateTime.Now.Month == venda.Data.Month)
                {
                   Total += venda.ValorTotal;
                }
            }
            return Total;
        }

        private void TelaGerenteResumo_Load(object sender, EventArgs e)
        {
            var Meta = Program.Gerenciador.BuscaMetaPorId();
            if(Meta != null)
            {
                double meta = Program.Gerenciador.BuscaMetaPorId().ValorMeta;
                double metaMes = meta - ValorMes();
                double quantidadeDiasMes = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
                meta = ((meta/quantidadeDiasMes)-ValorDia());
                meta = Math.Round(meta, 0);
                if(meta < 0)
                {
                    meta = 0;
                }
                if(metaMes<0)
                {
                    metaMes = 0;
                }
                
                graGerenteMes.Series["Vendas"].LegendText = " ";
                graGerenteMes.Series["Vendas"].Points.AddY(ValorMes());
                graGerenteMes.Series["Vendas"].Points.AddY(metaMes);
                graGerenteDia.Series["VendasDia"].LegendText = " ";
                graGerenteDia.Series["VendasDia"].Points.AddY(ValorDia());
                graGerenteDia.Series["VendasDia"].Points.AddY(meta);
            }
        }

        private void btMeta_Click(object sender, EventArgs e)
        {
            TelaGerenteMeta tela = new TelaGerenteMeta();
            tela.Show();
        }

        private void graGerenteDia_Click(object sender, EventArgs e)
        {

        }
    }
}
