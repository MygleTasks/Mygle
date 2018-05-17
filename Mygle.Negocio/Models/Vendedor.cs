using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mygle.Negocio.Models
{
    public class Vendedor
    {
        public void Menu()
        {
            string opcao = "0";
            do
            {
                Console.WriteLine("1 - Cadastrar venda\n2 - Resumo\n3 - Detalhes");
                opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "0": break;
                    case "1":
                        AdicionarVenda();
                        break;
                }
                Console.ReadKey();
            } while (opcao != "0");
        }

        public void AdicionarVenda()
        {
            Venda novaVenda = new Venda();

            Console.Write("ID: ");
            novaVenda.Id = Convert.ToInt64(Console.ReadLine());

            Console.Write("Nome: ");
            novaVenda.nome = Console.ReadLine();

            Console.Write("Quantidade: ");
            novaVenda.quantidade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Valor Unitário: ");
            novaVenda.valUnit = Convert.ToDouble(Console.ReadLine());

            Console.Write("Data: ");
            //Código da data
        }
    }
}
