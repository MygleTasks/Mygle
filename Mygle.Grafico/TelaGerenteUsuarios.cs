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
    public partial class TelaGerenteUsuarios : Form
    {
        public TelaGerenteUsuarios()
        {
            InitializeComponent();
        }

        private void btNovoUsuario_Click(object sender, EventArgs e)
        {
            TelaCadastrarUsuario tela = new TelaCadastrarUsuario();
            tela.FormClosed += Tela_FormClosed;
            tela.Show();
        }

        private void TelaGerenteUsuarios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void CarregarUsuarios()
        {
            dgUsuarios.AutoGenerateColumns = false;
            dgUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgUsuarios.MultiSelect = false;
            List<Usuario> usuarios = Program.Gerenciador.TodosOsUsuarios();
            dgUsuarios.DataSource = usuarios;
        }

        private void TelaGerenteUsuarios_Load(object sender, EventArgs e)
        {
            CarregarUsuarios();
        }

        private void Tela_FormClosed(object sender, FormClosedEventArgs e)
        {
            CarregarUsuarios();
        }

        private void btRemoverUsuario_Click(object sender, EventArgs e)
        {
            if (dgUsuarios.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma linha.");
                return;
            }
            else
            {
                Usuario usuarioSelecionado = (Usuario)dgUsuarios.SelectedRows[0].DataBoundItem;
                var validacao = Program.Gerenciador.RemoverUsuario(usuarioSelecionado);
                if (validacao.Valido)
                {
                    MessageBox.Show("Usuário removido com sucesso!");
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro, contate o administrador.");

                }
                CarregarUsuarios();
            }
        }
    }
}
