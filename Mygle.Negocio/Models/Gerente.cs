using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mygle.Negocio.Models
{
    public class Gerente
    {
        static Gerenciador gerenciador = new Gerenciador();

        public void Resumo()
        {
            throw new NotImplementedException();
        }

        public void Detalhes()
        {
            throw new NotImplementedException();
        }

        public void Usuarios()
        {
            string opcao = "0";
            do
            {
                Console.Clear();
                Console.WriteLine("1 - Adicionar Usuarios\n2 - Remover Usuários\n3 - Listar Usuários");
                opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "0": break;
                    case "1":
                        AdicionarUsuarios();
                        break;
                    case "2":
                        RemoverUsuarios();
                        break;
                    case "3":
                        
                        break;
                }
            } while (opcao != "0");
        }

        public void Categorias()
        {
            throw new NotImplementedException();
        }

        public void AdicionarUsuarios()
        {
            Console.Clear();
            Usuario novoUsuario = new Usuario();
            Console.Write("Informe o ID: ");
            novoUsuario.Id = Convert.ToInt64(Console.ReadLine());
            Console.Write("Informe o nome: ");
            novoUsuario.Nome = Console.ReadLine();
            Console.Write("Informe a nome de usuário: ");
            novoUsuario.NomeUsuario = Console.ReadLine();
            Console.Write("Informe a senha: ");
            novoUsuario.Senha = Console.ReadLine();
            Console.Write("Informe a senha novamente: ");
            novoUsuario.Senha2 = Console.ReadLine();

            Validacao validacao = gerenciador.AdicionarUsuario(novoUsuario);
            if (validacao.Valido)
            {
                Console.WriteLine("Usuario cadastrado com sucesso!");
            }
            else
            {
                foreach(var key in validacao.Mensagens.Keys)
                {
                    String mensagem = validacao.Mensagens[key];
                    Console.WriteLine($"{key}: {mensagem}");
                }
            }
            Console.ReadKey();
        }

        public void RemoverUsuarios()
        {
            //codigo
        }
    }
}
