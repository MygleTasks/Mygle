﻿using Mygle.Negocio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mygle.Negocio.Persistencia;

namespace Mygle.Negocio
{
    public class Gerenciador
    {
        public Usuario UsuarioLogado { get; set; }

        private Banco banco = new Banco();

        //Alterar Meta
        public Validacao AlterarMeta(Meta MetaAlterada)
        {
            Validacao validacao = new Validacao();
            Meta metaBanco = BuscaMetaPorId();
            metaBanco.ValorMeta = MetaAlterada.ValorMeta;
            metaBanco.PercComissao = MetaAlterada.PercComissao;
            this.banco.SaveChanges();
            return validacao;
        }
        //RemoverCategoria
        public Validacao RemoverCategoria(Categoria categoria)
        {
            Validacao validacao = new Validacao();
            banco.Categorias.Remove(categoria);
            banco.SaveChanges();
            return validacao;
        }

        //AlterarVenda
        public Validacao AlterarUsuario(Usuario UsuarioAlterado)
        {
            Validacao validacao = new Validacao();
            Usuario usuarioBanco = BuscaUsuarioPorId(UsuarioAlterado.Id);
            usuarioBanco.Nome = UsuarioAlterado.Nome;
            usuarioBanco.NomeUsuario = UsuarioAlterado.NomeUsuario;
            usuarioBanco.Senha = UsuarioAlterado.Senha;
            usuarioBanco.Senha2 = UsuarioAlterado.Senha2;
            this.banco.SaveChanges();
            return validacao;
        }
        //RemoverUsuario
        public Validacao RemoverUsuario(Usuario usuario)
        {
            Validacao validacao = new Validacao();
            banco.Usuarios.Remove(usuario);
            banco.SaveChanges();
            return validacao;
        }

        //AlterarDetalhe
        public Validacao AlterarVenda(Venda VendaAlterada)
        {
            Validacao validacao = new Validacao();
            Venda vendaBanco = BuscaVendaPorId(VendaAlterada.Id);
            vendaBanco.Categoria = VendaAlterada.Categoria;
            vendaBanco.ValorUnitario = VendaAlterada.ValorUnitario;
            vendaBanco.Quantidade = VendaAlterada.Quantidade;
            this.banco.SaveChanges();
            return validacao;
        }
        //RemoverDetalhe
        public Validacao RemoverVenda(Venda venda)
        {
            Validacao validacao = new Validacao();
            banco.Vendas.Remove(venda);
            banco.SaveChanges();
            return validacao;
        }

        //Validação de novo usuário
        public Validacao AdicionarUsuario(Usuario usuarioAdicionado)
        {
            Validacao validacao = new Validacao();

            if (this.banco.Usuarios.Where(c=>c.NomeUsuario == usuarioAdicionado.NomeUsuario).Any())
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

            //Gravação de dados no banco
            if (validacao.Valido)
            {
                this.banco.Usuarios.Add(usuarioAdicionado);
                this.banco.SaveChanges();
            }
            return validacao;
        }

        //Validação de nova venda
        public Validacao AdicionarVenda(Venda vendaAdicionada)
        {
            Validacao validacao = new Validacao();

            if (String.IsNullOrEmpty(vendaAdicionada.Categoria))
            {
                validacao.Mensagens.Add("Nome", "A categoria não pode ser nulo ou vazio");
            }
            if (vendaAdicionada.Quantidade<1)
            {
                validacao.Mensagens.Add("Quantidade", "A quantidade não pode ser menor do que 1");
            }
            if (vendaAdicionada.ValorUnitario < 1)
            {
                validacao.Mensagens.Add("Valor Unitário", "O valor não pode ser menor do que 1");
            }
            
            //Gravação de dados no banco
            if (validacao.Valido)
            {
                this.banco.Vendas.Add(vendaAdicionada);
                this.banco.SaveChanges();
            }
            return validacao;
        }

        //Validação de nova categoria
        public Validacao AdicionarCategoria(Categoria categoriaAdicionada)
        {
            Validacao validacao = new Validacao();

            if (String.IsNullOrEmpty(categoriaAdicionada.Nome))
            {
                validacao.Mensagens.Add("Nome", "O nome não pode ser nulo ou vazio");
            }

            //Gravação de dados no banco
            if (validacao.Valido)
            {
                this.banco.Categorias.Add(categoriaAdicionada);
                this.banco.SaveChanges();
            }
            return validacao;
        }

        public Validacao AdicionarMeta(Meta metaAdicionada)
        {
            Validacao validacao = new Validacao();

            //Gravação de dados no banco
            if (validacao.Valido)
            {
                this.banco.Metas.Add(metaAdicionada);
                this.banco.SaveChanges();
            }
            return validacao;
        }

        //Métodos para listagem de usuários, vendas e categorias
        public virtual List<Usuario> TodosOsUsuarios()
        {
            return this.banco.Usuarios.ToList();
        }

        public virtual List<Venda> TodasAsVendas()
        {
            return this.banco.Vendas.ToList();
        }
        
        public virtual List<Categoria> TodasAsCategorias()
        {
            return this.banco.Categorias.ToList();
        }

        public virtual List<Venda> VendasDoUsuarioLogado()
        {
            return this.banco
                          .Vendas
                          .Include("Usuario")
                          .Where(m => m.Usuario.Id == this.UsuarioLogado.Id)
                          .ToList();
        }

        //Buscar Informações do Banco
        public Venda BuscaVendaPorId(long id)
        {
            return this.banco.Vendas.Where(c => c.Id == id).FirstOrDefault();
        }
        public Usuario BuscaUsuarioPorId(long id)
        {
            return this.banco.Usuarios.Where(c => c.Id == id).FirstOrDefault();
        }
        public Meta BuscaMetaPorId()
        {
            return this.banco.Metas.FirstOrDefault();
        }

        //Login
        public bool ValidaUsuarioSenha(String usuario, String senha)
        {
            var usuarioDb = this.banco.Usuarios.Where(m => m.NomeUsuario == usuario).FirstOrDefault();
            if (usuarioDb != null)
            {
                if (usuarioDb.Senha == senha)
                {
                    this.UsuarioLogado = usuarioDb;
                    return true;
                }
            }
            return false;
        }
    }
}
