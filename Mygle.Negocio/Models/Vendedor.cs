using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mygle.Negocio.Models
{
    public class Vendedor
    {
        List<Venda> vendas = new List<Venda>();

        public void AdicionarVenda()
        {
            Console.Clear();
            Venda novaVenda = new Venda();

            Console.Write("ID: ");
            novaVenda.Id = Convert.ToInt64(Console.ReadLine());

            Console.Write("Nome: ");
            novaVenda.nome = Console.ReadLine();

            Console.Write("Quantidade: ");
            novaVenda.quantidade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Valor Unitário: ");
            novaVenda.valUnit = Convert.ToDouble(Console.ReadLine());

            novaVenda.valTotal = novaVenda.valUnit * novaVenda.quantidade;

            Console.Write("Data: ");
            string evento = Console.ReadLine();
            novaVenda.data = Convert.ToDateTime(evento);

            vendas.Add(novaVenda);
            Console.WriteLine("Venda cadastrada com sucesso!");
            Console.ReadKey();
        }

        public void Resumo()
        {
            
        }

        public void Detalhes()
        {
            Console.Clear();
            foreach (Venda venda in vendas)
            {
                Console.WriteLine("ID: {0}\nNome: {1}\nQuantidade: {2}\nValor Unitário: {3}\nValor Total: {4}\nData: {5}\n", venda.Id, venda.nome, venda.quantidade, venda.valUnit, venda.valTotal, venda.data.ToString("dd/MM/yyyy"));
            }
            Console.ReadKey();
        }
    }
}
