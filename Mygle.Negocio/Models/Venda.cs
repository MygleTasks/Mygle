using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mygle.Negocio.Models
{
    public class Venda
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public double ValUnit { get; set; }
        public DateTime Data { get; set; }

        public double ValorTotal()
        {
            return Quantidade * ValUnit;
        }
    }
}
