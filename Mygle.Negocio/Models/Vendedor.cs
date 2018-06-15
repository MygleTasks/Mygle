using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mygle.Negocio.Models
{
    public class Vendedor
    {
        static Gerenciador gerenciador = new Gerenciador();

        public void AdicionarVenda()
        {
            Console.Clear();
            Venda novaVenda = new Venda();

            Console.Write("ID: ");
            novaVenda.Id = Convert.ToInt64(Console.ReadLine());

            Console.Write("Categoria: ");
            novaVenda.Categoria = Console.ReadLine();

            Console.Write("Quantidade: ");
            novaVenda.Quantidade = Convert.ToDouble(Console.ReadLine());

            Console.Write("Valor Unitário: ");
            novaVenda.ValorUnitario = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Data: ");
            string evento = Console.ReadLine();
            novaVenda.Data = Convert.ToDateTime(evento);
            
            Validacao validacao = gerenciador.AdicionarVenda(novaVenda);
            if (validacao.Valido)
            {
                Console.WriteLine("Usuario cadastrado com sucesso!");
            }
            else
            {
                foreach (var key in validacao.Mensagens.Keys)
                {
                    String mensagem = validacao.Mensagens[key];
                    Console.WriteLine($"{key}: {mensagem}");
                }
            }
            Console.ReadKey();
        }

        public void Resumo()
        {
            //...
        }

        public void Detalhes()
        {
            //...
        }
    }
}
