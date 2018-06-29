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
    public partial class TelaGerenteCategorias : Form
    {
        public TelaGerenteCategorias()
        {
            InitializeComponent();
        }

        private bool VerificarSelecao()
        {
            if (dgCategorias.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma linha");
                return false;
            }
            return true;
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            TelaCadastroCategorias tela = new TelaCadastroCategorias();
            tela.FormClosed += Tela_FormClosed;
            tela.Show();
        }

        private void TelaGerenteCategorias_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void CarregarCategorias()
        {
            dgCategorias.AutoGenerateColumns = false;
            dgCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgCategorias.MultiSelect = false;
            List<Categoria> categorias = Program.Gerenciador.TodasAsCategorias();
            dgCategorias.DataSource = categorias;
        }

        private void Tela_FormClosed(object sender, FormClosedEventArgs e)
        {
            CarregarCategorias();
        }

        private void TelaGerenteCategorias_Load(object sender, EventArgs e)
        {
            CarregarCategorias();
        }

        private void btRemover_Click(object sender, EventArgs e)
        {            
            if(dgCategorias.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma linha.");
                return;
            }
            else
            {
                if (VerificarSelecao())
                {
                    DialogResult resultado = MessageBox.Show("Tem certeza?", "Quer remover?", MessageBoxButtons.OKCancel);
                    if (resultado == DialogResult.OK)
                    {
                        Categoria categoriaSelecionada = (Categoria)dgCategorias.SelectedRows[0].DataBoundItem;
                        var validacao = Program.Gerenciador.RemoverCategoria(categoriaSelecionada);
                        if (validacao.Valido)
                        {
                            MessageBox.Show("Categoria removida com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Ocorreu um erro, contate o administrador.");

                        }
                        CarregarCategorias();
                    }
                }
            }
        }

        
    }
}


