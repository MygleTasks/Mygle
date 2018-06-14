using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            // tela.MdiParent = this.MdiParent;
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

        private void TelaLoginMygle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }



        private void Logar2()
        {
            TelaUsuarioResumo tela = new TelaUsuarioResumo();
            SqlConnection log = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From dbo.Usuarios where Nome='" + tbUsuario.Text +"' and Senha ='" + tbSenha.Text +"'",log);
            DataTable dtlogin = new DataTable();
            sda.Fill(dtlogin);
            if ( dtlogin.Rows[0][0].ToString() == "1")
            {
                tela.Show();
            }
            else
            {
                MessageBox.Show("Verifique o Usuário e a senha");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Logar2();
        }

        
    }
}
