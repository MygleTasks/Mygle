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
    }
}
