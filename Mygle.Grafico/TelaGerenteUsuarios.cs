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
    public partial class TelaGerenteUsuarios : Form
    {
        public TelaGerenteUsuarios()
        {
            InitializeComponent();
        }

        private void btNovoUsuario_Click(object sender, EventArgs e)
        {
            TelaCadastrarUsuario tela = new TelaCadastrarUsuario();
            tela.Show();
        }

        private void TelaGerenteUsuarios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
