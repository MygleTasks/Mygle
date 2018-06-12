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
        private List<Categoria> Categorias;

        public Gerenciador()
        {
            this.Usuarios = new List<Usuario>();
            this.Vendas = new List<Venda>();
            this.Categorias = new List<Categoria>();
        }

        public Validacao AdicionarUsuario(Usuario usuarioAdicionado)
        {
            Validacao validacao = new Validacao();

            if (this.Usuarios.Where(c=>c.NomeUsuario == usuarioAdicionado.NomeUsuario).Any())
            {
                validacao.Mensagens.Add("Nome de Usuário", "Nome de usuário não disponível");
            }
            if (String.IsNullOrEmpty(usuarioAdicionado.Nome))
            {
                validacao.Mensagens.Add("Nome", "O nome não pode ser nulo ou vazio");
            }
            if (String.IsNullOrEmpty(usuarioAdicionado.NomeUsuario))
            {
                validacao.Mensagens.Add("Nome de usuário", "O nome de usuário não pode ser nulo ou vazio");
            }
            if (String.IsNullOrEmpty(usuarioAdicionado.Senha))
            {
                validacao.Mensagens.Add("Senha", "A senha não pode ser nula ou vazia");
            }
            if (usuarioAdicionado.Senha != usuarioAdicionado.Senha2)
            {
                validacao.Mensagens.Add("Senha", "As senhas não conferem");
            }
            if (validacao.Valido)
            {
                this.Usuarios.Add(usuarioAdicionado);
            }
            return validacao;
        }

        public Validacao AdicionarVenda(Venda vendaAdicionada)
        {
            Validacao validacao = new Validacao();

            if (String.IsNullOrEmpty(vendaAdicionada.Nome))
            {
                validacao.Mensagens.Add("Nome", "O nome não pode ser nulo ou vazio");
            }
            if (vendaAdicionada.Quantidade<1)
            {
                validacao.Mensagens.Add("Quantidade", "A quantidade não pode ser menor do que 1");
            }
            if (vendaAdicionada.ValUnit<1)
            {
                validacao.Mensagens.Add("Valor Unitário", "O valor não pode ser menor do que 1");
            }
            
            if (validacao.Valido)
            {
                this.Vendas.Add(vendaAdicionada);
            }
            return validacao;
        }

        public Validacao AdicionarCategoria(Categoria categoriaAdicionada)
        {
            Validacao validacao = new Validacao();

            if (String.IsNullOrEmpty(categoriaAdicionada.Nome))
            {
                validacao.Mensagens.Add("Nome", "O nome não pode ser nulo ou vazio");
            }
            if (validacao.Valido)
            {
                this.Categorias.Add(categoriaAdicionada);
            }
            return validacao;
        }

        public List<Usuario> TodosOsUsuarios()
        {
            return this.Usuarios.ToList();
        }

        public List<Venda> TodasAsVendas()
        {
            return this.Vendas.ToList();
        }

        public List<Categoria> TodasAsCategorias()
        {
            return this.Categorias.ToList();
        }
        
    }
}
