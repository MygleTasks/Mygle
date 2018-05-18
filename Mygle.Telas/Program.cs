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
            Vendedor v = new Vendedor();
            string opcao = "0";
            do
            {
                Console.WriteLine("1 - Vendedor\n2 - Gerente\n");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "0": break;
                    case "1":
                        v.Menu();
                        break;

                }
            } while (opcao != "0");
        }
    }
}
