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
    public partial class TelaLoginMygle : Form
    {
        private const string Usuario="Usuário";
        private const string Senha = "Senha";

        public TelaLoginMygle()
        {
            InitializeComponent();
        }

        private void Logar()
        {
            TelaGerenteResumo tela = new TelaGerenteResumo();
            tela.Show();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            Logar();
        }

        private void tbSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Logar();
            }
        }

        
    }
}
