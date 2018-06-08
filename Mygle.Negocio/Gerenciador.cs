using Mygle.Negocio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mygle.Negocio
{
    public class Gerenciador
    {
        private List<Usuario> Usuarios;
        private List<Venda> Vendas; 

        public Gerenciador()
        {
            this.Usuarios = new List<Usuario>();
            this.Vendas = new List<Venda>();
        }

        public void AdicionarUsuario(Usuario usuarioAdicionado)
        {
            if (String.IsNullOrEmpty(usuarioAdicionado.nome))
            {
                return;
            }
            if (String.IsNullOrEmpty(usuarioAdicionado.matricula))
            {
                return;
            }
            this.Usuarios.Add(usuarioAdicionado);
        }

        public List<Usuario> TodosOsUsuarios()
        {
            return this.Usuarios.ToList();
        }

        public void AdicionarVenda(Venda vendaAdicionada)
        {
            this.Vendas.Add(vendaAdicionada);
        }
    }
}
