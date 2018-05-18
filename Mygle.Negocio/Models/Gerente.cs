using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mygle.Negocio.Models
{
    public class Gerente
    {
        public void Menu()
        {
            string opcao = "0";
            do
            {
                Console.WriteLine("1 - Resumo\n2 - Detalhes\n3 - Usuários\n4 - Categorias");
                opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "0": break;

                    case "1":
                        Resumo();
                        break;

                    case "2":
                        Detalhes();
                        break;

                    case "3":
                        Usuarios();
                        break;

                    case "4":
                        Categorias();
                        break;
                }

            } while (opcao != "0");
        }
    }
}
