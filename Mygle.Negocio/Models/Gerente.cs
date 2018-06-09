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
                        ListarUsuarios();
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
            Console.Write("Informe o nome do usuário: ");
            novoUsuario.nome = Console.ReadLine();
            Console.Write("Informe a matrícula do usuário: ");
            novoUsuario.matricula = Console.ReadLine();

            gerenciador.AdicionarUsuario(novoUsuario);
            Console.WriteLine("Usuario cadastrado com sucesso!");
            Console.ReadKey();
        }

        public void RemoverUsuarios()
        {
            //codigo
        }

        public void ListarUsuarios()
        {
            Console.Clear();
            List<Usuario> usuariosCadastrados = gerenciador.TodosOsUsuarios();
            foreach(Usuario usuario in usuariosCadastrados)
            {
                Console.WriteLine(usuario.Descrever());
            }
            Console.ReadKey();
        }
    }
}
