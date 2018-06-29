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
    public partial class TelaUsuarioResumo : Form
    {
        public TelaUsuarioResumo()
        {
            InitializeComponent();
        }
        
        private void TelaUsuarioResumo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btCadastrarVenda_Click(object sender, EventArgs e)
        {
            TelaCadastroVenda tela = new TelaCadastroVenda();
            tela.Show();
        }

        private void btDetalhe_Click(object sender, EventArgs e)
        {
            TelaUsuarioDetalhe tela = new TelaUsuarioDetalhe();
            tela.Show();
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

        private void TelaUsuarioResumo_Shown(object sender, EventArgs e)
        {
            var ok = Program.Gerenciador.BuscaMetaPorId();
            if (ok != null)
            {
                Double Total = 0;
                int comissao = Program.Gerenciador.BuscaMetaPorId().PercComissao;
                foreach (Venda venda in Program.Gerenciador.VendasDoUsuarioLogado())
                {
                    Total += venda.ValorTotal;
                }
                double valorComissao = Total * comissao / 100;
                this.lbComissao.Text = valorComissao.ToString();
            }
        }

        public double ValorDiaUsuario()
        {
            Double Total = 0;
            foreach (Venda venda in Program.Gerenciador.VendasDoUsuarioLogado())
            {
                if (DateTime.Now.Day == venda.Data.Day)
                {
                    Total += venda.ValorTotal;
                }
            }
            return Total;
        }

        public double ValorMesUsuario()
        {
            Double Total = 0;
            foreach (Venda venda in Program.Gerenciador.VendasDoUsuarioLogado())
            {
                if (DateTime.Now.Month == venda.Data.Month)
                {
                    Total += venda.ValorTotal;
                }
            }
            return Total;
        }

        private void TelaUsuarioResumo_Load(object sender, EventArgs e)
        {
            var Meta = Program.Gerenciador.BuscaMetaPorId();
            if (Meta != null)
            {
                double meta = Program.Gerenciador.BuscaMetaPorId().ValorMeta;
                double metaMes = meta - ValorMesUsuario();
                double quantidadeDiasMes = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
                meta = ((meta / quantidadeDiasMes) - ValorDiaUsuario());
                meta = Math.Round(meta, 0);
                if (meta < 0)
                {
                    meta = 0;
                }
                if (metaMes < 0)
                {
                    metaMes = 0;
                }
                graUsuarioMes.Series["VendasMes"].Points.AddY(ValorMesUsuario());
                graUsuarioMes.Series["VendasMes"].Points.AddY(metaMes);
                graUsuarioDia.Series["VendasDia"].Points.AddY(ValorDiaUsuario());
                graUsuarioDia.Series["VendasDia"].Points.AddY(meta);
            }

        }
    }
}
