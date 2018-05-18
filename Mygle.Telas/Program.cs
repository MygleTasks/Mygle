using System;
using Mygle.Negocio;
using Mygle.Negocio.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mygle.Telas
{
    class Program
    {
        public static void Main(string[] args)
        {
            string opcao = "0";
            do
            {
                Console.WriteLine("1 - Vendedor\n2 - Gerente\n");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "0": break;

                    case "1":
                        MenuVendedor();
                        break;

                    case "2":
                        MenuGerente();
                        break;
                }
            } while (opcao != "0");
        }
        public static void MenuGerente()
        {
            string opcao = "0";
            Gerente gerente = new Gerente();
            do
            {
                Console.WriteLine("1 - Resumo\n2 - Detalhes\n3 - Usuários\n4 - Categorias");
                opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "0": break;

                    case "1":
                        gerente.Resumo();
                        break;

                    case "2":
                        gerente.Detalhes();
                        break;

                    case "3":
                        gerente.Usuarios();
                        break;

                    case "4":
                        gerente.Categorias();
                        break;
                }

            } while (opcao != "0");
        }
        public static void MenuVendedor()
        {
            string opcao = "0";
            Vendedor vendedor = new Vendedor();
            do
            {
                Console.Clear();
                Console.WriteLine("1 - Cadastrar venda\n2 - Resumo\n3 - Detalhes");
                opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "0": break;

                    case "1":
                        vendedor.AdicionarVenda();
                        break;

                    case "2":
                        vendedor.Resumo();
                        break;

                    case "3":
                        vendedor.Detalhes();
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            } while (opcao != "0");
        }
    }
}
