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
    public partial class TelaGerenteCategorias : Form
    {
        public TelaGerenteCategorias()
        {
            InitializeComponent();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            TelaCadastroCategorias tela = new TelaCadastroCategorias();
            tela.Show();
        }
    }
}
