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
        static void Main(string[] args)
        {
            Vendedor vendedor = new Vendedor();
            Gerente gerente = new Gerente();

            string opcao = "0";
            do
            {
                Console.WriteLine("1 - Vendedor\n2 - Gerente\n");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "0": break;

                    case "1":
                        vendedor.Menu();
                        break;

                    case "2":
                        gerente.Menu();
                        break;
                }
            } while (opcao != "0");
        }
    }
}
